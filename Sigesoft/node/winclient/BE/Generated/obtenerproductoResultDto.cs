//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/30 - 12:37:00
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
    public partial class obtenerproductoResultDto
    {
        [DataMember()]
        public String v_IdProductoDetalle { get; set; }

        [DataMember()]
        public String v_Descripcion { get; set; }

        [DataMember()]
        public Nullable<Decimal> d_PrecioVenta { get; set; }

        public obtenerproductoResultDto()
        {
        }

        public obtenerproductoResultDto(String v_IdProductoDetalle, String v_Descripcion, Nullable<Decimal> d_PrecioVenta)
        {
			this.v_IdProductoDetalle = v_IdProductoDetalle;
			this.v_Descripcion = v_Descripcion;
			this.d_PrecioVenta = d_PrecioVenta;
        }
    }
}
