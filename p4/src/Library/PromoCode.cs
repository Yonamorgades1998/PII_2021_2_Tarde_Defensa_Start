using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode:IOfferItem

    {
        public int Price { get; set; }
        public Residue Residue { get ; set;}
        private string code {get;set;}
        public int Quantity { get; set; }

        public int SubTotal
        {
            get
            {
                return this.Quantity;
            }
            set
            {
                this.Quantity = value;
            }
        }

        public PromoCode(string code, int amount)
        {
            this.code = code;
            this.SubTotal = amount;
        }
    }
}