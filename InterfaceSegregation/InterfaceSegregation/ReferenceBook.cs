using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class ReferenceBook
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
            throw new NotImplementedException();
        }

        public void CheckIN() 
        {
            throw new NotImplementedException();
        }
    }
}
