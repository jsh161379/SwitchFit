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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            groupBox1 = new GroupBox();
            noiseRadio3 = new RadioButton();
            label2 = new Label();
            noiseRadio2 = new RadioButton();
            noiseRadio1 = new RadioButton();
            groupBox2 = new GroupBox();
            label3 = new Label();
            feelRadio2 = new RadioButton();
            feelRadio1 = new RadioButton();
            groupBox3 = new GroupBox();
            btnFindSwit = new Button();
            pressureRadio3 = new RadioButton();
            label4 = new Label();
            pressureRadio2 = new RadioButton();
            pressureRadio1 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 486);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(576, 23);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 말랑말랑 Bold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(323, 41);
            label1.TabIndex = 0;
            label1.Text = "나에게 맞는 축 진단하기";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(noiseRadio3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(noiseRadio2);
            groupBox1.Controls.Add(noiseRadio1);
            groupBox1.Location = new Point(24, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 129);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // noiseRadio3
            // 
            noiseRadio3.AutoSize = true;
            noiseRadio3.Location = new Point(6, 98);
            noiseRadio3.Name = "noiseRadio3";
            noiseRadio3.Size = new Size(230, 19);
            noiseRadio3.TabIndex = 0;
            noiseRadio3.TabStop = true;
            noiseRadio3.Text = "소음 상관없음 / 시원하고 경쾌한 소리";
            noiseRadio3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(225, 21);
            label2.TabIndex = 0;
            label2.Text = "Q1. 사용 장소 및 소음 민감도";
            // 
            // noiseRadio2
            // 
            noiseRadio2.AutoSize = true;
            noiseRadio2.Location = new Point(6, 73);
            noiseRadio2.Name = "noiseRadio2";
            noiseRadio2.Size = new Size(257, 19);
            noiseRadio2.TabIndex = 0;
            noiseRadio2.TabStop = true;
            noiseRadio2.Text = "방, 개인 공간 / 정숙하되 약간의 타격음 OK";
            noiseRadio2.UseVisualStyleBackColor = true;
            // 
            // noiseRadio1
            // 
            noiseRadio1.AutoSize = true;
            noiseRadio1.Location = new Point(6, 48);
            noiseRadio1.Name = "noiseRadio1";
            noiseRadio1.Size = new Size(193, 19);
            noiseRadio1.TabIndex = 0;
            noiseRadio1.TabStop = true;
            noiseRadio1.Text = "사무실, 도서관 / 극저소음 필수";
            noiseRadio1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(feelRadio2);
            groupBox2.Controls.Add(feelRadio1);
            groupBox2.Location = new Point(24, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(726, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(191, 21);
            label3.TabIndex = 0;
            label3.Text = "Q2. 선호하는 키감 (손맛)";
            // 
            // feelRadio2
            // 
            feelRadio2.AutoSize = true;
            feelRadio2.Location = new Point(6, 73);
            feelRadio2.Name = "feelRadio2";
            feelRadio2.Size = new Size(157, 19);
            feelRadio2.TabIndex = 0;
            feelRadio2.TabStop = true;
            feelRadio2.Text = "톡톡 걸리는 적당한 손맛";
            feelRadio2.UseVisualStyleBackColor = true;
            // 
            // feelRadio1
            // 
            feelRadio1.AutoSize = true;
            feelRadio1.Location = new Point(6, 48);
            feelRadio1.Name = "feelRadio1";
            feelRadio1.Size = new Size(185, 19);
            feelRadio1.TabIndex = 0;
            feelRadio1.TabStop = true;
            feelRadio1.Text = "걸림 없이 부드럽게 쑥 들어감";
            feelRadio1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pressureRadio3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(pressureRadio2);
            groupBox3.Controls.Add(pressureRadio1);
            groupBox3.Location = new Point(24, 332);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(726, 129);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btnFindSwit
            // 
            btnFindSwit.Location = new Point(628, 480);
            btnFindSwit.Name = "btnFindSwit";
            btnFindSwit.Size = new Size(122, 38);
            btnFindSwit.TabIndex = 1;
            btnFindSwit.Text = "스위치 찾기";
            btnFindSwit.UseVisualStyleBackColor = true;
            btnFindSwit.Click += btnFindSwit_Click;
            // 
            // pressureRadio3
            // 
            pressureRadio3.AutoSize = true;
            pressureRadio3.Location = new Point(6, 98);
            pressureRadio3.Name = "pressureRadio3";
            pressureRadio3.Size = new Size(182, 19);
            pressureRadio3.TabIndex = 0;
            pressureRadio3.TabStop = true;
            pressureRadio3.Text = "묵직하고 쫀득한 키압 (45g~)";
            pressureRadio3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 16);
            label4.Name = "label4";
            label4.Size = new Size(207, 21);
            label4.TabIndex = 0;
            label4.Text = "Q3. 선호하는 키압 (무게감)";
            // 
            // pressureRadio2
            // 
            pressureRadio2.AutoSize = true;
            pressureRadio2.Location = new Point(6, 73);
            pressureRadio2.Name = "pressureRadio2";
            pressureRadio2.Size = new Size(139, 19);
            pressureRadio2.TabIndex = 0;
            pressureRadio2.TabStop = true;
            pressureRadio2.Text = "표준 키압 (40g~44g)";
            pressureRadio2.UseVisualStyleBackColor = true;
            // 
            // pressureRadio1
            // 
            pressureRadio1.AutoSize = true;
            pressureRadio1.Location = new Point(6, 48);
            pressureRadio1.Name = "pressureRadio1";
            pressureRadio1.Size = new Size(130, 19);
            pressureRadio1.TabIndex = 0;
            pressureRadio1.TabStop = true;
            pressureRadio1.Text = "가벼운 키압 (~39g)";
            pressureRadio1.UseVisualStyleBackColor = true;
            // 
            // UcSurveyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnFindSwit);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(progressBar1);
            Name = "UcSurveyPage";
            Text = "UcSurveyPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar progressBar1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton noiseRadio3;
        private Label label2;
        private RadioButton noiseRadio2;
        private RadioButton noiseRadio1;
        private GroupBox groupBox2;
        private Label label3;
        private RadioButton feelRadio2;
        private RadioButton feelRadio1;
        private GroupBox groupBox3;
        private Button btnFindSwit;
        private RadioButton pressureRadio3;
        private Label label4;
        private RadioButton pressureRadio2;
        private RadioButton pressureRadio1;
    }
}