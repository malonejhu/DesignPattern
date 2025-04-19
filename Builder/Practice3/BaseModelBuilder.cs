using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice3
{
    internal abstract class BaseModelBuilder
    {
        protected List<string> ModelPartList;
        protected string CustomerCode { get; set; }
        protected List<string> ModelCharArray;

        public BaseModelBuilder(string oldModel,string customerCode)
        {
            ModelCharArray = oldModel.Split('-').ToList();
            ModelPartList = new List<string>();
            SetCustomerCode(customerCode);

        }

        private void SetCustomerCode(string customerCode) 
        {
            string oldModelCustomerCode = ModelCharArray.Last();

            CustomerCode = customerCode != oldModelCustomerCode
                ? customerCode
                : oldModelCustomerCode;
        }
    }
}
