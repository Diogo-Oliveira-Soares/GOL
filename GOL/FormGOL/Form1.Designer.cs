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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            StartButton = new Button();
            StopButton = new Button();
            ResetButton = new Button();
            SettingsButton = new Button();
            SpeedTrackBar = new TrackBar();
            groupBox1 = new GroupBox();
            GameGrid = new DataGridView();
            a = new DataGridViewTextBoxColumn();
            b = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            d = new DataGridViewTextBoxColumn();
            e = new DataGridViewTextBoxColumn();
            f = new DataGridViewTextBoxColumn();
            g = new DataGridViewTextBoxColumn();
            h = new DataGridViewTextBoxColumn();
            i = new DataGridViewTextBoxColumn();
            j = new DataGridViewTextBoxColumn();
            k = new DataGridViewTextBoxColumn();
            l = new DataGridViewTextBoxColumn();
            m = new DataGridViewTextBoxColumn();
            n = new DataGridViewTextBoxColumn();
            o = new DataGridViewTextBoxColumn();
            p = new DataGridViewTextBoxColumn();
            q = new DataGridViewTextBoxColumn();
            r = new DataGridViewTextBoxColumn();
            s = new DataGridViewTextBoxColumn();
            t = new DataGridViewTextBoxColumn();
            u = new DataGridViewTextBoxColumn();
            v = new DataGridViewTextBoxColumn();
            w = new DataGridViewTextBoxColumn();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            z = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SpeedTrackBar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameGrid).BeginInit();
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
            // GameGrid
            // 
            GameGrid.AllowUserToAddRows = false;
            GameGrid.AllowUserToDeleteRows = false;
            GameGrid.AllowUserToResizeColumns = false;
            GameGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            GameGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            GameGrid.ColumnHeadersHeight = 29;
            GameGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GameGrid.ColumnHeadersVisible = false;
            GameGrid.Columns.AddRange(new DataGridViewColumn[] { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z });
            GameGrid.Location = new Point(296, 12);
            GameGrid.Name = "GameGrid";
            GameGrid.ReadOnly = true;
            GameGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GameGrid.RowHeadersVisible = false;
            GameGrid.RowHeadersWidth = 51;
            GameGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            GameGrid.ScrollBars = ScrollBars.None;
            GameGrid.Size = new Size(780, 755);
            GameGrid.TabIndex = 7;
            GameGrid.CellClick += GameGrid_CellClick;
            // 
            // a
            // 
            a.HeaderText = "a";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.ReadOnly = true;
            a.Width = 30;
            // 
            // b
            // 
            b.HeaderText = "b";
            b.MinimumWidth = 6;
            b.Name = "b";
            b.ReadOnly = true;
            b.Width = 30;
            // 
            // c
            // 
            c.HeaderText = "c";
            c.MinimumWidth = 6;
            c.Name = "c";
            c.ReadOnly = true;
            c.Width = 30;
            // 
            // d
            // 
            d.HeaderText = "d";
            d.MinimumWidth = 6;
            d.Name = "d";
            d.ReadOnly = true;
            d.Width = 30;
            // 
            // e
            // 
            e.HeaderText = "e";
            e.MinimumWidth = 6;
            e.Name = "e";
            e.ReadOnly = true;
            e.Width = 30;
            // 
            // f
            // 
            f.HeaderText = "f";
            f.MinimumWidth = 6;
            f.Name = "f";
            f.ReadOnly = true;
            f.Width = 30;
            // 
            // g
            // 
            g.HeaderText = "g";
            g.MinimumWidth = 6;
            g.Name = "g";
            g.ReadOnly = true;
            g.Width = 30;
            // 
            // h
            // 
            h.HeaderText = "h";
            h.MinimumWidth = 6;
            h.Name = "h";
            h.ReadOnly = true;
            h.Width = 30;
            // 
            // i
            // 
            i.HeaderText = "i";
            i.MinimumWidth = 6;
            i.Name = "i";
            i.ReadOnly = true;
            i.Width = 30;
            // 
            // j
            // 
            j.HeaderText = "j";
            j.MinimumWidth = 6;
            j.Name = "j";
            j.ReadOnly = true;
            j.Width = 30;
            // 
            // k
            // 
            k.HeaderText = "k";
            k.MinimumWidth = 6;
            k.Name = "k";
            k.ReadOnly = true;
            k.Width = 30;
            // 
            // l
            // 
            l.HeaderText = "l";
            l.MinimumWidth = 6;
            l.Name = "l";
            l.ReadOnly = true;
            l.Width = 30;
            // 
            // m
            // 
            m.HeaderText = "m";
            m.MinimumWidth = 6;
            m.Name = "m";
            m.ReadOnly = true;
            m.Width = 30;
            // 
            // n
            // 
            n.HeaderText = "n";
            n.MinimumWidth = 6;
            n.Name = "n";
            n.ReadOnly = true;
            n.Width = 30;
            // 
            // o
            // 
            o.HeaderText = "o";
            o.MinimumWidth = 6;
            o.Name = "o";
            o.ReadOnly = true;
            o.Width = 30;
            // 
            // p
            // 
            p.HeaderText = "p";
            p.MinimumWidth = 6;
            p.Name = "p";
            p.ReadOnly = true;
            p.Width = 30;
            // 
            // q
            // 
            q.HeaderText = "q";
            q.MinimumWidth = 6;
            q.Name = "q";
            q.ReadOnly = true;
            q.Width = 30;
            // 
            // r
            // 
            r.HeaderText = "r";
            r.MinimumWidth = 6;
            r.Name = "r";
            r.ReadOnly = true;
            r.Width = 30;
            // 
            // s
            // 
            s.HeaderText = "s";
            s.MinimumWidth = 6;
            s.Name = "s";
            s.ReadOnly = true;
            s.Width = 30;
            // 
            // t
            // 
            t.HeaderText = "t";
            t.MinimumWidth = 6;
            t.Name = "t";
            t.ReadOnly = true;
            t.Width = 30;
            // 
            // u
            // 
            u.HeaderText = "u";
            u.MinimumWidth = 6;
            u.Name = "u";
            u.ReadOnly = true;
            u.Width = 30;
            // 
            // v
            // 
            v.HeaderText = "v";
            v.MinimumWidth = 6;
            v.Name = "v";
            v.ReadOnly = true;
            v.Width = 30;
            // 
            // w
            // 
            w.HeaderText = "w";
            w.MinimumWidth = 6;
            w.Name = "w";
            w.ReadOnly = true;
            w.Width = 30;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.ReadOnly = true;
            x.Width = 30;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.MinimumWidth = 6;
            y.Name = "y";
            y.ReadOnly = true;
            y.Width = 30;
            // 
            // z
            // 
            z.HeaderText = "z";
            z.MinimumWidth = 6;
            z.Name = "z";
            z.ReadOnly = true;
            z.Width = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 808);
            Controls.Add(GameGrid);
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
            ((System.ComponentModel.ISupportInitialize)GameGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Button ResetButton;
        private Button SettingsButton;
        private TrackBar SpeedTrackBar;
        private GroupBox groupBox1;
        private DataGridView GameGrid;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn b;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn d;
        private DataGridViewTextBoxColumn e;
        private DataGridViewTextBoxColumn f;
        private DataGridViewTextBoxColumn g;
        private DataGridViewTextBoxColumn h;
        private DataGridViewTextBoxColumn i;
        private DataGridViewTextBoxColumn j;
        private DataGridViewTextBoxColumn k;
        private DataGridViewTextBoxColumn l;
        private DataGridViewTextBoxColumn m;
        private DataGridViewTextBoxColumn n;
        private DataGridViewTextBoxColumn o;
        private DataGridViewTextBoxColumn p;
        private DataGridViewTextBoxColumn q;
        private DataGridViewTextBoxColumn r;
        private DataGridViewTextBoxColumn s;
        private DataGridViewTextBoxColumn t;
        private DataGridViewTextBoxColumn u;
        private DataGridViewTextBoxColumn v;
        private DataGridViewTextBoxColumn w;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private DataGridViewTextBoxColumn z;
    }
}
