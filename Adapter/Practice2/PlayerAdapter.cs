using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practice2
{
    internal class PlayerAdapter:IPlayer
    {
        private MediaPlayer mediaPlayer;
        private RealPlayer realPlayer;

        public PlayerAdapter() 
        {
            mediaPlayer = new MediaPlayer();
            realPlayer = new RealPlayer();
        }

        public void Play(string player)
        {
            if (player == "Media") 
            {
                mediaPlayer.Play();
            }
            else
            {
                realPlayer.Play();
            }
        }
    }
}
