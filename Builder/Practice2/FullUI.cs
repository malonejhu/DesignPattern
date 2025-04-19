using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice2
{
    internal class FullUI : UIBuilder
    {
        protected override void RemoveUI()
        {
            this.videoPlayer.UIFunc.Remove("收藏列");
        }

        public override VideoPlayer CreateVideoPlayer()
        {
            RemoveUI();
            return videoPlayer;
        }
    }
}
