//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/03 - 14:44:38
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
    public partial class supplierDto
    {
        [DataMember()]
        public String v_SupplierId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_SectorTypeId { get; set; }

        [DataMember()]
        public String v_IdentificationNumber { get; set; }

        [DataMember()]
        public String v_Name { get; set; }

        [DataMember()]
        public String v_Address { get; set; }

        [DataMember()]
        public String v_PhoneNumber { get; set; }

        [DataMember()]
        public String v_Mail { get; set; }

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
        public Nullable<Int32> i_UpdateNodeId { get; set; }

        [DataMember()]
        public List<movementDto> movement { get; set; }

        public supplierDto()
        {
        }

        public supplierDto(String v_SupplierId, Nullable<Int32> i_SectorTypeId, String v_IdentificationNumber, String v_Name, String v_Address, String v_PhoneNumber, String v_Mail, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, Nullable<Int32> i_UpdateNodeId, List<movementDto> movement)
        {
			this.v_SupplierId = v_SupplierId;
			this.i_SectorTypeId = i_SectorTypeId;
			this.v_IdentificationNumber = v_IdentificationNumber;
			this.v_Name = v_Name;
			this.v_Address = v_Address;
			this.v_PhoneNumber = v_PhoneNumber;
			this.v_Mail = v_Mail;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.i_UpdateNodeId = i_UpdateNodeId;
			this.movement = movement;
        }
    }
}
