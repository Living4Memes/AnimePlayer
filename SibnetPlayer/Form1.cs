using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCustomLib.Controls;

namespace SibnetPlayer
{
      public partial class Form1 : CustomForm
      {
            AnimeCollection _animeCollection = new AnimeCollection();

            public Form1()
            {
                  InitializeComponent();
                  StartPosition = FormStartPosition.CenterScreen;
                  TopMost = Properties.Settings.Default.AlwaysOnTop;
            }

            private static string Request(string uri)
            {
                  using (WebClient client = new WebClient())
                  {
                        client.Encoding = Encoding.UTF8;
                        return client.DownloadString(uri);
                  }
            }

            protected override void OnHandleCreated(EventArgs e)
            {
                  base.OnHandleCreated(e);

                  foreach (Control control in Controls)
                  {
                        control.DragEnter += Form1_DragEnter;
                        control.DragLeave += Form1_DragLeave;
                        control.DragDrop += Form1_DragDrop;
                  }
            }

            private void UpdateInfo()
            {
                  if (_animeCollection.Count < 1)
                        return;

                  animeTitleLabel.Text = _animeCollection.CurrentAnime.Title;
                  episodeNumberLabel.Text = (_animeCollection.CurrentAnime.LastEpisodeWatched + 1).ToString();

                  if (Properties.Settings.Default.DirectStart)
                        _animeCollection.CurrentAnime.StartCurrentEpisode();
            }

            private void UpdateCurrentEpisode(int index)
            {
                  _animeCollection.CurrentAnime.LastEpisodeWatched = index;

                  episodeNumberLabel.Text = (index + 1).ToString();

                  if (Properties.Settings.Default.DirectStart)
                        _animeCollection.CurrentAnime.StartCurrentEpisode();
            }

            private void Form1_DragEnter(object sender, DragEventArgs e)
            {
                  if (e.Data.GetDataPresent(DataFormats.Text))
                  {
                        e.Effect = DragDropEffects.Copy;
                  }
            }

            private void Form1_DragLeave(object sender, EventArgs e)
            {
                  
            }

            private void Form1_DragDrop(object sender, DragEventArgs e)
            {
                  string response = Request(e.Data.GetData(DataFormats.Text).ToString());
                  Anime newAnime = new Anime(AnimenimeParser.GetAnimeInfo(response));

                  if (String.IsNullOrEmpty(newAnime.Title))
                        return;

                  if (_animeCollection.FirstOrDefault(x => x.Title == newAnime.Title) == null)
                        _animeCollection.Add(newAnime);
                  else
                  {
                        MessageBox.Show("Такое аниме уже есть в списке!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                  }

                  UpdateInfo();
            }

            private void animeTitleLabel_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                  if (_animeCollection.Count < 2)
                        return;

                  SelectForm form = new SelectForm("Выбор аниме", _animeCollection.Select(x => x.Title).ToList());

                  form.ItemChoose += (i) =>
                  {
                        _animeCollection.CurrentAnimeIndex = i;
                        UpdateInfo();
                  };

                  form.ShowDialog();
            }

            private void previousEpisodeButton_Click(object sender, EventArgs e)
            {
                  if (Properties.Settings.Default.DirectStart)
                        _animeCollection.CurrentAnime.StartPreviousEpisode();
                  else
                        _animeCollection.CurrentAnime.PreviousEpisode();

                  episodeNumberLabel.Text = (_animeCollection.CurrentAnime.LastEpisodeWatched + 1).ToString();
            }

            private void nextEpisodeButton_Click(object sender, EventArgs e)
            {
                  if (Properties.Settings.Default.DirectStart)
                        _animeCollection.CurrentAnime.StartNextEpisode();
                  else
                        _animeCollection.CurrentAnime.NextEpisode();

                  episodeNumberLabel.Text = (_animeCollection.CurrentAnime.LastEpisodeWatched + 1).ToString();
            }

            private void episodeNumberLabel_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                  if (_animeCollection.CurrentAnime.EpisodeLinks.Count < 2)
                        return;

                  List<string> episodes = new List<string>();

                  for(int i = 0; i < _animeCollection.CurrentAnime.EpisodeLinks.Count; i++)
                        episodes.Add($"Эпизод {i + 1}");

                  SelectForm form = new SelectForm("Выбор Эпизода", episodes);

                  form.ItemChoose += (i) => UpdateCurrentEpisode(i);

                  form.ShowDialog();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                  _animeCollection.CurrentAnime.StartCurrentEpisode();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                  ConfigurationForm form = new ConfigurationForm();

                  form.FormClosed += (s, ev) =>
                  {
                        TopMost = Properties.Settings.Default.AlwaysOnTop;
                  };

                  form.ShowDialog();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                  _animeCollection.ImportFromFile(Properties.Settings.Default.FilePath);

                  UpdateInfo();
            }

            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                  _animeCollection.SaveToFile(Properties.Settings.Default.FilePath);
            }
      }
}
