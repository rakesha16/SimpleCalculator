using Calulater.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulater.Core.Bal
{
    interface IOperationFactory
    {
       IOperater GetOperationType(int selectedOperation);
    }
}
