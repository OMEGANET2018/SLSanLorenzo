//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/03/03 - 14:33:30
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
    public partial class vigilanciaserviceDto
    {
        [DataMember()]
        public String v_VigilanciaServiceId { get; set; }

        [DataMember()]
        public String v_VigilanciaId { get; set; }

        [DataMember()]
        public String v_ServiceId { get; set; }

        [DataMember()]
        public String v_Commentary { get; set; }

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
        public vigilanciaDto vigilancia { get; set; }

        [DataMember()]
        public serviceDto service { get; set; }

        public vigilanciaserviceDto()
        {
        }

        public vigilanciaserviceDto(String v_VigilanciaServiceId, String v_VigilanciaId, String v_ServiceId, String v_Commentary, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, vigilanciaDto vigilancia, serviceDto service)
        {
			this.v_VigilanciaServiceId = v_VigilanciaServiceId;
			this.v_VigilanciaId = v_VigilanciaId;
			this.v_ServiceId = v_ServiceId;
			this.v_Commentary = v_Commentary;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.vigilancia = vigilancia;
			this.service = service;
        }
    }
}