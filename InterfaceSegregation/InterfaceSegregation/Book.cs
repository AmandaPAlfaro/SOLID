using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Book
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CheckoutDurationInDays { get; set; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

        public void checkout(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public void CheckIN()
        {
            Borrower = "";
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckoutDurationInDays);
        }
    }
}
