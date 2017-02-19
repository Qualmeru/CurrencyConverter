using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyConverter.Models
{
    public class CurrencyTable
    {
        public List<CurrencyTable> TableView;
        public CurrencyTable()
        {
            TableView  = new List<CurrencyTable>();
        }
        public DateTime valutaKursDatum { get; set; }
        public decimal valueInput { get; set; }
        public enum valutaTyp_Input { SEK = 1, USD = 2, EUR = 3, GBP = 4 }
        public double exchange { get; set; }
        public int valueOutput { get; set; }
        public enum valutaTyp_Output { SEK = 1, USD = 2, EUR = 3, GBP = 4 }
    }
}