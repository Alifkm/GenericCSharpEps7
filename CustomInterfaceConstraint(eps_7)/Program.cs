﻿namespace CustomInterfaceConstraint_eps_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> repository = new Repository<Product>();
            var product = new Product();
            product.Id = 1;
            repository.Add(product);

        }
    }

    class Product : IEntity
    {
        public int Id { get; set; }
    }
}
