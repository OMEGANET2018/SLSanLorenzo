//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/09 - 20:45:32
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
    public partial class gerenciatipoexamenResultDto
    {
        [DataMember()]
        public String TipoEso { get; set; }

        [DataMember()]
        public String Empresa { get; set; }

        [DataMember()]
        public String Trabajador { get; set; }

        [DataMember()]
        public Nullable<Double> CostoExamen { get; set; }

        [DataMember()]
        public String Comprobante { get; set; }

        [DataMember()]
        public Nullable<DateTime> FechaFactura { get; set; }

        [DataMember()]
        public String ServiceId { get; set; }

        [DataMember()]
        public Nullable<DateTime> FechaServicio { get; set; }

        [DataMember()]
        public String UsuarioAgenda { get; set; }

        public gerenciatipoexamenResultDto()
        {
        }

        public gerenciatipoexamenResultDto(String tipoEso, String empresa, String trabajador, Nullable<Double> costoExamen, String comprobante, Nullable<DateTime> fechaFactura, String serviceId, Nullable<DateTime> fechaServicio, String usuarioAgenda)
        {
			this.TipoEso = tipoEso;
			this.Empresa = empresa;
			this.Trabajador = trabajador;
			this.CostoExamen = costoExamen;
			this.Comprobante = comprobante;
			this.FechaFactura = fechaFactura;
			this.ServiceId = serviceId;
			this.FechaServicio = fechaServicio;
			this.UsuarioAgenda = usuarioAgenda;
        }
    }
}
