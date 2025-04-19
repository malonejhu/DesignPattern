using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice2
{
    internal class MemoryUI:UIBuilder
    {
        protected override void RemoveUI()
        {
            this.videoPlayer.UIFunc.Remove("菜單");
            this.videoPlayer.UIFunc.Remove("播放列表");
        }

        public override VideoPlayer CreateVideoPlayer()
        {
            RemoveUI();
            return videoPlayer;
        }
    }
}
