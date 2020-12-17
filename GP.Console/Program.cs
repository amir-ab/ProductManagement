using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Partie 2: Type valeur / Type référence 
            //Provider P1 = new Provider() { ConfirmPassword = "123", Password = "123" };

            //Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
            //System.Console.WriteLine("{" + P1.Password + ";" + P1.ConfirmPassword + ";" + P1.IsApproved + "}");
            //System.Console.ReadKey();

            //Provider.SetIsApproved(P1);
            //System.Console.WriteLine("{" + P1.Password + ";" + P1.ConfirmPassword + ";" + P1.IsApproved + "}");
            //System.Console.ReadKey();
            #endregion

            #region Partie 3 Encapsulation

            //Provider P2 = new Provider() { ConfirmPassword = "123", Password = "123" };
            //System.Console.ReadKey();

            #endregion

            #region Partie 5: Collections / Itérations / Structures conditionnelles
            ////Scénario de test
            ////Categories / Providers    CAT1              CAT2        CAT3        NULL
            ////PROV1                     PROD1, PROD2                  PROD3
            ////PROV2                     PROD1             PROD5
            ////PROV3                     PROD1                                     PROD4
            ////PROV4                                                   PROD6       PROD4
            ////PROV5                                                   PROD6       PROD4

            Category cat1 = new Category() { Name = "CAT1" };
            Category cat2 = new Category() { Name = "CAT2" };
            Category cat3 = new Category() { Name = "CAT3" };

            Provider prov1 = new Provider() { UserName = "PROV1" };
            Provider prov2 = new Provider() { UserName = "PROV2" };
            Provider prov3 = new Provider() { UserName = "PROV3" };
            Provider prov4 = new Provider() { UserName = "PROV4" };
            Provider prov5 = new Provider() { UserName = "PROV5" };

            Product prod1 = new Product() { Name = "PROD1", MyCategory = cat1, Providers = new List<Provider>() { prov1, prov2, prov3 } };
            Product prod2 = new Product() { Name = "PROD2", MyCategory = cat1, Providers = new List<Provider>() { prov1 } };
            Product prod3 = new Product() { Name = "PROD3", MyCategory = cat3, Providers = new List<Provider>() { prov1 } };
            Product prod4 = new Product() { Name = "PROD4", Providers = new List<Provider>() { prov3, prov4, prov5 } };
            Product prod5 = new Product() { Name = "PROD5", MyCategory = cat2, Providers = new List<Provider>() { prov2 } };
            Product prod6 = new Product() { Name = "PROD6", MyCategory = cat3, Providers = new List<Provider>() { prov4, prov5 } };

            cat1.Products = new List<Product>() { prod1, prod2 };
            cat2.Products = new List<Product>() { prod5 };
            cat3.Products = new List<Product>() { prod3, prod6 };
            prov1.Products = new List<Product>() { prod1, prod2, prod3 };
            prov2.Products = new List<Product>() { prod1, prod5 };
            prov3.Products = new List<Product>() { prod1 };
            prov4.Products = new List<Product>() { prod4, prod6 };
            prov5.Products = new List<Product>() { prod4, prod6 };

            System.Console.WriteLine("détails des providers");
            prov1.GetDetails();
            System.Console.WriteLine("-------------------");
            prov2.GetDetails();
            System.Console.WriteLine("-------------------");
            prov3.GetDetails();
            System.Console.ReadKey();

            ////Tester les autres méthodes
            ////...
            ////...
            #endregion
        }
    }
}
