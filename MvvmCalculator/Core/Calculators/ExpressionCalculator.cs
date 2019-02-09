using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCalculator.Core.Calculators
{
    public class ExpressionCalculator:ICalculator
    {
        public double Calculate(string expression)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expression,"");
            return Convert.ToDouble(value);
        }
    }
}
