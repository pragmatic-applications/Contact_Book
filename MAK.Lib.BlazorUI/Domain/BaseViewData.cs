namespace Domain
{
    public class BaseViewData
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ShippingCost { get; set; }
        public int TotalCost { get; set; }
    }
}

