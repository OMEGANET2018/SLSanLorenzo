//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/30 - 12:37:14
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
    public partial class medicoDto
    {
        [DataMember()]
        public String v_MedicoId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_SystemUserId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_MasterServiceTypeId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_MasterServiceId { get; set; }

        [DataMember()]
        public Nullable<Decimal> r_Clinica { get; set; }

        [DataMember()]
        public Nullable<Decimal> r_Medico { get; set; }

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

        public medicoDto()
        {
        }

        public medicoDto(String v_MedicoId, Nullable<Int32> i_SystemUserId, Nullable<Int32> i_MasterServiceTypeId, Nullable<Int32> i_MasterServiceId, Nullable<Decimal> r_Clinica, Nullable<Decimal> r_Medico, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate)
        {
			this.v_MedicoId = v_MedicoId;
			this.i_SystemUserId = i_SystemUserId;
			this.i_MasterServiceTypeId = i_MasterServiceTypeId;
			this.i_MasterServiceId = i_MasterServiceId;
			this.r_Clinica = r_Clinica;
			this.r_Medico = r_Medico;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
        }
    }
}
