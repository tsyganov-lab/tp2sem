using AbstractSantechBusinessLogic.BindingModels;
using AbstractSantechBusinessLogic.ViewModels;
using System.Collections.Generic;
namespace AbstractSantechBusinessLogic.Interfaces
{
    public interface IProductLogic
    {
        List<ProductViewModel> GetList();
        ProductViewModel GetElement(int id);
        void AddElement(ProductBindingModel model);
        void UpdElement(ProductBindingModel model);
        void DelElement(int id);
    }
}