﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbCarreraPorFacultadPorRegional
    {
        public tbCarreraPorFacultadPorRegional()
        {
            tbOptantes = new HashSet<tbOptantes>();
        }

        public int cafr_Id { get; set; }
        public int fare_Id { get; set; }
        public int carr_Id { get; set; }

        public virtual tbCarreras carr { get; set; }
        public virtual tbFacultadPorRegional fare { get; set; }
        public virtual ICollection<tbOptantes> tbOptantes { get; set; }
    }
}