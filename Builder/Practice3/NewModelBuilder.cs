using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice3
{
    internal class NewModelBuilder : BaseModelBuilder, IModelBuilder
    {
        public NewModelBuilder(string oldModel, string customerCode) : base(oldModel, customerCode)
        {
        }

        public string GenerateModel()
        {
            return string.Join("-", ModelPartList);
        }

        public string GenerateModelForQuery(string coolingType,string PSUCode) 
        {
            ModelPartList.Add(coolingType + PSUCode + "_");
            ModelPartList.Add(CustomerCode);

            return string.Join("-", ModelPartList);
        }

        public IModelBuilder GenerateModelPart1()
        {
            ModelPartList.Add(ModelCharArray[0]);
            return this;
        }

        public IModelBuilder GenerateModelPart2()
        {
            ModelPartList.Add(ModelCharArray[1]);
            return this;
        }

        public IModelBuilder GenerateModelPart3(string coolingType,string generationCode,string PSUCode,string SKUCode)
        {
            ModelPartList.Add(coolingType + PSUCode + SKUCode);
            return this;
        }

        public IModelBuilder GenerateModelPart4()
        {
            ModelPartList.Add(CustomerCode);
            return this;
        }

        public NewModelBuilder ClearModelPart(params string[] removeValue)
        {
            ModelPartList = ModelPartList.Where(t => removeValue.Contains(t)==false).ToList();
            return this;
        }
    }
}
