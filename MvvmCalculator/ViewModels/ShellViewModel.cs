using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using MvvmCalculator.ViewModels.Base;
using Prism.Commands;

namespace MvvmCalculator.ViewModels
{
    public class ShellViewModel:ViewModelBase
    {
        public ShellViewModel()
        {
            
        }

        public string Title => "Some Calculator";

       
      
        private string _calculatorText;
        public string CalculatorText
        {
            get => _calculatorText;
            set => SetProperty(ref _calculatorText, value);
        }


        public DelegateCommand<string> NumericButtonPushCommand { get; set; }

        protected override void RegisterCommand()
        {
            NumericButtonPushCommand=new DelegateCommand<string>(ButtonPushed);
        }

        private void ButtonPushed(string obj)
        {
            CalculatorText +=obj;
        }

    }
}
