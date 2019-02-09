using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCalculator.ViewModels.Base;

namespace MvvmCalculator.ViewModels
{
    public class ShellViewModel:ViewModelBase
    {
        public ShellViewModel()
        {
            
        }

        public string Title => "Some Calculator";
    }
}
