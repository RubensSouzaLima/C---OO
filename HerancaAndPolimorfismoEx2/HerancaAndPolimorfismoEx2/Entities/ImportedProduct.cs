
using System.Globalization;

namespace HerancaAndPolimorfismoEx2.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() 
        {
        
        }

        public ImportedProduct(string name, double price, double customFee) 
            : base(name, price)
        {
            CustomsFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
            + " $ "
            + Price
            + "Customs Fee: $ "
            + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
        }
    }
}
