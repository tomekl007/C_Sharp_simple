﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// The easiest way to declare an event is to put the event keyword in front of a delegate member.
// Code within the containing type has full access and can treat the event as a delegate.
// Code outside of the containing type can only perform += and -= operations on the event.

namespace Events
{

    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

    public class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol) { this.symbol = symbol; }

        public event PriceChangedHandler PriceChanged;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;			// Exit if nothing has changed
                decimal oldPrice = price;
                price = value;
                if (PriceChanged != null)			// If invocation list not empty,
                    PriceChanged(oldPrice, price);	// fire event.
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var stock = new Stock("MSFT");
            stock.PriceChanged += ReportPriceChange;
          
            stock.Price = 123;
            stock.Price = 456;
        }

        static void ReportPriceChange(decimal oldPrice, decimal newPrice)
        {
            Console.WriteLine("Price changed from " + oldPrice + " to " + newPrice);
        }
    }
}