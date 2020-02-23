﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Prodict
    {
        private int id;
        private string name;
        private decimal price;
        private int stock;
        private DateTime expiry;
        public Prodict(int id,string name,decimal price,int stock,DateTime expiry)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Expiry = expiry;
        }
        public DateTime Expiry
        {
            get { return this.expiry; }
            set { this.expiry = value; }
        }
        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

    }
}
