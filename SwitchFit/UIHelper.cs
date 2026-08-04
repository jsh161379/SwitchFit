using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace SwitchFit
{
    internal class UIHelper
    {
        // 🎨 배경 및 컬러 팔레트
        public static Color GradStartColor = Color.FromArgb(255, 254, 235); // 소프트 크림 베이지
        public static Color GradEndColor = Color.FromArgb(235, 233, 245);   // 차분한 회보라

        public static Color BgColor = Color.FromArgb(248, 250, 252);        // #f8fafc 원래 기본 배경색
        public static Color CardBgColor = Color.FromArgb(255, 255, 255);    // 카드 배경

        public static Color PrimaryColor = Color.FromArgb(79, 70, 229);      // 포인트 버튼 (인디고)
        public static Color PrimaryHover = Color.FromArgb(67, 56, 202);

        public static Color SecondaryColor = Color.FromArgb(255, 255, 255);   // 보조 버튼 (화이트)
        public static Color SecondaryHover = Color.FromArgb(241, 245, 249);
        public static Color BorderColor = Color.FromArgb(226, 232, 240);      // 테두리
        public static Color TextPrimary = Color.FromArgb(30, 41, 59);         // 메인 글자
        public static Color TextSecondary = Color.FromArgb(71, 85, 105);      // 서브 글자

        // 1️⃣ 그라데이션 테마 적용 (기본용)
        public static void ApplyModernTheme(Control parent)
        {
            if (parent is Form form)
            {
                ApplyGradientBackground(form);
            }

            ApplyChildControlsStyle(parent);
        }

        public static void ApplySolidTheme(Control parent)
        {
            // 1) 폼/유저컨트롤 자체를 단색으로 변경
            parent.BackColor = BgColor;

            // 2) 이전에 ApplyGradientBackground로 인해 등록된 Paint 이벤트를 덮어씌워 단색으로 클리어
            parent.Paint += (s, e) =>
            {
                using (SolidBrush brush = new SolidBrush(BgColor))
                {
                    e.Graphics.FillRectangle(brush, parent.ClientRectangle);
                }
            };

            // 3) 최상위 화면 즉시 갱신
            parent.Invalidate();

            // 4) 하위 컨트롤들 스타일 설정
            ApplyChildControlsStyle(parent, isSolidMode: true);
        }

        // 공통 자식 컨트롤 스타일링
        private static void ApplyChildControlsStyle(Control parent, bool isSolidMode = false)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = lbl.Font.Bold ? TextPrimary : TextSecondary;
                    lbl.Font = new Font("맑은 고딕", lbl.Font.Size, lbl.Font.Style);
                }
                else if (c is Button btn)
                {
                    StyleButton(btn);
                }
                else if (c is GroupBox gb)
                {
                    gb.Font = new Font("맑은 고딕", 9f);
                    gb.ForeColor = TextPrimary;
                    // 솔리드 모드일 때는 패널/그룹박스도 배경색을 통일시킵니다.
                    gb.BackColor = isSolidMode ? BgColor : Color.Transparent;
                    gb.Padding = new Padding(10);
                }
                else if (c is Panel pnl)
                {
                    // 솔리드 모드일 때는 흰색 카드가 아니라 전체 바탕색(#f8fafc)으로 동일하게 처리
                    pnl.BackColor = isSolidMode ? BgColor : Color.Transparent;
                }
                else if (c is ComboBox cbo)
                {
                    cbo.Font = new Font("맑은 고딕", 10f);
                    cbo.FlatStyle = FlatStyle.Flat;
                }
                else if (c is ListBox lb)
                {
                    lb.Font = new Font("맑은 고딕", 10f);
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    lb.ItemHeight = 28;
                }
                else if (c is ProgressBar pgb)
                {
                    StyleProgressBarAnimated(pgb);
                }

                if (c.HasChildren)
                {
                    ApplyChildControlsStyle(c, isSolidMode);
                }
            }
        }

        // 🎨 그라데이션 배경 그리기
        public static void ApplyGradientBackground(Control control)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            property?.SetValue(control, true, null);

            control.Paint += (s, e) =>
            {
                Rectangle rect = control.ClientRectangle;
                if (rect.Width <= 0 || rect.Height <= 0) return;

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect, GradStartColor, GradEndColor, 45f))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            };

            control.Resize += (s, e) => control.Invalidate();
        }

        private static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.BackColor = Color.Transparent;
            btn.Font = new Font("맑은 고딕", 10f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Region = null;

            bool isPrimary = btn.Text.Contains("시작") || btn.Text.Contains("타건") || btn.Text.Contains("찾기");

            Color baseColor = isPrimary ? PrimaryColor : SecondaryColor;
            Color hoverColor = isPrimary ? PrimaryHover : SecondaryHover;
            Color textColor = isPrimary ? Color.White : TextPrimary;

            Color currentColor = baseColor;

            btn.MouseEnter += (s, e) => { currentColor = hoverColor; btn.Invalidate(); };
            btn.MouseLeave += (s, e) => { currentColor = baseColor; btn.Invalidate(); };

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

                Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
                using (GraphicsPath path = GetRoundedPath(rect, 8))
                using (SolidBrush fillBrush = new SolidBrush(currentColor))
                {
                    e.Graphics.FillPath(fillBrush, path);

                    if (!isPrimary)
                    {
                        using (Pen borderPen = new Pen(BorderColor, 1f))
                        {
                            e.Graphics.DrawPath(borderPen, path);
                        }
                    }
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            };
        }

        private static void StyleProgressBarAnimated(ProgressBar pgb)
        {
            if (pgb.Tag == null)
            {
                pgb.Tag = (float)pgb.Value;

                Timer animTimer = new Timer();
                animTimer.Interval = 15;

                animTimer.Tick += (s, e) =>
                {
                    float currentVal = (float)pgb.Tag;
                    float targetVal = pgb.Value;

                    if (Math.Abs(currentVal - targetVal) > 0.1f)
                    {
                        currentVal += (targetVal - currentVal) * 0.2f;
                        pgb.Tag = currentVal;
                        pgb.Invalidate();
                    }
                    else
                    {
                        pgb.Tag = targetVal;
                        pgb.Invalidate();
                    }
                };

                animTimer.Start();
            }

            try
            {
                var setStyleMethod = typeof(Control).GetMethod("SetStyle",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                if (setStyleMethod != null)
                {
                    setStyleMethod.Invoke(pgb, new object[] { ControlStyles.UserPaint, true });
                    setStyleMethod.Invoke(pgb, new object[] { ControlStyles.AllPaintingInWmPaint, true });
                    setStyleMethod.Invoke(pgb, new object[] { ControlStyles.OptimizedDoubleBuffer, true });
                }
            }
            catch { }

            pgb.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = pgb.ClientRectangle;

                using (GraphicsPath bgPath = GetRoundedPath(rect, 4))
                using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(180, 226, 232, 240)))
                {
                    e.Graphics.FillPath(bgBrush, bgPath);
                }

                float displayValue = pgb.Tag is float fVal ? fVal : pgb.Value;

                if (pgb.Maximum > 0 && displayValue > 0)
                {
                    float percent = displayValue / pgb.Maximum;
                    int fillWidth = (int)(rect.Width * percent);

                    if (fillWidth > 3)
                    {
                        Rectangle fillRect = new Rectangle(0, 0, fillWidth, rect.Height);
                        using (GraphicsPath fillPath = GetRoundedPath(fillRect, 4))
                        using (SolidBrush fillBrush = new SolidBrush(PrimaryColor))
                        {
                            e.Graphics.FillPath(fillBrush, fillPath);
                        }
                    }
                }
            };
        }

        public static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            if (rect.Width <= diameter || rect.Height <= diameter)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    
    }
}
