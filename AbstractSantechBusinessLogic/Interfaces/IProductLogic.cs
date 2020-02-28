using AbstractSantechBusinessLogic.BindingModels;
using AbstractSantechBusinessLogic.ViewModels;
using System.Collections.Generic;
namespace AbstractSantechBusinessLogic.Interfaces
{
    public interface IProductLogic
    {
        List<ProductViewModel> Read(ProductBindingModel model);
        void CreateOrUpdate(ProductBindingModel model);
        void Delete(ProductBindingModel model);
    }
}