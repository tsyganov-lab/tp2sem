using System.ComponentModel;
namespace AbstractSantechBusinessLogic.ViewModels
{
    /// <summary>
    /// Сколько компонента, требуется при изготовлении изделия
    /// </summary>
    public class ProductComponentViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ComponentId { get; set; }
        [DisplayName("Компонент")]
        public string ComponentName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
    }
}
