//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/03 - 00:47:58
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
    public partial class liquidacionDto
    {
        [DataMember()]
        public String v_LiquidacionId { get; set; }

        [DataMember()]
        public String v_NroLiquidacion { get; set; }

        [DataMember()]
        public String v_OrganizationId { get; set; }

        [DataMember()]
        public Nullable<Decimal> d_Monto { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_FechaVencimiento { get; set; }

        [DataMember()]
        public String v_NroFactura { get; set; }

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
        public String v_ServiceId { get; set; }

        [DataMember()]
        public organizationDto organization { get; set; }

        public liquidacionDto()
        {
        }

        public liquidacionDto(String v_LiquidacionId, String v_NroLiquidacion, String v_OrganizationId, Nullable<Decimal> d_Monto, Nullable<DateTime> d_FechaVencimiento, String v_NroFactura, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, String v_ServiceId, organizationDto organization)
        {
			this.v_LiquidacionId = v_LiquidacionId;
			this.v_NroLiquidacion = v_NroLiquidacion;
			this.v_OrganizationId = v_OrganizationId;
			this.d_Monto = d_Monto;
			this.d_FechaVencimiento = d_FechaVencimiento;
			this.v_NroFactura = v_NroFactura;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.v_ServiceId = v_ServiceId;
			this.organization = organization;
        }
    }
}
