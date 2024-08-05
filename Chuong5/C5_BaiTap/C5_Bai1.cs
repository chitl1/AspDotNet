using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_BaiTap
{
    internal class C5_Bai1
    {
        static public void Bai1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Số lượng món hàng trong kho
            const int numberOfItems = 5;

            // Tạo mảng lưu trữ các món hàng
            Item[] inventory = new Item[numberOfItems];
            // Nhập thông tin cho từng món hàng
            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine($"Nhập thông tin cho món hàng {i + 1}:");
                Console.Write("Mã số: ");
                string code = Console.ReadLine();

                Console.Write("Tên hàng: ");
                string name = Console.ReadLine();

                Console.Write("Giá cả (đồng): ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Số lượng đang có: ");
                int quantity = int.Parse(Console.ReadLine());

                // Tạo đối tượng món hàng và lưu vào mảng
                inventory[i] = new Item(code, name, price, quantity);
            }
            // Hiển thị thông tin và tổng giá trị của từng món hàng
            double totalInventoryValue = 0;
            Console.WriteLine("\nDanh sách món hàng và tổng giá trị của từng món:");
            foreach (var item in inventory)
            {
                double itemTotalValue = item.CalculateTotalValue();
                Console.WriteLine($"{item.Name}: {itemTotalValue:F2} đồng");
                totalInventoryValue += itemTotalValue;
            }
            // Hiển thị tổng giá trị của kho hàng
            Console.WriteLine($"\nTổng giá trị của kho hàng: {totalInventoryValue:F2} đồng");
        }
        public class Item
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Item(string code, string name, double price, int quantity)
            {
                Code = code;
                Name = name;
                Price = price;
                Quantity = quantity;
            }
            public double CalculateTotalValue()
            {
                return Price * Quantity;
            }
        }
    }
}
