using System;

namespace Task00
{
    class Address
    {
        //#region Fields
        //int index;
        //string country, city, street, house, apartment;
        //#endregion

        #region Properties
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        #endregion

        public void Print()
        {
            Console.WriteLine("Index: " + this.Index);
            Console.WriteLine("Country: " + this.Country);
            Console.WriteLine("City: " + this.City);
            Console.WriteLine(this.Street + " street, " + this.House + ", apartment " + this.Apartment);
        }
    }
}
