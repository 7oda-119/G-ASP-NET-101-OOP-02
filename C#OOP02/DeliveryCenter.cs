using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP02
{
    internal class DeliveryCenter
    {
        Shipment[] shipments;
        public string CenterName { get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
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
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
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
                if (shipments[i] == null)  
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        //Remove the shipment with tracking code
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&  shipments[i] != null &&shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            bool hasShipment = false;
            for(int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    Console.WriteLine($"== Shipment number {i+1} ==");
                    shipments[i].PrintShipment();
                    hasShipment = true;
                }
            }
            if(!hasShipment)
                Console.WriteLine("No shipments stored in this center.");
        }
    }
}
