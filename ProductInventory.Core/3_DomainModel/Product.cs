namespace ProductInventory.Core.DomainModel
{
    /*
     * Vi velger å ha kun én klasse Product, som skal
     * matche to ulike behov:
     *
     * 1. DTO som matcher databaseraden
     * 2. fungere som domenemodell (lite relevant her)
     */

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string ProductCode { get; set; } = "";

        public int StockCount { get; set; }
    }
}
