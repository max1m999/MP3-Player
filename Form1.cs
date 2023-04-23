using WMPLib;
using TagLib;
namespace MP3_Player_MaxVolume
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer MaxVolume = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
        private void PlaySong()
        {
            if (playlist.SelectedIndices.Count == 0 && liked_list.SelectedIndices.Count == 0)
            {
                playlist.Items[0].Selected = true;
                MaxVolume.URL = playlist.SelectedItems[0].SubItems[2].Text;
                MaxVolume.controls.play();
                timer1.Start();
                label3.Text = "Сейчас играет: " + playlist.SelectedItems[0].SubItems[0].Text;
                var file = TagLib.File.Create(playlist.SelectedItems[0].SubItems[2].Text);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    song_cover.BackgroundImage = Image.FromStream(new MemoryStream(bin));
                }
                else song_cover.BackgroundImage = Image.FromFile(@"back1.png");
            }
            else if (playlist.SelectedIndices.Count != 0)
            {
                string curr = playlist.Items[playlist.SelectedIndices[0]].SubItems[2].Text;
                if (MaxVolume.playState == WMPPlayState.wmppsPaused && MaxVolume.URL == curr)
                {
                    MaxVolume.controls.play();
                    timer1.Start();
                }
                else
                {
                    MaxVolume.URL = playlist.SelectedItems[0].SubItems[2].Text;
                    MaxVolume.controls.play();
                    timer1.Start();
                }
                label3.Text = "Сейчас играет: " + playlist.SelectedItems[0].SubItems[0].Text;
                var file = TagLib.File.Create(playlist.SelectedItems[0].SubItems[2].Text);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    song_cover.BackgroundImage = Image.FromStream(new MemoryStream(bin));
                }
                else song_cover.BackgroundImage = Image.FromFile(@"back1.png");
            }
            else if (liked_list.SelectedIndices.Count != 0)
            {
                string curr = liked_list.Items[liked_list.SelectedIndices[0]].SubItems[2].Text;
                if (MaxVolume.playState == WMPPlayState.wmppsPaused && MaxVolume.URL == curr)
                {
                    MaxVolume.controls.play();
                    timer1.Start();
                }
                else
                {
                    MaxVolume.URL = liked_list.SelectedItems[0].SubItems[2].Text;
                    MaxVolume.controls.play();
                    timer1.Start();
                }
                label3.Text = "Сейчас играет: " + liked_list.SelectedItems[0].SubItems[0].Text;
                var file = TagLib.File.Create(liked_list.SelectedItems[0].SubItems[2].Text);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    song_cover.BackgroundImage = Image.FromStream(new MemoryStream(bin));
                }
                else song_cover.BackgroundImage = Image.FromFile(@"back1.png");
            }
        }
        private void pause_Click(object sender, EventArgs e)
        {
            if (MaxVolume.playState == WMPPlayState.wmppsPlaying)
            {
                MaxVolume.controls.pause();
                timer1.Stop();
            }
            pause.Hide();
            play.Visible = true;
        }
        private void play_Click(object sender, EventArgs e)
        {
            if (playlist.Items.Count > 0)
            {
                PlaySong();
                play.Hide();
                pause.Show();
            }
        }
        private void mute_Click_1(object sender, EventArgs e)
        {
            MaxVolume.settings.mute = true;
            mute.Hide();
            unmute.Show();
        }
        private void unmute_Click(object sender, EventArgs e)
        {
            MaxVolume.settings.mute = false;
            unmute.Hide();
            mute.Show();
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (playlist.Items.Count > 0)
            {
                NextSong();
            }
        }
        private void prev_Click(object sender, EventArgs e)
        {
            if (playlist.Items.Count > 0)
            {
                PrevSong();
            }
        }
        private void stop_Click(object sender, EventArgs e)
        {
            MaxVolume.controls.stop();
            pause.Hide();
            play.Show();
            label3.Text = "Сейчас играет: ";
            label4.Text = "00:00";
            label5.Text = " ";
            timing_slider.Value = 0;
            song_cover.BackgroundImage = Image.FromFile(@"back1.png");
        }
        private void add_Click(object sender, EventArgs e)
        {
            OpenFileDialog add = new OpenFileDialog();
            add.Filter = "Audio Files|*.mp3";
            add.Multiselect = true;
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in add.FileNames)
                {
                    ListViewItem myitem = playlist.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file));
                    myitem.SubItems.Add(MaxVolume.newMedia(file).durationString);
                    myitem.SubItems.Add(file);
                }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MaxVolume.settings.volume = trackBar1.Value;
        }
        private void like_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in playlist.SelectedItems)
                liked_list.Items.Add(new ListViewItem(new string[] { item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text }));
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void NextSong()
        {
            if (playlist.SelectedIndices.Count != 0)
            {
                int curr = playlist.SelectedIndices[0];
                if (playlist.Items.Count - 1 > curr)
                {
                    curr++;
                    playlist.Items[curr - 1].Selected = false;
                    playlist.Items[curr].Selected = true;
                    playlist.Items[curr].EnsureVisible();
                    playlist.Select();
                }
                else
                {
                    playlist.Items[curr].Selected = false;
                    playlist.Items[0].Selected = true;
                    playlist.Items[0].EnsureVisible();
                    playlist.Select();
                }
            }
            else if (liked_list.SelectedIndices.Count != 0)
            {
                int curr = liked_list.SelectedIndices[0];
                if (liked_list.Items.Count - 1 > curr)
                {
                    curr++;
                    liked_list.Items[curr - 1].Selected = false;
                    liked_list.Items[curr].Selected = true;
                    liked_list.Items[curr].EnsureVisible();
                    liked_list.Select();
                }
                else
                {
                    liked_list.Items[curr].Selected = false;
                    liked_list.Items[0].Selected = true;
                    liked_list.Items[0].EnsureVisible();
                    liked_list.Select();
                }
            }
            PlaySong();
            play.Hide();
            pause.Show();
        }
        private void PrevSong()
        {
            if (playlist.SelectedIndices.Count != 0)
            {
                int curr = playlist.SelectedIndices[0];
                if (curr > 0)
                {
                    curr--;
                    playlist.Items[curr + 1].Selected = false;
                    playlist.Items[curr].Selected = true;
                    playlist.Items[curr].EnsureVisible();
                    playlist.Select();
                }
                else
                {
                    playlist.Items[0].Selected = true;
                    playlist.Items[0].EnsureVisible();
                    playlist.Select();
                }
            }
            else if (liked_list.SelectedIndices.Count != 0)
            {
                int curr = liked_list.SelectedIndices[0];
                if (curr > 0)
                {
                    curr--;
                    liked_list.Items[curr + 1].Selected = false;
                    liked_list.Items[curr].Selected = true;
                    liked_list.Items[curr].EnsureVisible();
                    liked_list.Select();
                }
                else
                {
                    liked_list.Items[0].Selected = true;
                    liked_list.Items[0].EnsureVisible();
                    liked_list.Select();
                }
            }
            PlaySong();
            play.Hide();
            pause.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MaxVolume.playState == WMPPlayState.wmppsPlaying)
            {
                timing_slider.Maximum = Convert.ToInt32(Math.Truncate(MaxVolume.currentMedia.duration));
                timing_slider.Value = Convert.ToInt32(Math.Truncate(MaxVolume.controls.currentPosition));
                label4.Text = MaxVolume.controls.currentPositionString;
                int m = Convert.ToInt32(MaxVolume.currentMedia.duration) / 60;
                int s = Convert.ToInt32(MaxVolume.currentMedia.duration) - m * 60;
                label5.Text = string.Format("{0:D}:{1:D2}", m, s);
            }
            if (timing_slider.Value == timing_slider.Maximum && playlist.Items.Count > 1)
            {
                Thread.Sleep(400);
                timing_slider.Value = 0;
                NextSong();
            }
            else if (timing_slider.Value == timing_slider.Maximum && playlist.Items.Count == 1)
            {
                stop_Click(sender, e);
            }
        }
        private void timing_slider_Scroll(object sender, EventArgs e)
        {
            MaxVolume.controls.currentPosition = timing_slider.Value;
        }
        private void dislike_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem song in playlist.SelectedItems)
            {
                playlist.Items.Remove(song);
            }
            foreach (ListViewItem song in liked_list.SelectedItems)
            {
                liked_list.Items.Remove(song);
            }
        }
        private void liked_list_Click(object sender, EventArgs e)
        {
            playlist.SelectedItems.Clear();
        }

        private void playlist_Click(object sender, EventArgs e)
        {
            liked_list.SelectedItems.Clear();
        }
        private Point mouseOffset;
        private bool isMouseDown = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }      
    }
}