using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calulater.Core.Bal;
using Calulater.Core.Contracts;
using Calulater.Core.Api;
using Calulater.Core.Modules;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedOperation;
            do
            {
                Console.WriteLine("Please enter which operation you like to perform");
                Console.WriteLine("1--Addition");
                Console.WriteLine("2--Subtraction");
                Console.WriteLine("3--Division");
                Console.WriteLine("4--Multiplication");
                Console.WriteLine("5--To get latesr currency rates");
                selectedOperation = int.Parse(Console.ReadLine());
            } while (selectedOperation == 0 || selectedOperation >= 6);
            
            
                if (selectedOperation != 5)
                {
                    Console.WriteLine("Enter first value");
                    float firstValue = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second value");
                    float secondValue = float.Parse(Console.ReadLine());
                    GenericOperationFactory factary = new GenericOperationFactory();
                    IOperater operation = factary.GetOperationType(selectedOperation);
                    var result = operation.Calculate(firstValue, secondValue);
                    if (result!=null) {
                        Console.WriteLine("Result is ");
                        Console.Write(result);
                    }                  
                }
                else if (selectedOperation == 5)
                {
                    int TypeOfCurrency;
                    do
                    {
                        Console.WriteLine("Please enter which currency rate you want to check");
                        Console.WriteLine("1--INR");
                        Console.WriteLine("2--AUD");
                        Console.WriteLine("3--GDP");
                        Console.WriteLine("3--EUR");
                        TypeOfCurrency = int.Parse(Console.ReadLine());
                    } while (TypeOfCurrency == 0 || TypeOfCurrency >= 4);
                    RequestObject currencyConvertedExpeted = new RequestObject();
                    if (TypeOfCurrency == 1)
                    {
                        currencyConvertedExpeted.TypeOfCurrency = "INR";
                    }
                    else if (TypeOfCurrency == 2)
                    {
                        currencyConvertedExpeted.TypeOfCurrency = "AUD";
                    }
                    else if (TypeOfCurrency == 3)
                    {
                        currencyConvertedExpeted.TypeOfCurrency = "GDP";
                    }
                    else if (TypeOfCurrency == 4)
                    {
                        currencyConvertedExpeted.TypeOfCurrency = "EUR";
                    }
                    CurrencyRate currencyRate = new CurrencyRate();
                    ResponseObect responseDetails = currencyRate.CalculateCurrencyRate(currencyConvertedExpeted);
                    var displayRate = 0.0;
                    if (TypeOfCurrency == 1)
                    {
                      displayRate = responseDetails.rates.inr;
                    }
                    else if (TypeOfCurrency == 2)
                    {
                       displayRate = responseDetails.rates.aud;
                    }
                    else if (TypeOfCurrency == 3)
                    {
                       displayRate = responseDetails.rates.gbp;
                    }
                    else if (TypeOfCurrency == 4)
                    {
                       displayRate = responseDetails.rates.eur;
                    }
                    Console.WriteLine("Currency rate of {0} USD is {1} at date {2}",
                               currencyConvertedExpeted.TypeOfCurrency,
                               displayRate,
                               responseDetails.date);
                }          
            }
        }
    }    

