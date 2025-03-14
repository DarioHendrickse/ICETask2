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
using System.IO;

namespace MediaPlayerWAV
{
    class WAVPlayer
    {
        //initialising while loop flag to end program
        private bool endProgram = false;

        //initialising console output as constants
        const string welcome = "Welcome to the WAV Sound Player!\n(Inspired by Forrest Gump)\nWhich Sound would you like to hear?";
        const string wav1 = "1. Hello";
        const string wav2 = "2. Where is the pain?";
        const string wav3 = "3. Wise Words";

        //method to execute the console application
        public void Run()
        {
            Console.WriteLine($"{welcome}\n{wav1}\n{wav2}\n{wav3}");

            //creating while loop to run the application so long as the user wishes to not end program
            //based on user input, the correct sound will be played
            while (endProgram == false)
            {

                var input = Console.ReadLine();

                switch (input.Trim())
                {
                    case "1":
                        PlaySound("gump.wav", 1);
                        break;
                    case "2":
                        PlaySound("buttocks.wav", 2);
                        break;
                    case "3":
                        PlaySound("box_of_chocolates_x.wav", 3);
                        break;
                    default:
                        endProgram = true;
                        break;
                }
            }

        }

        /// <summary>
        /// Takes the .wav sound file name and an integer to determine which choice was made
        /// Plays the sound and prints same welcome message and choices, but the .wav that was just played is now green
        /// </summary>
        /// <param name="file"></param>
        /// <param name="wav"></param>
        public void PlaySound(String file, int wav)
        {

            Console.WriteLine("\nPlaying sound...");

            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = file;
            sound.PlaySync();

            switch (wav)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"{welcome}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(wav1);

                    Console.ResetColor();
                    Console.WriteLine($"{wav2}\n{wav3}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"{welcome}\n{wav1}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(wav2);

                    Console.ResetColor();
                    Console.WriteLine(wav3);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"{welcome}\n{wav1}\n{wav2}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(wav3);

                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }


    }
}
