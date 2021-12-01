namespace Ucu.Poo.Defense
{
    public interface IOfferItem
    {

        Residue Residue { get; set; }

        int Quantity { get; set; }

         int Price { get; set; }

        int SubTotal{get; }

    }
}