using System;

namespace Decorator.Repositories
{
    public class Repo : IRepo
    {
        public OrderDto Query()
        {
            return new OrderDto
            {
                ErrorCode = 0,
                ErrorMessage = "No Error",
                ExchangeRate = new decimal(30.2),
                Price = 5,
                TotalTwd = 0
            };
        }
    }

    public class OrderDto
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal Price { get; set; }
        public decimal TotalTwd { get; set; }
    }
}