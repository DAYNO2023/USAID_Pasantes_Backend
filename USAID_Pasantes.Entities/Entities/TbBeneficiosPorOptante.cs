﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbBeneficiosPorOptante
    {
        public int bepe_Id { get; set; }
        public int bene_Id { get; set; }
        public int opta_Id { get; set; }

        public virtual tbBeneficios bene { get; set; }
        public virtual tbOptantes opta { get; set; }
    }
}