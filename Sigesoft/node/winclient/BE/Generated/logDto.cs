//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/07/30 - 14:20:07
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
    public partial class logDto
    {
        [DataMember()]
        public String v_LogId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_NodeLogId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_EventTypeId { get; set; }

        [DataMember()]
        public String v_OrganizationId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_Date { get; set; }

        [DataMember()]
        public Nullable<Int32> i_SystemUserId { get; set; }

        [DataMember()]
        public String v_ProcessEntity { get; set; }

        [DataMember()]
        public String v_ElementItem { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Success { get; set; }

        [DataMember()]
        public String v_ErrorException { get; set; }

        public logDto()
        {
        }

        public logDto(String v_LogId, Nullable<Int32> i_NodeLogId, Nullable<Int32> i_EventTypeId, String v_OrganizationId, Nullable<DateTime> d_Date, Nullable<Int32> i_SystemUserId, String v_ProcessEntity, String v_ElementItem, Nullable<Int32> i_Success, String v_ErrorException)
        {
			this.v_LogId = v_LogId;
			this.i_NodeLogId = i_NodeLogId;
			this.i_EventTypeId = i_EventTypeId;
			this.v_OrganizationId = v_OrganizationId;
			this.d_Date = d_Date;
			this.i_SystemUserId = i_SystemUserId;
			this.v_ProcessEntity = v_ProcessEntity;
			this.v_ElementItem = v_ElementItem;
			this.i_Success = i_Success;
			this.v_ErrorException = v_ErrorException;
        }
    }
}
