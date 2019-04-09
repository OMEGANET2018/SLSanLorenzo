//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/08 - 10:20:52
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
    public partial class locationDto
    {
        [DataMember()]
        public String v_LocationId { get; set; }

        [DataMember()]
        public String v_OrganizationId { get; set; }

        [DataMember()]
        public String v_Name { get; set; }

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
        public List<areaDto> area { get; set; }

        [DataMember()]
        public List<groupoccupationDto> groupoccupation { get; set; }

        [DataMember()]
        public organizationDto organization { get; set; }

        [DataMember()]
        public List<nodeorganizationlocationprofileDto> nodeorganizationlocationprofile { get; set; }

        [DataMember()]
        public List<nodeorganizationlocationwarehouseprofileDto> nodeorganizationlocationwarehouseprofile { get; set; }

        [DataMember()]
        public List<warehouseDto> warehouse { get; set; }

        public locationDto()
        {
        }

        public locationDto(String v_LocationId, String v_OrganizationId, String v_Name, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, List<areaDto> area, List<groupoccupationDto> groupoccupation, organizationDto organization, List<nodeorganizationlocationprofileDto> nodeorganizationlocationprofile, List<nodeorganizationlocationwarehouseprofileDto> nodeorganizationlocationwarehouseprofile, List<warehouseDto> warehouse)
        {
			this.v_LocationId = v_LocationId;
			this.v_OrganizationId = v_OrganizationId;
			this.v_Name = v_Name;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.area = area;
			this.groupoccupation = groupoccupation;
			this.organization = organization;
			this.nodeorganizationlocationprofile = nodeorganizationlocationprofile;
			this.nodeorganizationlocationwarehouseprofile = nodeorganizationlocationwarehouseprofile;
			this.warehouse = warehouse;
        }
    }
}
