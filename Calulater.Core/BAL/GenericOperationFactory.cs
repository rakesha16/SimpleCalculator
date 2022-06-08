using Calulater.Core.Contracts;
using Calulater.Core.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulater.Core.Bal
{
    public class GenericOperationFactory : IOperationFactory
    {
        public  IOperater GetOperationType(int selectedOperation)
        {
            if (selectedOperation == 1)
            {
                return new Plus();
            }
            else if (selectedOperation == 2)
            {
                return new Minus();
            }
            else if (selectedOperation == 3)
            {
                return new Division();
            }
            else if (selectedOperation == 4)
            {
                return new Multiplication();
            }
            else
                return null;
        }
    }
}
