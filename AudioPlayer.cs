using System;

using System.IO;
using System.Media;

namespace PROGPART1
{
    public class AudioPlayer
    {
        public static void PlayGreeting()//Plays a greeting sound when the chatbot starts
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;

                string dirrectory = baseDir.Replace("bin\\Debug\\", "");

                string path_directory = Path.Combine(dirrectory, "Greeting.wav");//Voice file should be in the same directory as the executable



                using (SoundPlayer player = new SoundPlayer(path_directory))
                {
                    player.Load();
                    player.PlaySync();
                }
                   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);

            }
        }
    }
}