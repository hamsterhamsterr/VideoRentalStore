using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Payment
    {
        private const int FEE_DAY = 2;

        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public double? Discount { get; set; }
        [Required]
        public Rental Rental { get; set; }
        public int RentalId { get; set; }

        public static double GetTotalPrice(Customer customer, Rental rental, double? discount)
        {
            var days = (rental.DateReturned - rental.DateRented).Value.Days;
            var price = days * FEE_DAY * (1 - (customer.MembershipType.DiscountRate / (double)100));

            if (!discount.HasValue)
                return price;
            else
                return price * discount.Value;
        }
    }
}