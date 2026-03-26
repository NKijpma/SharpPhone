namespace SharpPhone
{
    public class SmartPhone
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int StorageSizeMb { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public SmartPhone(int id, string? brand, string? model, int storageSizeMb, decimal price, int stock)
        {
            Id = id;
            Brand = brand;
            Model = model;
            StorageSizeMb = storageSizeMb;
            Price = price;
            Stock = stock;
        }

        public SmartPhone() { }

        public override string ToString()
        {
            return $"{Brand} {Model}";
        }

    }
}
