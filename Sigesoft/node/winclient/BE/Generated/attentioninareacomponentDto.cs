//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/01/04 - 09:57:16
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
    public partial class attentioninareacomponentDto
    {
        [DataMember()]
        public String v_AttentioninAreaComponentId { get; set; }

        [DataMember()]
        public String v_AttentionInAreaId { get; set; }

        [DataMember()]
        public String v_ComponentId { get; set; }

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
        public attentioninareaDto attentioninarea { get; set; }

        [DataMember()]
        public componentDto component { get; set; }

        public attentioninareacomponentDto()
        {
        }

        public attentioninareacomponentDto(String v_AttentioninAreaComponentId, String v_AttentionInAreaId, String v_ComponentId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, attentioninareaDto attentioninarea, componentDto component)
        {
			this.v_AttentioninAreaComponentId = v_AttentioninAreaComponentId;
			this.v_AttentionInAreaId = v_AttentionInAreaId;
			this.v_ComponentId = v_ComponentId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.attentioninarea = attentioninarea;
			this.component = component;
        }
    }
}
