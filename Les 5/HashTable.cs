using System;
using System.IO;

namespace Les5
{
    class HashTable
    {
        private double[] array;

        public HashTable(int size)
        {
            array = new double[size];
        }

        //http://www.asciitabel.be/
        private int HashFunction(string word)
        {
            int som = 0;
            foreach (char c in word)
            {
                som += ((int)c)-64;
            }
            return som % array.Length;
        }

        public void AddProduct(string product, double price)
        {
            int index = HashFunction(product);
            array[index] = price;
        }

        public double GetPrice(string product)
        {
            int index = HashFunction(product);
            return array[index];
        }

    }
}