using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CommonServiceLocator;
using MvvmCalculator.Core.Calculators;
using MvvmCalculator.Views;
using Prism.Ioc;
using Prism.Unity;

namespace MvvmCalculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
         containerRegistry.Register<ICalculator,ExpressionCalculator>();
      

        }

        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();

        }
    }

  
}
