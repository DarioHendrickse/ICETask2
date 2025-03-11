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

namespace MediaPlayerWAV
{
    class Program
    {
        static void Main(string[] args)
        {
            var WAVPlayer = new WAVPlayer();
            WAVPlayer.Run();
        }
    }
}
