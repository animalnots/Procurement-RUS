namespace POEApi.Model
{
    public class ItemTradeInfo
    {
        public string Buyout { get; set; }
        public string Price { get; set; }
        public string CurrentOffer { get; set; }
        public string Bargain { get; set; }
        public string Notes { get; set; }
        public bool IsEmpty
        {
            get { return string.IsNullOrEmpty(Buyout) && string.IsNullOrEmpty(Price) && string.IsNullOrEmpty(CurrentOffer) && string.IsNullOrEmpty(Bargain) && string.IsNullOrEmpty(Notes); }
        }

        public ItemTradeInfo()
        { }

        public ItemTradeInfo(string buyout, string price, string currentOffer, string bargain, string notes)
        {
            this.Buyout = buyout;
            this.Price = price;
            this.CurrentOffer = currentOffer;
            this.Bargain = bargain;
            this.Notes = notes;
        }
    }
}
