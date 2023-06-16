using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BackendTest;

public class Sale
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string City { get; set; } = "";
    public string Item { get; set; } = "";
    public int Quantity { get; set; } = 0;
    public DateTime Date { get; set; } = DateTime.MinValue;
    public decimal PricePerItem { get; set; } = 0;
}

public class CsvParser
{
    public List<Sale> ParseSales(string fileContent)
    {
        var sales = new List<Sale>();
        
        var mapper = new Dictionary<string, Action<Sale, string>>
        {
            ["First Name"] = (sale, value) => sale.FirstName = value,
            ["Last Name"] = (sale, value) => sale.LastName = value,
            ["City"] = (sale, value) => sale.City = value,
            ["Item"] = (sale, value) => sale.Item = value,
            ["Quantity"] = (sale, value) => sale.Quantity = Convert.ToInt32(value),
            ["Date"] = (sale, value) => sale.Date = DateTime.Parse(value, new CultureInfo("en-GB")),
            ["Price Per Item"] = (sale, value) => sale.PricePerItem = Convert.ToDecimal(value)
        };

        var lines = fileContent
            .Replace("\r", "")
            .Split("\n", StringSplitOptions.RemoveEmptyEntries);

        var columnOrder = lines[0].Split(",");
        
        foreach (var line in lines.Skip(1))
        {
            var sale = new Sale();
            
            var cells = line.Split(",");
            for (var i = 0; i < columnOrder.Length; i++)
            {
                mapper[columnOrder[i]](sale, cells[i]);
            }
            
            sales.Add(sale);
        }

        return sales;
    }
}