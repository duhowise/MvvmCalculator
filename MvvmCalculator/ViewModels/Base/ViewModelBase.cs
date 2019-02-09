using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace MvvmCalculator.ViewModels.Base
{
    public class ViewModelBase:BindableBase
    {
        protected ViewModelBase()
        {
            RegisterCommand();
        }

        protected virtual void RegisterCommand()
        {

        }
    }
}
