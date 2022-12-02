// Created by: Claire Bedrossian
// Created on: Nov 2022
//
// This program allows you to order coffee.
using System;
class Program
{
    public static void Main(string[] args)
    
        System.Random random = new System.Random();
        // This function accepts user input
        double sizeCost;
        double typeCost;
        double subtotal;
        double finalCost;
        double finalCostDiscount;
    
        Console.WriteLine(" Order your coffee below. There is a twenty five percent discount for orders $ 3.50 and above...");
        Console.WriteLine("");
        Console.WriteLine("Coffee Sizes: Large $ 3.50, Medium $ 2.75, Small $ 1.50 ");
        Console.WriteLine("");
        Console.WriteLine("Coffee Types: Decaf $ 1.00, Iced $ 1.00, Regular $ 0.00 ");
        Console.WriteLine("");
        Console.Write("Enter the cost of the coffee size: ");
        sizeCost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Enter the cost of the type of coffee: ");
        typeCost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
      
        subtotal = sizeCost + typeCost;
        finalCost = subtotal + (subtotal * 0.13);
        finalCostDiscount = subtotal + (subtotal * 0.13) - (subtotal * 0.25);
        if (subtotal >= 3.50)
        {
        Console.WriteLine("Your subtotal is: " + subtotal.ToString("0.00") + ". ");
          Console.WriteLine("");
          Console.WriteLine("HST: 13% ");
          Console.WriteLine("");
          Console.WriteLine("Your final cost is: " + finalCostDiscount.ToString("0.00") + ". ");
          } 
    else
       {
          Console.WriteLine("Your subtotal is: " + subtotal.ToString("0.00") + ". ");
          Console.WriteLine("");
          Console.WriteLine("HST: 13%");
          Console.WriteLine("");
          Console.WriteLine("Discount: 25%");
          Console.WriteLine("");
          Console.WriteLine("Your final cost is: " + finalCost.ToString("0.00") + ". ");        }
          Console.WriteLine("");
          Console.WriteLine("\nDone.");
    }
}