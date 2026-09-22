namespace C_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP01
            #region Question01
            ////Create one DeliveryAddress value, copy it into a second variable, modify the copy,
            ////and print both values to prove that the original did not change.

            //DeliveryAddress address1 = new DeliveryAddress("New York", "5th Avenue", 100);
            //DeliveryAddress address2 = address1;
            //address2.street = "Madison Avenue";
            //address2.city = "Los Angeles";
            //address2.buildingNumber = 200;
            //Console.WriteLine($"Address1: {address1.GetFullAddress()}");
            //Console.WriteLine($"Address2: {address2.GetFullAddress()}");
            #endregion

            #region Question06

            ////a. Create a DeliveryCenter.
            //DeliveryCenter deliveryCenter = new DeliveryCenter();

            ////b. Read data for three shipments from the user.
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter shipment {i+1} Data");

            //    Console.Write("Tracking code: ");
            //    string trackingCode = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string description = Console.ReadLine();

            //    double weight;
            //    while (true)
            //    {
            //        Console.Write("Weight: ");
            //        bool isParsed = double.TryParse(Console.ReadLine(), out weight);
            //        if (isParsed)
            //            break;
            //    }

            //    double deliveryFee;
            //    while (true)
            //    {
            //        Console.Write("Delivery fee: ");
            //        bool isParsed = double.TryParse(Console.ReadLine(), out deliveryFee);
            //        if (isParsed)
            //            break;
            //    }

            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    int buildingNumber;
            //    while (true)
            //    {
            //        Console.Write("Building number: ");
            //        bool isParsed = int.TryParse(Console.ReadLine(), out buildingNumber);
            //        if (isParsed)
            //            break;
            //    }
            //    Console.WriteLine("----------------");
            //    DeliveryAddress destination = new DeliveryAddress(city, street, buildingNumber);

            //    //c. Create each Shipment and add it to the DeliveryCenter.
            //    Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, destination);
            //    deliveryCenter.AddShipment(shipment);
            //}
            //Console.WriteLine("Shipments added successfully");

            ////d. Print the three shipments using the integer indexer.
            //Console.WriteLine("===== All Shipments =====");
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Shipment {i+1}: ");
            //    Shipment shipment = deliveryCenter[i];
            //    shipment.PrintShipment();
            //    Console.WriteLine("----------------");
            //}

            ////e. Ask the user to enter a tracking code.
            //Console.Write("\nEnter a tracking code to search: ");
            //string searchCode = Console.ReadLine();

            ////f. Search for the shipment using the string indexer.
            //Shipment found = deliveryCenter[searchCode];

            ////g. Print the shipment if found; otherwise print:Shipment not found.
            //if (!string.IsNullOrWhiteSpace(found.TrackingCode));
            //    found.PrintShipment();
            //Console.WriteLine("Shipment not found");

            ////h. Demonstrate the DeliveryAddress struct copy behavior.
            //Console.WriteLine("--- Demonstrate the DeliveryAddress struct copy behavior ---");
            //DeliveryAddress deliveryAddress01 = new DeliveryAddress("Cairo", "Tahrir Street", 10);
            //DeliveryAddress deliveryAddress02 = deliveryAddress01;  // Copy by value
            //deliveryAddress02.city = "Alexandria";   // not change in deliveryAddress01
            //Console.WriteLine(deliveryAddress01.city);
            //Console.WriteLine(deliveryAddress02.city);

            #endregion
            #endregion

            #region OOP02
            #region Theoretical Questions
            #region Question01
            //a) What is the difference between a class and a struct?
            /*    == Key difference ==       == Class ==                       == Struct ==
             *    Type                       Reference type                    Value Type
             *    Memory location            Heap                              Stack(or inline in heap if field of a class)
             *    Assignment behaviour       Copies references                 Copies value
             *    Inheritane                 Support inheritane                Doens't support inheritance
             *    Default value              Null                              Zero-initialized instance
             *    Can be null                Yes                               No (unless nullable)
             *    Best for                   Large data, Shared state          Small and sinple data
             */

            //b) Why are classes more suitable than structs for large applications?
            /* Answer: 1. Classes are stored on the heap, managed by the garbage collector, which is ideal for long‑lived, complex objects.
             *         while Structs are stored on the stack, in large structs can cause performance issues (stack over flow)
             *         2. Class support inheritance this mean wriing shared logic once in the base class.
            */
            #endregion

            #region Question02
            /* public class Shipment
             * {
             *      public string TracingCode { get; set; }
             * }
             * public class ExpressShipment : Shipment
             * {
             * public decimal ExtraFee { get; set }
             * }
             * a) Which class is the parent class? Answer: Parent class is Shipment
             * b) Which class is the child class?  Answer: Child class is ExpressShipment
             * c) What members are inherited by ExpressShipment? Answer: Members are inherited is TracingCode properity
             * d) Why is inheritance better than duplicating the same code in multiple classes?
             *    Answer: Easier Maintenance:
                            If you need to fix or improve shared functionality, you do it once in the parent class.
                            All child classes instantly benefit from the change, reducing bugs and saving time.
                          Code Reusability:
                            When a child class inherits from a parent class, it automatically gains access to all the parent’s fields and methods.
                            This means you don’t have to rewrite the same logic in every class — you just reuse it.
            */
            #endregion
            #endregion

            #region Question05

            string trackingCode, description, city, street, destinationCountry;
            double weight, deliveryFee ;
            decimal extraFee, customsFee ;
            int buildingNumber;

            #region DeliveryCenter
            // Create a DeliveryCenter and read the center name from the user.
            Console.Write("Enter Delivery Center name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter deliveryCenter = new DeliveryCenter(centerName); 
            #endregion

            //Create one StandardShipment and read the data from user.
            #region StandardShipment
            Console.WriteLine("===== Enter StandardShipment data =====");

            trackingCode = ReadString("Tracking code: ");

            description = ReadString("Description: ");

            weight = ReadDouble("Weight: ");
            
            deliveryFee = ReadDouble("Delivery fee: ");
            
            city = ReadString("City: ");

            street = ReadString("Street: ");

            buildingNumber = ReadInt("Building number: ");
            
            DeliveryAddress sAddress = new DeliveryAddress(city, street, buildingNumber);
            Shipment standardShipment = new StandardShipment(trackingCode, description, weight, deliveryFee, sAddress); 
            #endregion


            //Create one ExpressShipment and read the data from user.
            #region ExpressShipment

            Console.WriteLine("===== Enter ExpressShipment data =====");

            trackingCode = ReadString("Tracking code: ");

            description = ReadString("Description: ");

            weight = ReadDouble("Weight: ");

            deliveryFee = ReadDouble("Delivery fee: ");

            city = ReadString("City: ");

            street = ReadString("Street: ");

            buildingNumber = ReadInt("Building number: ");

            DeliveryAddress eAddress = new DeliveryAddress(city, street, buildingNumber);

            extraFee = ReadDecimal("Extra Fee: ");
            
            Shipment expressShipment = new ExpressShipment(trackingCode, description, weight, deliveryFee, eAddress, extraFee); 
            #endregion


            //Create one InternationalShipment and read the data from user.
            #region InternationalShipment
            Console.WriteLine("===== Enter InternationalShipment data =====");

            trackingCode = ReadString("Tracking code: ");

            description = ReadString("Description: ");

            weight = ReadDouble("Weight: ");

            deliveryFee = ReadDouble("Delivery fee: ");

            city = ReadString("City: ");

            street = ReadString("Street: ");

            buildingNumber = ReadInt("Building number: ");
            DeliveryAddress iAddress = new DeliveryAddress(city, street, buildingNumber);

            destinationCountry = ReadString("Destination country: ");

            customsFee = ReadDecimal("Customs fee: ");

            Shipment internationalShipment = new InternationalShipment(trackingCode, description, weight, deliveryFee, iAddress, destinationCountry, customsFee);

            #endregion

            //Add the shipments to the delivery center.
            #region Add all shipments
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);
            #endregion

            //Print all shipments.
            #region Print all shipments
            Console.WriteLine("======== All Shipments ========");
            deliveryCenter.PrintAllShipments();
            #endregion

            Console.WriteLine("***************************************");

            //Search for a shipment using the existing tracking code indexer
            #region Search for shipment
            string searchCode = ReadString("Enter tracking code to search: ");
            Shipment found = deliveryCenter[searchCode];
            if (found != null)
                found.PrintShipment();
            else
                Console.WriteLine("Shipment not found.");
            #endregion

            Console.WriteLine("***************************************");

            //Remove one shipment using its tracking code.
            #region Remove shipment
            string removeCode = ReadString("Enter tracking code to remove: ");
            if(deliveryCenter.RemoveShipment(removeCode))
                Console.WriteLine("The shipment is deleted successfully");
            else
                Console.WriteLine("The shipment is not existed");
            #endregion

            Console.WriteLine("***************************************");

            //Print the remaining shipments.
            #region Print the shipments
            Console.WriteLine("======== Remaining Shipments ========");
            deliveryCenter.PrintAllShipments(); 
            #endregion

            #endregion

            #endregion
        }

        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (decimal.TryParse(Console.ReadLine(), out decimal value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        static string ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
