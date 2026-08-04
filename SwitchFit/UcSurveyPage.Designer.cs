namespace SwitchFit
{
    partial class UcSurveyPage
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
            pgbSurveyProgress = new ProgressBar();
            label1 = new Label();
            grpNoise = new GroupBox();
            rdoNoiseNormal = new RadioButton();
            label2 = new Label();
            rdoNoiseSemiSilent = new RadioButton();
            rdoNoiseSilent = new RadioButton();
            grpType = new GroupBox();
            label3 = new Label();
            rdoTypeTactile = new RadioButton();
            rdoTypeLinear = new RadioButton();
            grpPressure = new GroupBox();
            rdoPressureHigh = new RadioButton();
            label4 = new Label();
            rdoPressureMid = new RadioButton();
            rdoPressureLow = new RadioButton();
            btnSubmitSurvey = new Button();
            grpNoise.SuspendLayout();
            grpType.SuspendLayout();
            grpPressure.SuspendLayout();
            SuspendLayout();
            // 
            // pgbSurveyProgress
            // 
            pgbSurveyProgress.Location = new Point(24, 498);
            pgbSurveyProgress.Name = "pgbSurveyProgress";
            pgbSurveyProgress.Size = new Size(576, 23);
            pgbSurveyProgress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(373, 45);
            label1.TabIndex = 0;
            label1.Text = "나에게 맞는 축 진단하기";
            // 
            // grpNoise
            // 
            grpNoise.Controls.Add(rdoNoiseNormal);
            grpNoise.Controls.Add(label2);
            grpNoise.Controls.Add(rdoNoiseSemiSilent);
            grpNoise.Controls.Add(rdoNoiseSilent);
            grpNoise.Location = new Point(24, 78);
            grpNoise.Name = "grpNoise";
            grpNoise.Size = new Size(726, 139);
            grpNoise.TabIndex = 1;
            grpNoise.TabStop = false;
            // 
            // rdoNoiseNormal
            // 
            rdoNoiseNormal.AutoSize = true;
            rdoNoiseNormal.Location = new Point(6, 98);
            rdoNoiseNormal.Name = "rdoNoiseNormal";
            rdoNoiseNormal.Size = new Size(230, 19);
            rdoNoiseNormal.TabIndex = 0;
            rdoNoiseNormal.TabStop = true;
            rdoNoiseNormal.Text = "소음 상관없음 / 시원하고 경쾌한 소리";
            rdoNoiseNormal.UseVisualStyleBackColor = true;
            rdoNoiseNormal.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(225, 21);
            label2.TabIndex = 0;
            label2.Text = "Q1. 사용 장소 및 소음 민감도";
            // 
            // rdoNoiseSemiSilent
            // 
            rdoNoiseSemiSilent.AutoSize = true;
            rdoNoiseSemiSilent.Location = new Point(6, 73);
            rdoNoiseSemiSilent.Name = "rdoNoiseSemiSilent";
            rdoNoiseSemiSilent.Size = new Size(257, 19);
            rdoNoiseSemiSilent.TabIndex = 0;
            rdoNoiseSemiSilent.TabStop = true;
            rdoNoiseSemiSilent.Text = "방, 개인 공간 / 정숙하되 약간의 타격음 OK";
            rdoNoiseSemiSilent.UseVisualStyleBackColor = true;
            rdoNoiseSemiSilent.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rdoNoiseSilent
            // 
            rdoNoiseSilent.AutoSize = true;
            rdoNoiseSilent.Location = new Point(6, 48);
            rdoNoiseSilent.Name = "rdoNoiseSilent";
            rdoNoiseSilent.Size = new Size(193, 19);
            rdoNoiseSilent.TabIndex = 0;
            rdoNoiseSilent.TabStop = true;
            rdoNoiseSilent.Text = "사무실, 도서관 / 극저소음 필수";
            rdoNoiseSilent.UseVisualStyleBackColor = true;
            rdoNoiseSilent.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // grpType
            // 
            grpType.Controls.Add(label3);
            grpType.Controls.Add(rdoTypeTactile);
            grpType.Controls.Add(rdoTypeLinear);
            grpType.Location = new Point(24, 213);
            grpType.Name = "grpType";
            grpType.Size = new Size(726, 117);
            grpType.TabIndex = 1;
            grpType.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(193, 21);
            label3.TabIndex = 0;
            label3.Text = "Q2. 선호하는 키감 (손맛)";
            // 
            // rdoTypeTactile
            // 
            rdoTypeTactile.AutoSize = true;
            rdoTypeTactile.Location = new Point(6, 73);
            rdoTypeTactile.Name = "rdoTypeTactile";
            rdoTypeTactile.Size = new Size(157, 19);
            rdoTypeTactile.TabIndex = 0;
            rdoTypeTactile.TabStop = true;
            rdoTypeTactile.Text = "톡톡 걸리는 적당한 손맛";
            rdoTypeTactile.UseVisualStyleBackColor = true;
            rdoTypeTactile.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rdoTypeLinear
            // 
            rdoTypeLinear.AutoSize = true;
            rdoTypeLinear.Location = new Point(6, 48);
            rdoTypeLinear.Name = "rdoTypeLinear";
            rdoTypeLinear.Size = new Size(185, 19);
            rdoTypeLinear.TabIndex = 0;
            rdoTypeLinear.TabStop = true;
            rdoTypeLinear.Text = "걸림 없이 부드럽게 쑥 들어감";
            rdoTypeLinear.UseVisualStyleBackColor = true;
            rdoTypeLinear.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // grpPressure
            // 
            grpPressure.Controls.Add(rdoPressureHigh);
            grpPressure.Controls.Add(label4);
            grpPressure.Controls.Add(rdoPressureMid);
            grpPressure.Controls.Add(rdoPressureLow);
            grpPressure.Location = new Point(24, 330);
            grpPressure.Name = "grpPressure";
            grpPressure.Size = new Size(726, 142);
            grpPressure.TabIndex = 1;
            grpPressure.TabStop = false;
            // 
            // rdoPressureHigh
            // 
            rdoPressureHigh.AutoSize = true;
            rdoPressureHigh.Location = new Point(6, 98);
            rdoPressureHigh.Name = "rdoPressureHigh";
            rdoPressureHigh.Size = new Size(182, 19);
            rdoPressureHigh.TabIndex = 0;
            rdoPressureHigh.TabStop = true;
            rdoPressureHigh.Text = "묵직하고 쫀득한 키압 (45g~)";
            rdoPressureHigh.UseVisualStyleBackColor = true;
            rdoPressureHigh.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 16);
            label4.Name = "label4";
            label4.Size = new Size(209, 21);
            label4.TabIndex = 0;
            label4.Text = "Q3. 선호하는 키압 (무게감)";
            // 
            // rdoPressureMid
            // 
            rdoPressureMid.AutoSize = true;
            rdoPressureMid.Location = new Point(6, 73);
            rdoPressureMid.Name = "rdoPressureMid";
            rdoPressureMid.Size = new Size(139, 19);
            rdoPressureMid.TabIndex = 0;
            rdoPressureMid.TabStop = true;
            rdoPressureMid.Text = "표준 키압 (40g~44g)";
            rdoPressureMid.UseVisualStyleBackColor = true;
            rdoPressureMid.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rdoPressureLow
            // 
            rdoPressureLow.AutoSize = true;
            rdoPressureLow.Location = new Point(6, 48);
            rdoPressureLow.Name = "rdoPressureLow";
            rdoPressureLow.Size = new Size(130, 19);
            rdoPressureLow.TabIndex = 0;
            rdoPressureLow.TabStop = true;
            rdoPressureLow.Text = "가벼운 키압 (~39g)";
            rdoPressureLow.UseVisualStyleBackColor = true;
            rdoPressureLow.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // btnSubmitSurvey
            // 
            btnSubmitSurvey.Location = new Point(628, 492);
            btnSubmitSurvey.Name = "btnSubmitSurvey";
            btnSubmitSurvey.Size = new Size(122, 38);
            btnSubmitSurvey.TabIndex = 1;
            btnSubmitSurvey.Text = "스위치 찾기";
            btnSubmitSurvey.UseVisualStyleBackColor = true;
            btnSubmitSurvey.Click += btnFindSwit_Click;
            // 
            // UcSurveyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnSubmitSurvey);
            Controls.Add(grpNoise);
            Controls.Add(label1);
            Controls.Add(grpType);
            Controls.Add(grpPressure);
            Controls.Add(pgbSurveyProgress);
            Name = "UcSurveyPage";
            Text = "UcSurveyPage";
            grpNoise.ResumeLayout(false);
            grpNoise.PerformLayout();
            grpType.ResumeLayout(false);
            grpType.PerformLayout();
            grpPressure.ResumeLayout(false);
            grpPressure.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar pgbSurveyProgress;
        private Label label1;
        private GroupBox grpNoise;
        private RadioButton rdoNoiseNormal;
        private Label label2;
        private RadioButton rdoNoiseSemiSilent;
        private RadioButton rdoNoiseSilent;
        private GroupBox grpType;
        private Label label3;
        private RadioButton rdoTypeTactile;
        private RadioButton rdoTypeLinear;
        private GroupBox grpPressure;
        private Button btnSubmitSurvey;
        private RadioButton rdoPressureHigh;
        private Label label4;
        private RadioButton rdoPressureMid;
        private RadioButton rdoPressureLow;
    }
}