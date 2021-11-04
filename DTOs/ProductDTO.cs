﻿namespace amir_apparel_demo_api_dotnet_5.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Material { get; set; }

        public decimal Price { get; set; }

        public int AvailableQuantity { get; set; }

        public bool Status { get; set; }
    }
}
