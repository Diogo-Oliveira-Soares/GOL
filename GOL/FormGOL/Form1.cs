namespace FormGOL
{
    public partial class Form1 : Form
    {
        int speed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int speedPause = 0;
            if (StartButton.Text == "Start")
            {
                speed = 1;
                StartButton.Text = "Pause";
            }
            else if (StartButton.Text == "Pause")
            {
                speedPause = speed;
                speed = 0;
                StartButton.Text = "Restart";
            }
            else if (StartButton.Text == "Restart")
            {
                speed = speedPause;
                StartButton.Text = "Pause";
            }

            SpeedTrackBar.Value = speed;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            speed = 0;
            SpeedTrackBar.Value = speed;
            StartButton.Text = "Start";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            speed = SpeedTrackBar.Value;
        }
    }
}
