using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            ConeComparer coneCost = new ConeComparer();
            availableCones.Sort(coneCost);
            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            Console.WriteLine("Sorted by name:");
            foreach (Flavor i in availableFlavors) {
                Console.WriteLine(i.Name + ": $" + i.Cost);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Sorted by cost:");
            foreach (Cone i in availableCones)
            {
                Console.WriteLine(i.Name + ": $" + i.Cost);
            }
        }
    }
}
