//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/01/04 - 09:58:54
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
    public partial class protocolcomponentDto
    {
        [DataMember()]
        public String v_ProtocolComponentId { get; set; }

        [DataMember()]
        public String v_ProtocolId { get; set; }

        [DataMember()]
        public String v_ComponentId { get; set; }

        [DataMember()]
        public Nullable<Single> r_Price { get; set; }

        [DataMember()]
        public Nullable<Int32> i_OperatorId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Age { get; set; }

        [DataMember()]
        public Nullable<Int32> i_GenderId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_GrupoEtarioId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsConditionalId { get; set; }

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
        public Nullable<Int32> i_IsConditionalIMC { get; set; }

        [DataMember()]
        public Nullable<Decimal> r_Imc { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsAdditional { get; set; }

        [DataMember()]
        public componentDto component { get; set; }

        [DataMember()]
        public protocolDto protocol { get; set; }

        public protocolcomponentDto()
        {
        }

        public protocolcomponentDto(String v_ProtocolComponentId, String v_ProtocolId, String v_ComponentId, Nullable<Single> r_Price, Nullable<Int32> i_OperatorId, Nullable<Int32> i_Age, Nullable<Int32> i_GenderId, Nullable<Int32> i_GrupoEtarioId, Nullable<Int32> i_IsConditionalId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, Nullable<Int32> i_IsConditionalIMC, Nullable<Decimal> r_Imc, Nullable<Int32> i_IsAdditional, componentDto component, protocolDto protocol)
        {
			this.v_ProtocolComponentId = v_ProtocolComponentId;
			this.v_ProtocolId = v_ProtocolId;
			this.v_ComponentId = v_ComponentId;
			this.r_Price = r_Price;
			this.i_OperatorId = i_OperatorId;
			this.i_Age = i_Age;
			this.i_GenderId = i_GenderId;
			this.i_GrupoEtarioId = i_GrupoEtarioId;
			this.i_IsConditionalId = i_IsConditionalId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.i_IsConditionalIMC = i_IsConditionalIMC;
			this.r_Imc = r_Imc;
			this.i_IsAdditional = i_IsAdditional;
			this.component = component;
			this.protocol = protocol;
        }
    }
}
