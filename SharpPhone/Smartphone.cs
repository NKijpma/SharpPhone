using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPhone
{
    internal class Smartphone
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int StorageSizeMb { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }
}
