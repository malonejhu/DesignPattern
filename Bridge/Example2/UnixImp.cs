﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    internal class UnixImp : ImageImp
    {
        public void DoPaint(Martix x)
        {
            Console.WriteLine("Unix顯示圖像");
        }
    }
}
