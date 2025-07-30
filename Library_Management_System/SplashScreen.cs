using System;
using System.Windows.Forms;
namespace Library_Management_System
{
    public partial class SplashScreen : Form
    {
        int progressValue = 0;
        public SplashScreen()
        {
            InitializeComponent();

        }
        public void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 1;
            progressBar.Value = progressValue;
            percentage.Text= progressValue.ToString()+"%";

            if(progressValue>=100)
            {
                timer1.Stop();
                this.Hide();
                LoginForm log = new LoginForm();
                log.Show();
            }
        }
    }
}
