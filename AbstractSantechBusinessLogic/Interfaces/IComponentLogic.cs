using AbstractSantechBusinessLogic.BindingModels;
using AbstractSantechBusinessLogic.ViewModels;
using System.Collections.Generic;
namespace AbstractSantechBusinessLogic.Interfaces
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);
        void CreateOrUpdate(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);
    }
}
