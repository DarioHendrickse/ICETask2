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
