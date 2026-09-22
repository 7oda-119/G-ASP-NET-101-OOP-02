using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP02
{
    internal class DeliveryCenter
    {
        Shipment[] shipments;

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }

        // Add an integer indexer
        public Shipment this [int index]
        {
            get
            {
                for(int i = 0; i < shipments.Length; i++)
                {
                    if (index >= 0 && index < shipments.Length)
                        return shipments[index];
                }
                return default;
            }
            set
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (index >= 0 && index < shipments.Length)
                        shipments[index] = value;
                }
            }
        }

        // Add a string indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return default;
            }
        }

        // Add Method named AddShipment
        public bool AddShipment(Shipment shipment)
        {
            for(int i = 0; i < shipments.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(shipments[i].TrackingCode))  //The condition (shipments[i] == null) =>compiler error becaue shipment is a struct can;t be null
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
    }
}
