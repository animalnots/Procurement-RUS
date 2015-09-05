using POEApi.Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace Procurement.ViewModel
{
    public class SetBuyoutViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /*
        private static List<string> orbTypes = new List<string>()
        {
            "Chaos Orb",
            "Vaal Orb",
            "Exalted Orb",
            "Divine Orb",
            "Orb of Fusing",
            "Orb of Alchemy",
            "Orb of Alteration",
            "Gemcutter's Prism",
            "Orb of Chance",
            "Cartographer's Chisel",
            "Orb of Scouring",
            "Orb of Regret",
            "Regal Orb",
            "Jeweller's Orb",
            "Chromatic Orb",
            "Blessed Orb"
        };
        */
        private static List<string> orbTypes = new List<string>()
        {
            "Сфера хаоса",
            "Сфера ваал",
            "Сфера возвышения",
            "Божественная сфера",
            "Сфера соединения",
            "Сфера алхимии",
            "Сфера перемен",
            "Призма камнерезчика",
            "Сфера удачи",
            "Резец картографа",
            "Сфера очищения",
            "Сфера раскаяния",
            "Сфера царей",
            "Сфера златокузнеца",
            "Цветная сфера",
            "Благодатная сфера"
        };

        public List<string> OrbTypes
        {
            get { return orbTypes; }
        }
        private PricingInfo buyoutInfo;
        public PricingInfo BuyoutInfo
        {
            get { return buyoutInfo; }
            set { buyoutInfo = value; }
        }
        private PricingInfo offerInfo;
        public PricingInfo OfferInfo
        {
            get { return offerInfo; }
            set { offerInfo = value; }
        }
        private PricingInfo priceInfo;
        public PricingInfo PriceInfo
        {
            get { return priceInfo; }
            set { priceInfo = value; }
        }
        private PricingInfo bargainInfo;
        public PricingInfo BargainInfo
        {
            get { return bargainInfo; }
            set { bargainInfo = value; }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public SetBuyoutViewModel()
        {
            
            buyoutInfo = new PricingInfo();
            offerInfo = new PricingInfo();
            priceInfo = new PricingInfo();
            bargainInfo = new PricingInfo();
            Notes = string.Empty;
        }

        public void SetBuyoutInfo(ItemTradeInfo info)
        {
            buyoutInfo.Update(info.Buyout);
            offerInfo.Update(info.CurrentOffer);
            priceInfo.Update(info.Price);
            bargainInfo.Update(info.Bargain);
            Notes = info.Notes;
        }        
    }
}
