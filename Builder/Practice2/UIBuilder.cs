using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice2
{
    internal abstract class UIBuilder
    {
        protected VideoPlayer videoPlayer = new VideoPlayer();

        protected abstract void RemoveUI();

        public abstract VideoPlayer CreateVideoPlayer();
    }
}
