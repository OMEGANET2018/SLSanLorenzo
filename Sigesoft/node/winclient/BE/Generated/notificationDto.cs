//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/03/03 - 14:32:03
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
    public partial class notificationDto
    {
        [DataMember()]
        public String v_NotificationId { get; set; }

        [DataMember()]
        public String v_OrganizationId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_NotificationDate { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_Title { get; set; }

        [DataMember()]
        public String v_Body { get; set; }

        [DataMember()]
        public Nullable<Int32> i_TypeNotificationId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_ScheduleDate { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsRead { get; set; }

        [DataMember()]
        public Nullable<Int32> i_StateNotificationId { get; set; }

        [DataMember()]
        public String v_Path { get; set; }

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
        public personDto person { get; set; }

        public notificationDto()
        {
        }

        public notificationDto(String v_NotificationId, String v_OrganizationId, Nullable<DateTime> d_NotificationDate, String v_PersonId, String v_Title, String v_Body, Nullable<Int32> i_TypeNotificationId, Nullable<DateTime> d_ScheduleDate, Nullable<Int32> i_IsRead, Nullable<Int32> i_StateNotificationId, String v_Path, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, personDto person)
        {
			this.v_NotificationId = v_NotificationId;
			this.v_OrganizationId = v_OrganizationId;
			this.d_NotificationDate = d_NotificationDate;
			this.v_PersonId = v_PersonId;
			this.v_Title = v_Title;
			this.v_Body = v_Body;
			this.i_TypeNotificationId = i_TypeNotificationId;
			this.d_ScheduleDate = d_ScheduleDate;
			this.i_IsRead = i_IsRead;
			this.i_StateNotificationId = i_StateNotificationId;
			this.v_Path = v_Path;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.person = person;
        }
    }
}