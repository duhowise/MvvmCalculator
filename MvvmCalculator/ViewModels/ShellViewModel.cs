using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using MvvmCalculator.Core.Calculators;
using MvvmCalculator.ViewModels.Base;
using Prism.Commands;

namespace MvvmCalculator.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly ICalculator _calculator;

        public ShellViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public string Title => "Some Calculator";


        private string _expression;

        public string Expression
        {
            get => _expression;
            set => SetProperty(ref _expression, value);
        }


        public DelegateCommand<string> NumericButtonPushCommand { get; set; }

        protected override void RegisterCommand()
        {
            NumericButtonPushCommand = new DelegateCommand<string>(ButtonPushed);
        }

        private void ButtonPushed(string obj)
        {
            if (_hasCalculated)
            {
                if (!double.TryParse(obj, out var value))
                {
                    Expression += obj;
                    _hasCalculated = false;
                    return;
                }

                ExecuteClearCommand();
                _hasCalculated = false;
            }

            Expression += obj;
        }


        private DelegateCommand _clearCommand;

        public DelegateCommand ClearCommand =>
            _clearCommand ?? (_clearCommand = new DelegateCommand(ExecuteClearCommand));

        private DelegateCommand<string> _equalsCommand;
        private bool _hasCalculated;

        public DelegateCommand<string> EqualsCommand =>
            _equalsCommand ?? (_equalsCommand = new DelegateCommand<string>(ExecuteEqualsCommand));

        void ExecuteEqualsCommand(string parameter)
        {
            Expression = _calculator.Calculate(parameter).ToString("N");
            _hasCalculated = true;
        }

        void ExecuteClearCommand()
        {
            Expression = String.Empty;
        }
    }
}
