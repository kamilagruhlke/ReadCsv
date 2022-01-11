using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCsv.Models
{
    public class Price
    {
        public double Netto { get; set; }

        public double Vat { get; set; }

        public double Brutto { get; set; }

        public Price(string netto, string vat)
        {
            this.Netto = double.Parse(netto);
            this.Vat = double.Parse(vat);
        }

        public Price()
        {

        }

        public void CalculateValue()
        {
            Brutto = Netto + (Netto * (Vat / 100.0));
        }

        public override string ToString()
        {
            return $"{Netto};{Vat};{Brutto}";
        }
    }

}
