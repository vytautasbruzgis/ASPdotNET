using _20220105_SEB_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace _20220105_SEB_HomeWork.Services
{
    public class CurrencyService
    {
        public List<CurrencyModel> GetDataByDate(DateTime date)
        {
            DateTime lastDay = date.AddDays(-1);
            List<CurrencyModel> list = LoadData(date);
            List<CurrencyModel> listBefore = LoadData(lastDay);

            foreach (var item in list)
            {
                var itemBefore = listBefore.Where(a => a.Currency == item.Currency).FirstOrDefault();
                if (itemBefore != null)
                {
                    item.LastRate = itemBefore.Rate;
                    item.ChangePercentage = Math.Round((decimal)((decimal)item.Rate - (decimal)itemBefore.Rate)/item.Rate, 4);
                } else
                {
                    item.ChangePercentage = 0;
                } 
            }

            return list.OrderByDescending(a => a.ChangePercentage).ToList();
        }
        private List<CurrencyModel> LoadData(DateTime date)
        {
            List<CurrencyModel> currencyModels = new List<CurrencyModel>();

            XElement xelement = XElement.Load("http://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=" + date.ToShortDateString());
            IEnumerable<XElement> exchangeRates = xelement.Elements();

            foreach (var item in exchangeRates)
            {
                currencyModels.Add(new CurrencyModel()
                {
                    Date = Convert.ToDateTime(item.Element("date").Value),
                    Currency = item.Element("currency").Value,
                    Quantity = Int32.Parse(item.Element("quantity").Value),
                    Rate = Convert.ToDecimal(item.Element("rate").Value.Replace(".", ",")),
                    Unit = item.Element("unit").Value
                }) ;
            }            
            return currencyModels;
        }
    }
}
