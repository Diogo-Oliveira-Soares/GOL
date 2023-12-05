namespace FormGOL
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
            StartButton = new Button();
            StopButton = new Button();
            ResetButton = new Button();
            SettingsButton = new Button();
            SpeedTrackBar = new TrackBar();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)SpeedTrackBar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(12, 47);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(94, 29);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(12, 82);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Location = new Point(12, 117);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(94, 29);
            SettingsButton.TabIndex = 4;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // SpeedTrackBar
            // 
            SpeedTrackBar.Location = new Point(6, 17);
            SpeedTrackBar.Name = "SpeedTrackBar";
            SpeedTrackBar.Size = new Size(244, 56);
            SpeedTrackBar.TabIndex = 5;
            SpeedTrackBar.Scroll += SpeedTrackBar_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SpeedTrackBar);
            groupBox1.Location = new Point(12, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 88);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Speed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 529);
            Controls.Add(groupBox1);
            Controls.Add(SettingsButton);
            Controls.Add(ResetButton);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "Game Of Life";
            ((System.ComponentModel.ISupportInitialize)SpeedTrackBar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Button ResetButton;
        private Button SettingsButton;
        private TrackBar SpeedTrackBar;
        private GroupBox groupBox1;
    }
}
