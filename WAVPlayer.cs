/*
 * DARIO HENDRICKSE
 * ST10436137
 * PROG6211 ICE2
 * Git Repo: https://github.com/DarioHendrickse/ICETask2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MediaPlayerWAV
{
    class WAVPlayer
    {
        /*
        private SoundPlayer WAV1 = new SoundPlayer(@"gump.wav");
        private SoundPlayer WAV2 = new SoundPlayer(@"buttocks.wav");
        private SoundPlayer WAV3 = new SoundPlayer(@"box_of_chocolates_x.wav");
        */
        private bool endProgram = false;
        private string welcome = "Welcome to the WAV Sound Player!\n(Inspired by Forrest Gump)\nWhich Sound would you like to hear?";
        private string wav1 = "1. Hello";
        private string wav2 = "2. Where is the pain?";
        private string wav3 = "3. Wise Words";

        public void Run()
        {
            Console.WriteLine($"{welcome}\n{wav1}\n{wav2}\n{wav3}");

            while (endProgram==false)
            {

                var input = Console.ReadLine();

                switch (input.Trim())
                {
                    case "1":
                        PlaySound("gump.wav");

                        Console.Clear();
                        Console.WriteLine($"{welcome}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(wav1);

                        Console.ResetColor();
                        Console.WriteLine($"{wav2}\n{wav3}");

                        break;
                    case "2":
                        PlaySound("buttocks.wav");

                        Console.Clear();
                        Console.WriteLine($"{welcome}\n{wav1}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(wav2);

                        Console.ResetColor();
                        Console.WriteLine(wav3);

                        break;
                    case "3":
                        PlaySound("box_of_chocolates_x.wav");
                        
                        Console.Clear();
                        Console.WriteLine($"{welcome}\n{wav1}\n{wav2}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(wav3);

                        Console.ResetColor();

                        break;
                    default:
                        endProgram = true;
                        break;
                }
            }
            
        }

        public void PlaySound(String file)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = file;
            sound.PlaySync();

        }

    }
}
