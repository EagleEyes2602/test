//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class Book
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Nullable<int> Date { get; set; }
        public Nullable<double> Price { get; set; }
        public string Image { get; set; }
        [AllowHtml]
        public string Description { get; set; }
    
        public virtual Publisher Publisher { get; set; }
    }
}
