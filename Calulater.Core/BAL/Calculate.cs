using Calulater.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulater.Core.Modules
{
    public class Calculate
    {
        private IOperater calculateInterface;

        //Constructor assigns strategy to interface  
        public Calculate(IOperater strategy)
        {
            calculateInterface = strategy;
        }

        //Executes the strategy
        public float CalculateStrategy(float valueOne, float valueTwo)
        {
            return calculateInterface.Calculate(valueOne, valueTwo);
        }
    }
}
