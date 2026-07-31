namespace SwitchFit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 114);
            label1.Name = "label1";
            label1.Size = new Size(350, 85);
            label1.TabIndex = 0;
            label1.Text = "SwitchFit!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("한컴 말랑말랑 Regular", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(288, 233);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 1;
            label2.Text = "나에게 맞는 스위치 찾기";
            // 
            // button1
            // 
            button1.Location = new Point(316, 292);
            button1.Name = "button1";
            button1.Size = new Size(146, 57);
            button1.TabIndex = 2;
            button1.Text = "시작하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 383);
            button2.Name = "button2";
            button2.Size = new Size(146, 57);
            button2.TabIndex = 2;
            button2.Text = "나가기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
