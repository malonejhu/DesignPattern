using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice2
{
    internal class SimpleUI : UIBuilder
    {
        public override VideoPlayer CreateVideoPlayer()
        {
            this.RemoveUI();
            return videoPlayer;
        }

        protected override void RemoveUI()
        {
            this.videoPlayer.UIFunc.Remove("菜單");
            this.videoPlayer.UIFunc.Remove("播放列表");
            this.videoPlayer.UIFunc.Remove("收藏列");
        }
    }
}
