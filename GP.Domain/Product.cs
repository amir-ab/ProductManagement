using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Product:Concept
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Category MyCategory { get; set; }
        public List<Provider> Providers { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine( "ProductId: " + ProductId + " ; Name : " + Name + "DateProd: " + DateProd + " ; Description: " + Description + " ; Price : " + Price + " ; Quantity:" + Quantity);
        }

        #region Partie 4: Polymorphisme
        public virtual void GetMyType() 
        {
            Console.WriteLine("UNKNOWN");
        }
        #endregion
    }
}
