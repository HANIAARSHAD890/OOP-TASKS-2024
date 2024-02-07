using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class book
    {
        public string title;
        public string author;
        public int publicationYear;
        public double price;
        public int quantityinStock;
               int bookcount = 0;
        public book(string title1, string author1,int  publicationYear1, double price1, int quantityinStock1)
        {
            this.title = title1;
            this.author = author1;
            this.publicationYear = publicationYear1;
            this.price = price1;
            this.quantityinStock = quantityinStock1;

            bookcount++;
        }
        public string Author()
        {
            
                
            return author;
        }
        public string Title()
        {
            return title; 
                 
       

        }
        public string PublicationYear()
        {


            return $"publicationYear: {publicationYear}";
        }
        public string QuanttyinStock()
        {


            return $"quantityinstock: {quantityinStock}";
        }
        public double Price()
        {


            return price;
        }
        public double noOfBooks()
        {


            return bookcount;
        }

    }
}
