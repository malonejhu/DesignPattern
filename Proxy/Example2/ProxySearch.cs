using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example2
{
    internal class ProxySearch:Searcher
    {
        private RealSearcher realSearcher = new RealSearcher();
        private AccessValidator validator = new AccessValidator();
        private Logger logger = new Logger();

        public string DoSearch(string userId, string keyword)
        {
            if (Validate(userId))
            {
                string result = realSearcher.DoSearch(userId, keyword);

                Log(userId);

                return result;
            }
            else 
            {
                return null;
            }
        }

        private bool Validate(string userId) 
        {
            return validator.Validate(userId);
        }


        private void Log(string userId) 
        {
            logger.Log(userId);
        }
    }
}
