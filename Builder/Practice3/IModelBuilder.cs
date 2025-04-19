using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Practice3
{
    public interface IModelBuilder
    {
        IModelBuilder GenerateModelPart1();
        IModelBuilder GenerateModelPart2();
        IModelBuilder GenerateModelPart3(string coolingType, string generationCode, string PSUCode, string SKUCode);
        IModelBuilder GenerateModelPart4();
        string GenerateModel();

    }
}
