﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class TbEmpleadosPorActividad
    {
        public int EmacId { get; set; }
        public int EmplId { get; set; }
        public int ActiId { get; set; }

        public virtual TbActividades Acti { get; set; }
        public virtual TbEmpleados Empl { get; set; }
    }
}