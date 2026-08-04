namespace SwitchFit
{
    partial class UcSwitchListPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            lstSwitches = new ListBox();
            btnFilterRecommended = new Button();
            label4 = new Label();
            cboFilterPressure = new ComboBox();
            label3 = new Label();
            cboFilterType = new ComboBox();
            label2 = new Label();
            cboFilterNoise = new ComboBox();
            panel2 = new Panel();
            btnSearchCoupang = new Button();
            btnSearchNaver = new Button();
            txtTypingZone = new TextBox();
            pgbNoiseGraph = new ProgressBar();
            pgbPressureGraph = new ProgressBar();
            lblRecommendSwitchName = new Label();
            lblCurrentSwitchName = new Label();
            lblNoiseValue = new Label();
            label8 = new Label();
            lblPressureValue = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(381, 45);
            label1.TabIndex = 1;
            label1.Text = "스위치 도감, 타건 체험존";
            // 
            // panel1
            // 
            panel1.Controls.Add(lstSwitches);
            panel1.Controls.Add(btnFilterRecommended);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboFilterPressure);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboFilterType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboFilterNoise);
            panel1.Location = new Point(24, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 454);
            panel1.TabIndex = 2;
            // 
            // lstSwitches
            // 
            lstSwitches.FormattingEnabled = true;
            lstSwitches.ItemHeight = 15;
            lstSwitches.Location = new Point(26, 112);
            lstSwitches.Name = "lstSwitches";
            lstSwitches.Size = new Size(313, 334);
            lstSwitches.TabIndex = 4;
            lstSwitches.SelectedIndexChanged += lstSwitches_SelectedIndexChanged;
            // 
            // btnFilterRecommended
            // 
            btnFilterRecommended.Location = new Point(252, 14);
            btnFilterRecommended.Name = "btnFilterRecommended";
            btnFilterRecommended.Size = new Size(87, 85);
            btnFilterRecommended.TabIndex = 3;
            btnFilterRecommended.Text = "보기";
            btnFilterRecommended.UseVisualStyleBackColor = true;
            btnFilterRecommended.Click += btnFilterRecommended_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 79);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 1;
            label4.Text = "키압";
            // 
            // cboFilterPressure
            // 
            cboFilterPressure.FormattingEnabled = true;
            cboFilterPressure.Items.AddRange(new object[] { "전체", "가벼움 (~39g)", "표준 (40g~44g)", "묵직함 (45g~)" });
            cboFilterPressure.Location = new Point(83, 76);
            cboFilterPressure.Name = "cboFilterPressure";
            cboFilterPressure.Size = new Size(121, 23);
            cboFilterPressure.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 46);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "키감";
            // 
            // cboFilterType
            // 
            cboFilterType.FormattingEnabled = true;
            cboFilterType.Items.AddRange(new object[] { "전체", "리니어", "택타일" });
            cboFilterType.Location = new Point(83, 43);
            cboFilterType.Name = "cboFilterType";
            cboFilterType.Size = new Size(121, 23);
            cboFilterType.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 17);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "소음";
            // 
            // cboFilterNoise
            // 
            cboFilterNoise.FormattingEnabled = true;
            cboFilterNoise.Items.AddRange(new object[] { "전체", "저소음", "반저소음", "일반" });
            cboFilterNoise.Location = new Point(83, 14);
            cboFilterNoise.Name = "cboFilterNoise";
            cboFilterNoise.Size = new Size(121, 23);
            cboFilterNoise.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearchCoupang);
            panel2.Controls.Add(btnSearchNaver);
            panel2.Controls.Add(txtTypingZone);
            panel2.Controls.Add(pgbNoiseGraph);
            panel2.Controls.Add(pgbPressureGraph);
            panel2.Controls.Add(lblRecommendSwitchName);
            panel2.Controls.Add(lblCurrentSwitchName);
            panel2.Controls.Add(lblNoiseValue);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblPressureValue);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(394, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 454);
            panel2.TabIndex = 2;
            // 
            // btnSearchCoupang
            // 
            btnSearchCoupang.Location = new Point(86, 409);
            btnSearchCoupang.Name = "btnSearchCoupang";
            btnSearchCoupang.Size = new Size(131, 37);
            btnSearchCoupang.TabIndex = 3;
            btnSearchCoupang.Text = "쿠팡 최저가 검색";
            btnSearchCoupang.UseVisualStyleBackColor = true;
            btnSearchCoupang.Click += btnSearchCoupang_Click;
            // 
            // btnSearchNaver
            // 
            btnSearchNaver.Location = new Point(223, 409);
            btnSearchNaver.Name = "btnSearchNaver";
            btnSearchNaver.Size = new Size(131, 37);
            btnSearchNaver.TabIndex = 3;
            btnSearchNaver.Text = "네이버 검색";
            btnSearchNaver.UseVisualStyleBackColor = true;
            btnSearchNaver.Click += btnSearchNaver_Click;
            // 
            // txtTypingZone
            // 
            txtTypingZone.Location = new Point(24, 62);
            txtTypingZone.Multiline = true;
            txtTypingZone.Name = "txtTypingZone";
            txtTypingZone.Size = new Size(323, 262);
            txtTypingZone.TabIndex = 2;
            txtTypingZone.KeyDown += txtTypingZone_KeyDown;
            // 
            // pgbNoiseGraph
            // 
            pgbNoiseGraph.Location = new Point(69, 370);
            pgbNoiseGraph.Name = "pgbNoiseGraph";
            pgbNoiseGraph.Size = new Size(134, 23);
            pgbNoiseGraph.TabIndex = 1;
            // 
            // pgbPressureGraph
            // 
            pgbPressureGraph.Location = new Point(69, 339);
            pgbPressureGraph.Name = "pgbPressureGraph";
            pgbPressureGraph.Size = new Size(134, 23);
            pgbPressureGraph.TabIndex = 1;
            // 
            // lblRecommendSwitchName
            // 
            lblRecommendSwitchName.AutoSize = true;
            lblRecommendSwitchName.Location = new Point(120, 15);
            lblRecommendSwitchName.Name = "lblRecommendSwitchName";
            lblRecommendSwitchName.Size = new Size(83, 15);
            lblRecommendSwitchName.TabIndex = 0;
            lblRecommendSwitchName.Text = "선택된 스위치";
            // 
            // lblCurrentSwitchName
            // 
            lblCurrentSwitchName.AutoSize = true;
            lblCurrentSwitchName.Location = new Point(120, 37);
            lblCurrentSwitchName.Name = "lblCurrentSwitchName";
            lblCurrentSwitchName.Size = new Size(83, 15);
            lblCurrentSwitchName.TabIndex = 0;
            lblCurrentSwitchName.Text = "선택된 스위치";
            // 
            // lblNoiseValue
            // 
            lblNoiseValue.AutoSize = true;
            lblNoiseValue.Location = new Point(209, 373);
            lblNoiseValue.Name = "lblNoiseValue";
            lblNoiseValue.Size = new Size(59, 15);
            lblNoiseValue.TabIndex = 0;
            lblNoiseValue.Text = "소음 종류";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 373);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 0;
            label8.Text = "소음: ";
            // 
            // lblPressureValue
            // 
            lblPressureValue.AutoSize = true;
            lblPressureValue.Location = new Point(209, 342);
            lblPressureValue.Name = "lblPressureValue";
            lblPressureValue.Size = new Size(28, 15);
            lblPressureValue.TabIndex = 0;
            lblPressureValue.Text = "40g";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 342);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "키압: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 15);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 0;
            label6.Text = "추천 스위치: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 37);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 0;
            label5.Text = "현재 스위치: ";
            // 
            // UcSwitchListPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UcSwitchListPage";
            Text = "UcSwitchListPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private ComboBox cboFilterPressure;
        private Label label3;
        private ComboBox cboFilterType;
        private Label label2;
        private ComboBox cboFilterNoise;
        private Panel panel2;
        private ListBox lstSwitches;
        private Button btnFilterRecommended;
        private Label lblCurrentSwitchName;
        private Label label7;
        private Label label5;
        private TextBox txtTypingZone;
        private ProgressBar pgbNoiseGraph;
        private ProgressBar pgbPressureGraph;
        private Label lblNoiseValue;
        private Label label8;
        private Label lblPressureValue;
        private Button btnSearchNaver;
        private Button btnSearchCoupang;
        private Label lblRecommendSwitchName;
        private Label label6;
    }
}