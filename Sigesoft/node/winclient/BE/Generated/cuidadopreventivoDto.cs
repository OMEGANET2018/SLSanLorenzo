//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/24 - 08:36:07
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
    public partial class cuidadopreventivoDto
    {
        [DataMember()]
        public String v_CuidadoPreventivoId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public DateTime d_ServiceDate { get; set; }

        [DataMember()]
        public Int32 i_GrupoId { get; set; }

        [DataMember()]
        public Int32 i_ParametroId { get; set; }

        [DataMember()]
        public Int32 i_Valor { get; set; }

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

        public cuidadopreventivoDto()
        {
        }

        public cuidadopreventivoDto(String v_CuidadoPreventivoId, String v_PersonId, DateTime d_ServiceDate, Int32 i_GrupoId, Int32 i_ParametroId, Int32 i_Valor, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate)
        {
			this.v_CuidadoPreventivoId = v_CuidadoPreventivoId;
			this.v_PersonId = v_PersonId;
			this.d_ServiceDate = d_ServiceDate;
			this.i_GrupoId = i_GrupoId;
			this.i_ParametroId = i_ParametroId;
			this.i_Valor = i_Valor;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
        }
    }
}
