//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/25 - 15:48:03
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
    public partial class rolcuotadetalleDto
    {
        [DataMember()]
        public String v_RolCuotaDetalleId { get; set; }

        [DataMember()]
        public String v_IdProducto { get; set; }

        [DataMember()]
        public String v_ProductoNombre { get; set; }

        [DataMember()]
        public String v_RolCuotaId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Cuota { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsDeleted { get; set; }

        [DataMember()]
        public Nullable<Int32> i_InsertUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_InsertDate { get; set; }

        [DataMember()]
        public Nullable<Int32> i_UpdateUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_UpdateDate { get; set; }

        [DataMember()]
        public rolcuotaDto rolcuota { get; set; }

        public rolcuotadetalleDto()
        {
        }

        public rolcuotadetalleDto(String v_RolCuotaDetalleId, String v_IdProducto, String v_ProductoNombre, String v_RolCuotaId, Nullable<Int32> i_Cuota, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, rolcuotaDto rolcuota)
        {
			this.v_RolCuotaDetalleId = v_RolCuotaDetalleId;
			this.v_IdProducto = v_IdProducto;
			this.v_ProductoNombre = v_ProductoNombre;
			this.v_RolCuotaId = v_RolCuotaId;
			this.i_Cuota = i_Cuota;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.rolcuota = rolcuota;
        }
    }
}
