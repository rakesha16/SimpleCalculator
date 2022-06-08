using Calulater.Core.Modules;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Calulater.Core.Api
{
    public class CurrencyRate
    {
        public ResponseObect CalculateCurrencyRate(RequestObject currencyType)
        {
            if (currencyType != null)
            {
                RestClient client = new RestClient("https://api.apilayer.com/fixer");
                var request = new RestRequest("/latest?symbols="+currencyType.TypeOfCurrency+"&base=usd", Method.Get);
                request.AddHeader("apikey", "GlJrsrYWi2T9qdwzwg8QSh9fBcJPSClq");
                var response = client.Execute(request);
                if (response.StatusCode.ToString() == "OK") {
                    ResponseObect detailsOfCurrencyRate = JsonConvert.DeserializeObject<ResponseObect>(response.Content);
                    return detailsOfCurrencyRate;
                }
            }
            return null;
        }
    }
}
