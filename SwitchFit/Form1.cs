namespace SwitchFit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcSurveyPage ucSurveyPage = new UcSurveyPage();
            ucSurveyPage.Show();
            ucSurveyPage.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
