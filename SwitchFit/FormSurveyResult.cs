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
    public partial class FormSurveyResult : Form
    {
        private string _switchName;
        private string _switchSpec;
        public FormSurveyResult()
        {
            InitializeComponent();
            UIHelper.ApplyModernTheme(this);
        }

        public FormSurveyResult(string switchName, string switchSpec) : this()
        {
            _switchName = switchName;
            _switchSpec = switchSpec;

            lblSwitchResult.Text = _switchName;
            lblSpecResult.Text = _switchSpec;
        }

        private void btnGoToTest_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            string copyText = $"[당신에게 딱 맞는 스위치 진단 결과]\n- 추천 스위치 : {lblSwitchResult.Text}\n- 스펙 요약 : {lblSpecResult.Text}";

            Clipboard.SetText(copyText);
            MessageBox.Show("진단 결과가 클립보드에 복사되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
