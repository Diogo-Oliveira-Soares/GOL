namespace FormGOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StartButton.Text == "Start")
            {
                StartButton.Text = "Pause";
            }
            else
            {
                StartButton.Text = "Start";
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
