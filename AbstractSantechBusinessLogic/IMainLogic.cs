using AbstractSantechBusinessLogic.BindingModels;
using AbstractSantechBusinessLogic.ViewModels;
using System.Collections.Generic;
namespace AbstractSantechBusinessLogic.Interfaces
{
    public interface IMainLogic
    {
        List<OrderViewModel> GetOrders();
        void CreateOrder(OrderBindingModel model);
        void TakeOrderInWork(OrderBindingModel model);
        void FinishOrder(OrderBindingModel model);
        void PayOrder(OrderBindingModel model);
    }
}