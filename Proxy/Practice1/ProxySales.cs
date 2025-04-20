using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Practice1
{
    internal class ProxySales : SalesObject
    {
        private RealSalesObject RealSalesObject = new RealSalesObject();

        public override void Method()
        {
            Log("開始查詢...Method");

            try
            {
                RealSalesObject.Method();

                Log("查詢成功...Method");
            }
            catch (Exception ex) 
            {
                Log("發生錯誤...Method");
            }
        }


        public void Log(string methodName)
        {
            Console.WriteLine(methodName + "被呼叫" + DateTime.Now.ToString("yyy/MM/dd hh:mm:ss"));
        }
    }
}
