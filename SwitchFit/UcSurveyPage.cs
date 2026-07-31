using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchFit
{
    public partial class UcSurveyPage : Form
    {
        public UcSurveyPage()
        {
            InitializeComponent();
        }
        // Q1. 소음 선택 값 (0: 저소음, 1: 반저소음, 2: 일반)
        private int GetSelectedNoiseIndex()
        {
            if (rdoNoiseSilent.Checked) return 0;
            if (rdoNoiseSemiSilent.Checked) return 1;
            if (rdoNoiseNormal.Checked) return 2;
            return -1; // 미선택 시
        }

        // Q2. 키감 선택 값 (0: 리니어, 1: 택타일)
        private int GetSelectedTypeIndex()
        {
            if (rdoTypeLinear.Checked) return 0;
            if (rdoTypeTactile.Checked) return 1;
            return -1; // 미선택 시
        }

        // Q3. 키압 선택 값 (0: 저, 1: 중, 2: 고)
        private int GetSelectedPressureIndex()
        {
            if (rdoPressureLow.Checked) return 0;
            if (rdoPressureMid.Checked) return 1;
            if (rdoPressureMid.Checked) return 2;
            return -1; // 미선택 시
        }
        private void UpdateProgressBar()
        {
            int answeredCount = 0;

            // Q1 선택 여부
            if (rdoNoiseSilent.Checked || rdoNoiseSemiSilent.Checked || rdoNoiseNormal.Checked)
                answeredCount++;

            // Q2 선택 여부
            if (rdoTypeLinear.Checked || rdoTypeTactile.Checked)
                answeredCount++;

            // Q3 선택 여부
            if (rdoPressureLow.Checked || rdoPressureMid.Checked || rdoPressureHigh.Checked)
                answeredCount++;

            // 3개 질문 중 답한 개수에 따라 프로그래스바 퍼센트 계산 (0%, 33%, 66%, 100%)
            int percent = (int)((answeredCount / 3.0) * 100);

            pgbSurveyProgress.Value = percent; // 프로그래스바 값 변경
        }

        // 모든 RadioButton의 CheckedChanged 이벤트에 UpdateProgressBar() 연결
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void btnFindSwit_Click(object sender, EventArgs e)
        {
            int noiseIdx = GetSelectedNoiseIndex();
            int typeIdx = GetSelectedTypeIndex();
            int pressureIdx = GetSelectedPressureIndex();

            if (noiseIdx == -1 || typeIdx == -1 || pressureIdx == -1)
            {
                MessageBox.Show("모든 질문에 답해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. 조건에 맞는 추천 스위치 및 스펙 결정 (예시 데이터)
            string recommendedSwitch = "체리 MX Board 3.0S (저소음 적축)";
            string recommendedSpec = "저소음 / 리니어 / 45g";

            // 3. 결과 폼 생성 및 팝업 띄우기 (ShowDialog)
            using (FormSurveyResult resultForm = new FormSurveyResult(recommendedSwitch, recommendedSpec))
            {
                if (resultForm.ShowDialog() == DialogResult.OK)
                {
                    // '타건하러 가기' 버튼을 눌렀을 때 실행할 로직
                    // 예: Main Form의 타건 탭으로 이동 등
                }
            }
        }
    }
}
