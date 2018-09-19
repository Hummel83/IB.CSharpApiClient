using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class TickByTickAllLastMessage
    {
        public TickByTickAllLastMessage(int reqId, int tickType, long time, double price, long size,
            TickAttrib attribs, string exchange, string specialConditions)
        {
            ReqId = reqId;
            TickType = tickType;
            Time = time;
            Price = price;
            Size = size;
            Attribs = attribs;
            Exchange = exchange;
            SpecialConditions = specialConditions;
        }

        public int ReqId { get; }
        public int TickType { get; }
        public long Time { get; }
        public double Price { get; }
        public long Size { get; }
        public TickAttrib Attribs { get; }
        public string Exchange { get; }
        public string SpecialConditions { get; }

        public override string ToString()
        {
            return $"{nameof(Attribs)}: {Attribs}, {nameof(Exchange)}: {Exchange}, {nameof(Price)}: {Price}, {nameof(ReqId)}: {ReqId}, {nameof(Size)}: {Size}, {nameof(SpecialConditions)}: {SpecialConditions}, {nameof(TickType)}: {TickType}, {nameof(Time)}: {Time}";
        }
    }
}