//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/24 - 17:46:10
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
    public partial class reportegerencialResultDto
    {
        [DataMember()]
        public String Mes { get; set; }

        [DataMember()]
        public Nullable<DateTime> Fecha { get; set; }

        [DataMember()]
        public Nullable<Int32> TipoDocumento { get; set; }

        [DataMember()]
        public Nullable<Decimal> Ingreso { get; set; }

        [DataMember()]
        public Nullable<Decimal> Egreso { get; set; }

        [DataMember()]
        public Nullable<Decimal> Saldo { get; set; }

        public reportegerencialResultDto()
        {
        }

        public reportegerencialResultDto(String mes, Nullable<DateTime> fecha, Nullable<Int32> tipoDocumento, Nullable<Decimal> ingreso, Nullable<Decimal> egreso, Nullable<Decimal> saldo)
        {
			this.Mes = mes;
			this.Fecha = fecha;
			this.TipoDocumento = tipoDocumento;
			this.Ingreso = ingreso;
			this.Egreso = egreso;
			this.Saldo = saldo;
        }
    }
}
