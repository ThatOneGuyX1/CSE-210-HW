class Appliance
{
        public string _modelNumber;

        public string _serialNumber;

        public string _uniqueID;

        public string _manufactuer;

        public int _location;

        public float _purchasePrice;

        public void updateLocation()
        {
            Console.WriteLine($"Current Location: {_location}");
            Console.WriteLine("Please select a new location.");
            Console.WriteLine("1: Floor");
            Console.WriteLine("2. Backroom");
            Console.WriteLine("3. Back Storage");
            Console.WriteLine("4. East Storage");
            Console.WriteLine("4. West Storage");
            string temp = Console.ReadLine();
            _location = int.Parse(temp);
            Console.WriteLine($"Current Location: {_location}");
        
        }
}