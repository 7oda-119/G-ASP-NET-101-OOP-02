namespace C_OOP02
{
    internal class InternationalShipment : Shipment
    {
        string destinationCountry;
        decimal customsFee;
        public string DestinationCountry
        {
            get => destinationCountry;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public override decimal EstimatedCost => base.EstimatedCost + CustomsFee;
        public InternationalShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

    }
}
