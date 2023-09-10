using System;
using System.ComponentModel.DataAnnotations.Schema;


public class Product
{
            public string IName { get; set; }
            public string Detail { get; set; }
            public decimal Price { get; set; }
            public string Image { get; set; }
            public int Qnt { get; set; }
            public int AQnt { get; set; }
            public int SQnt { get; set; }
            public string CName { get; set; }
            public DateTime EntryDate { get; set; }
            public string Image1 { get; set; }
            public string Image2 { get; set; }
            public string Size { get; set; }
     
            public Product() { }
}
