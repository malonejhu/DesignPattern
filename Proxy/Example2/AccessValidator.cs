using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example2
{
    internal class AccessValidator
    {
        public bool Validate(string userId) 
        {
            Console.WriteLine("驗證用戶中..");

            if (userId.Contains("AA")) 
            {
                Console.WriteLine("登入成功");
                return true;
            }
            else
            {
                Console.WriteLine("登入失敗");
                return false;
            }
        }
    }
}
