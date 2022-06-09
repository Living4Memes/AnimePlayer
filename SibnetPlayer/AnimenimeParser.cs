using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SibnetPlayer
{
      public struct AnimeInfo
      {
            public string Title { get; set; }
            public int EpisodeCount { get; set; }
            public List<string> EpisodeLinks { get; set; }
            public int LastEpisodeWatched { get; set; }
      }

      public static class AnimenimeParser
      {
            public static AnimeInfo GetAnimeInfo(string html)
            {
                  if (!html.Contains("playerTwo0"))
                  {
                        MessageBox.Show("Ссылка не содержит нужного плеера с русскими субтитрами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return new AnimeInfo();
                  }

                  const string sibnetLink = "video.sibnet.ru/shell.php?videoid=[id]";
                  AnimeInfo info = new AnimeInfo();
                  List<string> vids = new List<string>();
                  string response;
                  response = html.Remove(0, html.LastIndexOf("<div class=\"tdd\">"));

                  Regex re = new Regex(@"plr\w*?\('\d*','\d*','\d?','\d?'\)");

                  foreach (Match match in re.Matches(response))
                  {
                        string temp = match.Value.Remove(match.Value.IndexOf("',"));
                        temp = temp.Remove(0, temp.IndexOf("('") + 2);
                        vids.Add("http://www." + sibnetLink.Replace("[id]", temp));
                  }

                  info.EpisodeLinks = vids;
                  info.EpisodeCount = vids.Count;

                  response = html.Remove(0, html.IndexOf("<div class=\"title_gr_full\">"));
                  response = response.Remove(response.IndexOf("<div class=\"d_line\">"));
                  response = response.Remove(0, response.IndexOf("<h2>") + 4);
                  response = response.Remove(response.IndexOf("</h2>"));

                  info.Title = response;
                  info.LastEpisodeWatched = 0;

                  return info;
            }
      }

      public class Anime
      {
            public string Title { get; set; } = String.Empty;
            public int EpisodeCount { get; set; } = 0;
            public List<string> EpisodeLinks { get; set; } = null;
            public int LastEpisodeWatched { get; set; } = 0;

            public Anime(AnimeInfo info)
            {
                  Title = info.Title;
                  EpisodeCount = info.EpisodeCount;
                  EpisodeLinks = info.EpisodeLinks;
                  LastEpisodeWatched = info.LastEpisodeWatched;
            }

            public void NextEpisode()
            {
                  if (LastEpisodeWatched == EpisodeLinks.Count - 1)
                        return;

                  LastEpisodeWatched++;
            }

            public void PreviousEpisode()
            {
                  if (LastEpisodeWatched == 0)
                        return;
                  LastEpisodeWatched--;
            }

            public void StartNextEpisode()
            {
                  NextEpisode();

                  OpenEpisode(EpisodeLinks[LastEpisodeWatched]);
            }

            public void StartPreviousEpisode()
            {
                  PreviousEpisode();

                  OpenEpisode(EpisodeLinks[LastEpisodeWatched]);
            }

            public void StartCurrentEpisode()
            {
                  OpenEpisode(EpisodeLinks[LastEpisodeWatched]);
            }

            private static void OpenEpisode(string link)
            {
                  System.Diagnostics.Process.Start(link);
            }
      }

      public class AnimeCollection : IEnumerable, IEnumerable<Anime>
      {
            private List<Anime> _animeList = new List<Anime>();
            private int _animeIndex = 0;
            
            public Anime this[int index]
            {
                  get => _animeList[index];
            }

            public Anime this[string animeTitle]
            {
                  get => _animeList.FirstOrDefault(x => x.Title == animeTitle);
            }

            public Anime CurrentAnime { get { return _animeList.Count > 0 ? _animeList[_animeIndex] : null; } }
            public int CurrentAnimeIndex { get => _animeIndex; set => _animeIndex = value; }
            public int Count { get => _animeList.Count; }

            public AnimeCollection(List<Anime> list)
            {
                  _animeList = list;
            }

            public AnimeCollection() : this(new List<Anime>()) { }

            public void Add(Anime anime)
            {
                  if (_animeList.FirstOrDefault(x => x.Title == anime.Title) == null)
                  {
                        _animeList.Add(anime);
                        _animeIndex = _animeList.Count - 1;
                  }
                  else
                        MessageBox.Show("Такое аниме уже есть в списке!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
            }

            public IEnumerator GetEnumerator()
            {
                  return _animeList.GetEnumerator();
            }

            IEnumerator<Anime> IEnumerable<Anime>.GetEnumerator()
            {
                  return _animeList.GetEnumerator();
            }

            public void SaveToFile(string path)
            {
                  using (XorStream xs = new XorStream(File.OpenWrite(path), 0x5))
                  using (BinaryWriter bw = new BinaryWriter(xs))
                  {
                        bw.Write(Count);
                        bw.Write(CurrentAnime.Title);

                        foreach(Anime anime in this)
                        {
                              bw.Write(anime.Title);
                              bw.Write(anime.LastEpisodeWatched);
                              bw.Write(anime.EpisodeLinks.Count);
                              foreach (string link in anime.EpisodeLinks)
                                    bw.Write(link);
                        }

                        xs.Close();
                  }
            }

            public void ImportFromFile(string path)
            {
                  if(!File.Exists(path))
                  {
                        MessageBox.Show($"Файл сохранений по пути \"{path}\" не найден.");
                        return;
                  }

                  using (XorStream xs = new XorStream(File.OpenRead(path), 0x5))
                  using (BinaryReader br = new BinaryReader(xs))
                  {
                        int count = br.ReadInt32();
                        string currentAnime = br.ReadString();
                        for (int i = 0; i < count; i++)
                        {
                              string title = br.ReadString();
                              int lastEp = br.ReadInt32();
                              int epCount = br.ReadInt32();

                              List<string> episodes = new List<string>();
                              for (int j = 0; j < epCount; j++)
                                    episodes.Add(br.ReadString());

                              Add(new Anime(new AnimeInfo()
                              {
                                    Title = title,
                                    EpisodeCount = epCount,
                                    EpisodeLinks = episodes,
                                    LastEpisodeWatched = lastEp
                              }));
                        }

                        CurrentAnimeIndex = _animeList.IndexOf(_animeList.Single(x => x.Title == currentAnime));
                  }
            }

            private class XorStream : Stream
            {
                  //Класс полностью сделан хорошим человеком с CyberForum - SSTREGG https://www.cyberforum.ru/members/105416.html
                  private readonly Stream _parent;
                  private readonly byte _xor;

                  public XorStream(Stream stream, byte xor)
                  {
                        _parent = stream;
                        _xor = xor;
                  }

                  public override bool CanRead
                  {
                        get { return _parent.CanRead; }
                  }

                  public override bool CanSeek
                  {
                        get { return _parent.CanSeek; }
                  }

                  public override bool CanWrite
                  {
                        get { return _parent.CanWrite; }
                  }

                  public override void Flush()
                  {
                        _parent.Flush();
                  }

                  public override long Length
                  {
                        get { return _parent.Length; }
                  }

                  public override long Position
                  {
                        get { return _parent.Position; }
                        set { _parent.Position = value; }
                  }

                  public override int Read(byte[] buffer, int offset, int count)
                  {
                        int readed = _parent.Read(buffer, offset, count);
                        for (int i = offset; i < readed; ++i)
                              buffer[i] ^= _xor;
                        return readed;
                  }

                  public override long Seek(long offset, SeekOrigin origin)
                  {
                        return _parent.Seek(offset, origin);
                  }

                  public override void SetLength(long value)
                  {
                        _parent.SetLength(value);
                  }

                  public override void Write(byte[] buffer, int offset, int count)
                  {
                        for (int i = offset; i < count; ++i)
                              buffer[i] ^= _xor;
                        _parent.Write(buffer, offset, count);
                  }

                  public override void Close()
                  {
                        _parent.Close();
                  }
            }
      }
}
