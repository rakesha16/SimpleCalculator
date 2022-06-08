using Calulater.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulater.Core.Bal
{
    public class Multiplication : IOperater
    {
        public float Calculate(float valueOne, float valueTwo)
        {
            return valueOne * valueTwo;
        }
    }
}
