//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/23 - 08:50:59
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
    public partial class datahierarchyDto
    {
        [DataMember()]
        public Int32 i_GroupId { get; set; }

        [DataMember()]
        public Int32 i_ItemId { get; set; }

        [DataMember()]
        public String v_Value1 { get; set; }

        [DataMember()]
        public String v_Value2 { get; set; }

        [DataMember()]
        public String v_Field { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ParentItemId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Sort { get; set; }

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
        public String v_ComentaryUpdate { get; set; }

        public datahierarchyDto()
        {
        }

        public datahierarchyDto(Int32 i_GroupId, Int32 i_ItemId, String v_Value1, String v_Value2, String v_Field, Nullable<Int32> i_ParentItemId, Nullable<Int32> i_Sort, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, String v_ComentaryUpdate)
        {
			this.i_GroupId = i_GroupId;
			this.i_ItemId = i_ItemId;
			this.v_Value1 = v_Value1;
			this.v_Value2 = v_Value2;
			this.v_Field = v_Field;
			this.i_ParentItemId = i_ParentItemId;
			this.i_Sort = i_Sort;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.v_ComentaryUpdate = v_ComentaryUpdate;
        }
    }
}
