namespace SwitchFit
{
    partial class FormSurveyResult
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
            label2 = new Label();
            label3 = new Label();
            lblSwitchResult = new Label();
            lblSpecResult = new Label();
            btnCopyResult = new Button();
            btnGoToTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(334, 31);
            label1.TabIndex = 0;
            label1.Text = "당신에게 딱 맞는 스위치 진단 결과";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 111);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "[ 추천 스위치 ] : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 1;
            label3.Text = "[ 스펙 요약 ] : ";
            // 
            // lblSwitchResult
            // 
            lblSwitchResult.AutoSize = true;
            lblSwitchResult.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSwitchResult.Location = new Point(163, 111);
            lblSwitchResult.Name = "lblSwitchResult";
            lblSwitchResult.Size = new Size(89, 20);
            lblSwitchResult.TabIndex = 1;
            lblSwitchResult.Text = "스위치 결과";
            // 
            // lblSpecResult
            // 
            lblSpecResult.AutoSize = true;
            lblSpecResult.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpecResult.Location = new Point(163, 149);
            lblSpecResult.Name = "lblSpecResult";
            lblSpecResult.Size = new Size(109, 20);
            lblSpecResult.TabIndex = 1;
            lblSpecResult.Text = "스펙 요약 결과";
            // 
            // btnCopyResult
            // 
            btnCopyResult.Location = new Point(117, 203);
            btnCopyResult.Name = "btnCopyResult";
            btnCopyResult.Size = new Size(111, 35);
            btnCopyResult.TabIndex = 2;
            btnCopyResult.Text = "결과 복사";
            btnCopyResult.UseVisualStyleBackColor = true;
            btnCopyResult.Click += btnCopyResult_Click;
            // 
            // btnGoToTest
            // 
            btnGoToTest.Location = new Point(262, 203);
            btnGoToTest.Name = "btnGoToTest";
            btnGoToTest.Size = new Size(111, 35);
            btnGoToTest.TabIndex = 2;
            btnGoToTest.Text = "타건하러 가기";
            btnGoToTest.UseVisualStyleBackColor = true;
            btnGoToTest.Click += btnGoToTest_Click;
            // 
            // FormSurveyResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 267);
            Controls.Add(btnGoToTest);
            Controls.Add(btnCopyResult);
            Controls.Add(label3);
            Controls.Add(lblSpecResult);
            Controls.Add(lblSwitchResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSurveyResult";
            Text = "FormSurveyResult";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSwitchResult;
        private Label lblSpecResult;
        private Button btnCopyResult;
        private Button btnGoToTest;
    }
}