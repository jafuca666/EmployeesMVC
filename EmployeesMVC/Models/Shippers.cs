//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeesMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shippers
    {
        public Shippers()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<Orders> Orders { get; set; }
    }
}