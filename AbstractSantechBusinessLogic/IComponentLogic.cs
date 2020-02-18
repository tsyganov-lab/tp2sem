using AbstractSantechBusinessLogic.BindingModels;
using AbstractSantechBusinessLogic.ViewModels;
using System.Collections.Generic;
namespace AbstractSantechBusinessLogic.Interfaces
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> GetList();
        ComponentViewModel GetElement(int id);
        void AddElement(ComponentBindingModel model);
        void UpdElement(ComponentBindingModel model);
        void DelElement(int id);
    }
}
