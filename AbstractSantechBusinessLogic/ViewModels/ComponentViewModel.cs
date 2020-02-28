﻿using System.ComponentModel;
namespace AbstractSantechBusinessLogic.ViewModels
{
 /// <summary>
 /// Компонент, требуемый для изготовления изделия
 /// </summary>
 public class ComponentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название компонента")]
        public string ComponentName { get; set; }
    }
}
