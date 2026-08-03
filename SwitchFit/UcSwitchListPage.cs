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
    public partial class UcSwitchListPage : Form
    {
        private List<SwitchModel> _allSwitches;
        private SwitchModel _selectedSwitch;

        public UcSwitchListPage()
        {
            InitializeComponent();
        }

        private void UcSwitchListPage_Load(object sender, EventArgs e)
        {
            InitComboBoxes();
            LoadSwitchData();
        }

        private void InitComboBoxes()
        {
            cboFilterNoise.Items.AddRange(new string[] { "전체", "저소음", "반저소음", "일반" });
            cboFilterType.Items.AddRange(new string[] { "전체", "리니어", "택타일" });
            cboFilterPressure.Items.AddRange(new string[] { "전체", "가벼움 (~39g)", "표준 (40g~44g)", "묵직함 (45g~)" });

            cboFilterNoise.SelectedIndex = 0;
            cboFilterType.SelectedIndex = 0;
            cboFilterPressure.SelectedIndex = 0;
        }

        private void LoadSwitchData()
        {
            _allSwitches = SwitchRepository.GetAllSwitches();
            DisplaySwitches(_allSwitches);
        }

        private void DisplaySwitches(List<SwitchModel> list)
        {
            lstSwitches.DataSource = null;
            lstSwitches.DisplayMember = "Name"; // 화면엔 스위치 이름(Name)을 보여줌
            lstSwitches.DataSource = list;

            if (list.Count > 0)
            {
                lstSwitches.SelectedIndex = 0; // 첫 번째 항목 자동 선택
            }
            else
            {
                // 조건에 맞는 스위치가 없을 때 UI 초기화
                lblCurrentSwitchName.Text = "선택된 스위치 없음";
                lblPressureValue.Text = "0g";
                lblNoiseValue.Text = "-";
                pgbPressureGraph.Value = 0;
                pgbNoiseGraph.Value = 0;
            }
        }

        private void btnFilterRecommended_Click(object sender, EventArgs e)
        {
            string selectedNoise = cboFilterNoise.SelectedItem?.ToString();
            string selectedType = cboFilterType.SelectedItem?.ToString();
            int selectedPressureIdx = cboFilterPressure.SelectedIndex;

            List<SwitchModel> filteredList = new List<SwitchModel>();

            foreach (SwitchModel sw in _allSwitches)
            {
                // 소음 조건 확인
                bool noiseOk = (selectedNoise == "전체") || (sw.CategoryKr == selectedNoise);

                // 키감 조건 확인
                bool typeOk = (selectedType == "전체") || (sw.TypeKr == selectedType);

                // 키압 조건 확인 (0:전체, 1:가벼움, 2:표준, 3:묵직함)
                bool pressureOk = true;
                if (selectedPressureIdx == 1) pressureOk = sw.Pressure <= 39;
                else if (selectedPressureIdx == 2) pressureOk = sw.Pressure >= 40 && sw.Pressure <= 44;
                else if (selectedPressureIdx == 3) pressureOk = sw.Pressure >= 45;

                // 3가지 조건이 모두 만족할 때만 목록에 추가
                if (noiseOk && typeOk && pressureOk)
                {
                    filteredList.Add(sw);
                }
            }

            DisplaySwitches(filteredList);
        }

        private void lstSwitches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSwitch = lstSwitches.SelectedItem as SwitchModel;

            if (_selectedSwitch == null) return;

            // 우측 화면 라벨 정보 변경
            lblCurrentSwitchName.Text = _selectedSwitch.Name;
            lblPressureValue.Text = $"{_selectedSwitch.Pressure}g";
            lblNoiseValue.Text = _selectedSwitch.CategoryKr;

            // 키압 프로그래스바 수치 적용 (최대 60g 기준)
            int pressureVal = Math.Min(60, Math.Max(0, _selectedSwitch.Pressure));
            pgbPressureGraph.Value = pressureVal;

            // 소음 프로그래스바 수치 적용 (1:저소음, 2:반저소음, 3:일반)
            int noiseVal = 3;
            if (_selectedSwitch.Category == "Silent") noiseVal = 1;
            else if (_selectedSwitch.Category == "SemiSilent") noiseVal = 2;

            pgbNoiseGraph.Value = noiseVal;

            // 🔊 타건 사운드 메모리에 준비(Pre-load)
            SwitchAudioPlayer.LoadSound(_selectedSwitch.SoundFilePath);
        }

        // ⌨️ 6. 우측 큰 텍스트박스(txtTypingZone)에서 키보드를 누를 때 sound 재생
        private void txtTypingZone_KeyDown(object sender, KeyEventArgs e)
        {
            SwitchAudioPlayer.PlayCurrentSound();
        }
    }
}

