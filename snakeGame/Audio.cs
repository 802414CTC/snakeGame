using System;
using System.Windows.Data;
using System.Windows.Media;

namespace snakeGame
{
    public static class Audio
    {
        public readonly static MediaPlayer EatingFood = LoadAudio("hit-swing-sword-small-2-95566.mp3");

        public readonly static MediaPlayer GameOver = LoadAudio("mixkit-arcade-retro-game-over-213.wav");
        private static MediaPlayer LoadAudio(string filename, double volume=1, bool autoReset = true)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));
            player.Volume = volume;
            if (autoReset)
            {
                player.MediaEnded += player_MediaEnded;
            }
            return player;
        }

        private static void player_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }

    }
}
