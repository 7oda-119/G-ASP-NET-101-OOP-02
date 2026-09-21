using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP02
{
    internal struct Shipment
    {
        string trackingCode;
        string description;
        double weight;
        double deliveryFee;

        #region Constructors
        //The first constructor receives only trackingCode.
        //• The first constructor uses default values: Description = "Unknown", Weight = 1, DeliveryFee = 50, and a default destination.
        //• The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
        //• Each constructor must initialize the object with valid data.
        public Shipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                throw new ArgumentNullException(nameof(trackingCode), "TrackingCode cannot be null or empty");

            this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("New York", "5th Avenue", 100);
        }

        public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                throw new ArgumentNullException(nameof(trackingCode), "TrackingCode cannot be null or empty");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentNullException(nameof(description), "Description cannot be null or empty");
            if (weight < 0)
                throw new ArgumentOutOfRangeException(nameof(weight), "Weight must be greater than 0");
            if (deliveryFee < 0)
                throw new ArgumentOutOfRangeException(nameof(deliveryFee), "DeliveryFee must be greater than 0");

            this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            Destination = destination;
        }
        #endregion


        #region Properities
        // Automatic Read-Write Properity
        public DeliveryAddress Destination { get; set; }

        // Read only properity
        public string TrackingCode
        {
            get => trackingCode;
        }

        // Read-Write Properity
        public string Description
        {
            get => description;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        // Read-Write Properity
        public double Weight
        {
            get => weight;
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        // Read-private set properity  ==> can be accesed only in the same class
        public double DeliveryFee
        {
            get => deliveryFee;
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        // Calculated Properity
        public double EstimatedCost
        {
            get => deliveryFee + (weight * 5);
        }

        #endregion

    }
}
