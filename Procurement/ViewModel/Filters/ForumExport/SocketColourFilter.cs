using POEApi.Model;
using System;
using System.Linq;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class SocketColourFilter : IFilter
    {
        private string colour;
        private int count;
        private string keyword;
        private string help;

        public SocketColourFilter(string colour, int count, string keyword, string help)
        {
            this.colour = colour;
            this.count = count;
            this.keyword = keyword;
            this.help = help;
        }

        public bool CanFormCategory
        {
            get { return true; }
        }

        public string Keyword
        {
            get { return keyword; }
        }

        public string Help
        {
            get { return help; }
        }

        public FilterGroup Group
        {
            get { return FilterGroup.SocketColour; }
        }

        public bool Applicable(Item item)
        {
            var gear = item as Gear;

            if (gear == null)
                return false;

            return gear.Sockets.Where(s => s.Attribute.Equals(colour, StringComparison.OrdinalIgnoreCase)).Count() >= count;
        }
    }

    class OneRedSocket : SocketColourFilter
    {
        public OneRedSocket()
            : base("S", 1, Lang.OneRedSocket, Lang.OneRedSocket)
        { }
    }

    class OneGreenSocket : SocketColourFilter
    {
        public OneGreenSocket()
            : base("D", 1, Lang.OneGreenSocket, Lang.OneGreenSocket)
        { }
    }

    class OneBlueSocket : SocketColourFilter
    {
        public OneBlueSocket()
            : base("I", 1, Lang.OneBlueSocket, Lang.OneBlueSocket)
        { }
    }

    class TwoRedSockets : SocketColourFilter
    {
        public TwoRedSockets()
            : base("S", 2, Lang.TwoRedSocket, Lang.TwoRedSocket)
        { }
    }

    class TwoGreenSockets : SocketColourFilter
    {
        public TwoGreenSockets()
            : base("D", 2, Lang.TwoGreenSocket, Lang.TwoGreenSocket)
        { }
    }

    class TwoBlueSockets : SocketColourFilter
    {
        public TwoBlueSockets()
            : base("I", 2, Lang.TwoBlueSocket, Lang.TwoBlueSocket)
        { }
    }

    class ThreeRedSockets : SocketColourFilter
    {
        public ThreeRedSockets()
            : base("S", 3, Lang.ThreeRedSocket, Lang.ThreeRedSocket)
        { }
    }

    class ThreeGreenSockets : SocketColourFilter
    {
        public ThreeGreenSockets()
            : base("D", 3, Lang.ThreeGreenSocket, Lang.ThreeGreenSocket)
        { }
    }

    class ThreeBlueSockets : SocketColourFilter
    {
        public ThreeBlueSockets()
            : base("I", 3, Lang.ThreeBlueSocket, Lang.ThreeBlueSocket)
        { }
    }

    class FourRedSockets : SocketColourFilter
    {
        public FourRedSockets()
            : base("S", 4, Lang.FourRedSocket, Lang.FourRedSocket)
        { }
    }

    class FourGreenSockets : SocketColourFilter
    {
        public FourGreenSockets()
            : base("D", 4, Lang.FourGreenSocket, Lang.FourGreenSocket)
        { }
    }

    class FourBlueSockets : SocketColourFilter
    {
        public FourBlueSockets()
            : base("I", 4, Lang.FourBlueSocket, Lang.FourBlueSocket)
        { }
    }

    class FiveRedSockets : SocketColourFilter
    {
        public FiveRedSockets()
            : base("S", 5, Lang.FiveRedSocket, Lang.FiveRedSocket)
        { }
    }

    class FiveGreenSockets : SocketColourFilter
    {
        public FiveGreenSockets()
            : base("D", 5, Lang.FiveGreenSocket, Lang.FiveGreenSocket)
        { }
    }

    class FiveBlueSockets : SocketColourFilter
    {
        public FiveBlueSockets()
            : base("I", 5, Lang.FiveBlueSocket, Lang.FiveBlueSocket)
        { }
    }
}
