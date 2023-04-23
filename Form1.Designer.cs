namespace MP3_Player_MaxVolume
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.like = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.song_cover = new System.Windows.Forms.PictureBox();
            this.timing_slider = new System.Windows.Forms.TrackBar();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.unmute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.liked_list = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Duration = new System.Windows.Forms.ColumnHeader();
            this.Filename = new System.Windows.Forms.ColumnHeader();
            this.playlist = new System.Windows.Forms.ListView();
            this.Title_p = new System.Windows.Forms.ColumnHeader();
            this.Duration_p = new System.Windows.Forms.ColumnHeader();
            this.Filename_p = new System.Windows.Forms.ColumnHeader();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.dislike = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.song_cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timing_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Location = new System.Drawing.Point(791, 855);
            this.play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(214, 115);
            this.play.TabIndex = 0;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Location = new System.Drawing.Point(493, 855);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(100, 115);
            this.stop.TabIndex = 1;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // like
            // 
            this.like.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.like.BackColor = System.Drawing.SystemColors.Control;
            this.like.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("like.BackgroundImage")));
            this.like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.like.FlatAppearance.BorderSize = 0;
            this.like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.like.Location = new System.Drawing.Point(1167, 848);
            this.like.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(91, 115);
            this.like.TabIndex = 2;
            this.like.UseVisualStyleBackColor = false;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // prev
            // 
            this.prev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prev.BackgroundImage")));
            this.prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prev.FlatAppearance.BorderSize = 0;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Image = ((System.Drawing.Image)(resources.GetObject("prev.Image")));
            this.prev.Location = new System.Drawing.Point(687, 842);
            this.prev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(129, 138);
            this.prev.TabIndex = 3;
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Location = new System.Drawing.Point(997, 848);
            this.next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(110, 125);
            this.next.TabIndex = 4;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // song_cover
            // 
            this.song_cover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.song_cover.BackColor = System.Drawing.SystemColors.Control;
            this.song_cover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("song_cover.BackgroundImage")));
            this.song_cover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.song_cover.InitialImage = null;
            this.song_cover.Location = new System.Drawing.Point(264, 20);
            this.song_cover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.song_cover.Name = "song_cover";
            this.song_cover.Size = new System.Drawing.Size(1253, 655);
            this.song_cover.TabIndex = 6;
            this.song_cover.TabStop = false;
            // 
            // timing_slider
            // 
            this.timing_slider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timing_slider.AutoSize = false;
            this.timing_slider.Location = new System.Drawing.Point(264, 752);
            this.timing_slider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timing_slider.Maximum = 1;
            this.timing_slider.Name = "timing_slider";
            this.timing_slider.Size = new System.Drawing.Size(1253, 80);
            this.timing_slider.TabIndex = 7;
            this.timing_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.timing_slider.Scroll += new System.EventHandler(this.timing_slider_Scroll);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(36, 17);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(116, 107);
            this.add.TabIndex = 8;
            this.add.UseMnemonic = false;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 798);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Избранное";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1600, 798);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Плейлист";
            // 
            // pause
            // 
            this.pause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause.BackgroundImage")));
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pause.FlatAppearance.BorderSize = 0;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Location = new System.Drawing.Point(791, 855);
            this.pause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(214, 115);
            this.pause.TabIndex = 0;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Visible = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // unmute
            // 
            this.unmute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unmute.BackColor = System.Drawing.Color.Transparent;
            this.unmute.FlatAppearance.BorderSize = 0;
            this.unmute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unmute.Image = ((System.Drawing.Image)(resources.GetObject("unmute.Image")));
            this.unmute.Location = new System.Drawing.Point(1411, 920);
            this.unmute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(87, 78);
            this.unmute.TabIndex = 14;
            this.unmute.UseVisualStyleBackColor = false;
            this.unmute.Click += new System.EventHandler(this.unmute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(277, 700);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сейчас играет:";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(1519, 935);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(261, 80);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // liked_list
            // 
            this.liked_list.BackColor = System.Drawing.SystemColors.Control;
            this.liked_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liked_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Duration,
            this.Filename});
            this.liked_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.liked_list.Location = new System.Drawing.Point(4, 137);
            this.liked_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.liked_list.Name = "liked_list";
            this.liked_list.Size = new System.Drawing.Size(251, 657);
            this.liked_list.TabIndex = 18;
            this.liked_list.UseCompatibleStateImageBehavior = false;
            this.liked_list.View = System.Windows.Forms.View.Details;
            this.liked_list.Click += new System.EventHandler(this.liked_list_Click);
            // 
            // Title
            // 
            this.Title.Text = "Название";
            this.Title.Width = 110;
            // 
            // Duration
            // 
            this.Duration.Text = "Длительность";
            // 
            // Filename
            // 
            this.Filename.Text = "";
            this.Filename.Width = 0;
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.SystemColors.Control;
            this.playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title_p,
            this.Duration_p,
            this.Filename_p});
            this.playlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playlist.Location = new System.Drawing.Point(1529, 137);
            this.playlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(251, 657);
            this.playlist.TabIndex = 19;
            this.playlist.UseCompatibleStateImageBehavior = false;
            this.playlist.View = System.Windows.Forms.View.Details;
            this.playlist.Click += new System.EventHandler(this.playlist_Click);
            // 
            // Title_p
            // 
            this.Title_p.Text = "Название";
            this.Title_p.Width = 100;
            // 
            // Duration_p
            // 
            this.Duration_p.Text = "Длительность";
            // 
            // Filename_p
            // 
            this.Filename_p.Text = "Filename";
            this.Filename_p.Width = 0;
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.Transparent;
            this.minimize.Location = new System.Drawing.Point(1600, 20);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(79, 23);
            this.minimize.TabIndex = 20;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(1713, 7);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(53, 52);
            this.close.TabIndex = 21;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dislike
            // 
            this.dislike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dislike.BackColor = System.Drawing.SystemColors.Control;
            this.dislike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dislike.BackgroundImage")));
            this.dislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dislike.FlatAppearance.BorderSize = 0;
            this.dislike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dislike.Location = new System.Drawing.Point(1286, 853);
            this.dislike.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dislike.Name = "dislike";
            this.dislike.Size = new System.Drawing.Size(91, 115);
            this.dislike.TabIndex = 22;
            this.dislike.UseVisualStyleBackColor = false;
            this.dislike.Click += new System.EventHandler(this.dislike_Click);
            // 
            // mute
            // 
            this.mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mute.FlatAppearance.BorderSize = 0;
            this.mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mute.ForeColor = System.Drawing.Color.Transparent;
            this.mute.Image = ((System.Drawing.Image)(resources.GetObject("mute.Image")));
            this.mute.Location = new System.Drawing.Point(1411, 920);
            this.mute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(87, 78);
            this.mute.TabIndex = 12;
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(256, 837);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1463, 837);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = " ";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1797, 1013);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timing_slider);
            this.Controls.Add(this.dislike);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.liked_list);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.song_cover);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.like);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.unmute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaxVolume Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.song_cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timing_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button play;
        private Button stop;
        private Button like;
        private Button prev;
        private Button next;
        private PictureBox song_cover;
        private TrackBar timing_slider;
        private Button add;
        private Label label1;
        private Label label2;
        private Button pause;
        private Button unmute;
        private Label label3;
        private TrackBar trackBar1;
        private ListView liked_list;
        private ListView playlist;
        private Button minimize;
        private Button close;
        private Button dislike;
        private Button mute;
        private ColumnHeader Title;
        private ColumnHeader Duration;
        private ColumnHeader Filename;
        private ColumnHeader Title_p;
        private ColumnHeader Duration_p;
        private ColumnHeader Filename_p;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label label5;
    }
}