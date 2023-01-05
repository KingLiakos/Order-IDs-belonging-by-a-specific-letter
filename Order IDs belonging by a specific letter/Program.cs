using System;

namespace Order_IDs_belonging_by_a_specific_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] orderID = new string[8] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };



            foreach (string ID in orderID)

            {
                if (ID.StartsWith("B"))

                {
                    Console.WriteLine(ID);
                }
            }

        }
    }
}
