namespace C_OOP02
{
    internal class ExpressShipment : Shipment
    {
        decimal extraFee;
        public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost => base.EstimatedCost + ExtraFee;

    }
}
