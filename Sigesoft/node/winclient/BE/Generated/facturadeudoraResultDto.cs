//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/30 - 10:14:39
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sigesoft.Node.WinClient.BE
{
    [DataContract()]
    public partial class facturadeudoraResultDto
    {
        [DataMember()]
        public Nullable<DateTime> FechaCreacion { get; set; }

        [DataMember()]
        public Nullable<DateTime> FechaVencimiento { get; set; }

        [DataMember()]
        public String v_IdVenta { get; set; }

        [DataMember()]
        public Nullable<Decimal> NetoXCobrar { get; set; }

        [DataMember()]
        public String NroComprobante { get; set; }

        [DataMember()]
        public Nullable<Decimal> TotalPagado { get; set; }

        [DataMember()]
        public String Condicion { get; set; }

        public facturadeudoraResultDto()
        {
        }

        public facturadeudoraResultDto(Nullable<DateTime> fechaCreacion, Nullable<DateTime> fechaVencimiento, String v_IdVenta, Nullable<Decimal> netoXCobrar, String nroComprobante, Nullable<Decimal> totalPagado, String condicion)
        {
			this.FechaCreacion = fechaCreacion;
			this.FechaVencimiento = fechaVencimiento;
			this.v_IdVenta = v_IdVenta;
			this.NetoXCobrar = netoXCobrar;
			this.NroComprobante = nroComprobante;
			this.TotalPagado = totalPagado;
			this.Condicion = condicion;
        }
    }
}
