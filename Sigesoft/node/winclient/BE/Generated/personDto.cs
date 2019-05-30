//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/30 - 10:15:58
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
    public partial class personDto
    {
        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_FirstName { get; set; }

        [DataMember()]
        public String v_FirstLastName { get; set; }

        [DataMember()]
        public String v_SecondLastName { get; set; }

        [DataMember()]
        public Nullable<Int32> i_DocTypeId { get; set; }

        [DataMember()]
        public String v_DocNumber { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_Birthdate { get; set; }

        [DataMember()]
        public String v_BirthPlace { get; set; }

        [DataMember()]
        public Nullable<Int32> i_SexTypeId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_MaritalStatusId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_LevelOfId { get; set; }

        [DataMember()]
        public String v_TelephoneNumber { get; set; }

        [DataMember()]
        public String v_AdressLocation { get; set; }

        [DataMember()]
        public String v_GeografyLocationId { get; set; }

        [DataMember()]
        public String v_ContactName { get; set; }

        [DataMember()]
        public String v_EmergencyPhone { get; set; }

        [DataMember()]
        public Byte[] b_PersonImage { get; set; }

        [DataMember()]
        public String v_Mail { get; set; }

        [DataMember()]
        public Nullable<Int32> i_BloodGroupId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_BloodFactorId { get; set; }

        [DataMember()]
        public Byte[] b_FingerPrintTemplate { get; set; }

        [DataMember()]
        public Byte[] b_RubricImage { get; set; }

        [DataMember()]
        public Byte[] b_FingerPrintImage { get; set; }

        [DataMember()]
        public String t_RubricImageText { get; set; }

        [DataMember()]
        public String v_CurrentOccupation { get; set; }

        [DataMember()]
        public Nullable<Int32> i_DepartmentId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ProvinceId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_DistrictId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ResidenceInWorkplaceId { get; set; }

        [DataMember()]
        public String v_ResidenceTimeInWorkplace { get; set; }

        [DataMember()]
        public Nullable<Int32> i_TypeOfInsuranceId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_NumberLivingChildren { get; set; }

        [DataMember()]
        public Nullable<Int32> i_NumberDependentChildren { get; set; }

        [DataMember()]
        public Nullable<Int32> i_OccupationTypeId { get; set; }

        [DataMember()]
        public String v_OwnerName { get; set; }

        [DataMember()]
        public Nullable<Int32> i_NumberLiveChildren { get; set; }

        [DataMember()]
        public Nullable<Int32> i_NumberDeadChildren { get; set; }

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
        public Nullable<Int32> i_InsertNodeId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_UpdateNodeId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Relationship { get; set; }

        [DataMember()]
        public String v_ExploitedMineral { get; set; }

        [DataMember()]
        public Nullable<Int32> i_AltitudeWorkId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_PlaceWorkId { get; set; }

        [DataMember()]
        public String v_NroPoliza { get; set; }

        [DataMember()]
        public Nullable<Decimal> v_Deducible { get; set; }

        [DataMember()]
        public Nullable<Int32> i_NroHermanos { get; set; }

        [DataMember()]
        public String v_Password { get; set; }

        [DataMember()]
        public String v_Procedencia { get; set; }

        [DataMember()]
        public String v_CentroEducativo { get; set; }

        [DataMember()]
        public String v_Religion { get; set; }

        [DataMember()]
        public String v_Nacionalidad { get; set; }

        [DataMember()]
        public String v_ResidenciaAnterior { get; set; }

        [DataMember()]
        public String v_Subs { get; set; }

        [DataMember()]
        public String v_ComentaryUpdate { get; set; }

        [DataMember()]
        public List<adolescenteDto> adolescente { get; set; }

        [DataMember()]
        public List<adultoDto> adulto { get; set; }

        [DataMember()]
        public List<adultomayorDto> adultomayor { get; set; }

        [DataMember()]
        public List<blacklistpersonDto> blacklistperson { get; set; }

        [DataMember()]
        public List<calendarDto> calendar { get; set; }

        [DataMember()]
        public List<embarzoDto> embarzo { get; set; }

        [DataMember()]
        public List<familymedicalantecedentsDto> familymedicalantecedents { get; set; }

        [DataMember()]
        public List<historyDto> history { get; set; }

        [DataMember()]
        public List<multimediafileDto> multimediafile { get; set; }

        [DataMember()]
        public List<ninioDto> ninio { get; set; }

        [DataMember()]
        public List<noxioushabitsDto> noxioushabits { get; set; }

        [DataMember()]
        public pacientDto pacient { get; set; }

        [DataMember()]
        public List<personmedicalhistoryDto> personmedicalhistory { get; set; }

        [DataMember()]
        public professionalDto professional { get; set; }

        [DataMember()]
        public List<serviceDto> service { get; set; }

        [DataMember()]
        public List<systemuserDto> systemuser { get; set; }

        public personDto()
        {
        }

        public personDto(String v_PersonId, String v_FirstName, String v_FirstLastName, String v_SecondLastName, Nullable<Int32> i_DocTypeId, String v_DocNumber, Nullable<DateTime> d_Birthdate, String v_BirthPlace, Nullable<Int32> i_SexTypeId, Nullable<Int32> i_MaritalStatusId, Nullable<Int32> i_LevelOfId, String v_TelephoneNumber, String v_AdressLocation, String v_GeografyLocationId, String v_ContactName, String v_EmergencyPhone, Byte[] b_PersonImage, String v_Mail, Nullable<Int32> i_BloodGroupId, Nullable<Int32> i_BloodFactorId, Byte[] b_FingerPrintTemplate, Byte[] b_RubricImage, Byte[] b_FingerPrintImage, String t_RubricImageText, String v_CurrentOccupation, Nullable<Int32> i_DepartmentId, Nullable<Int32> i_ProvinceId, Nullable<Int32> i_DistrictId, Nullable<Int32> i_ResidenceInWorkplaceId, String v_ResidenceTimeInWorkplace, Nullable<Int32> i_TypeOfInsuranceId, Nullable<Int32> i_NumberLivingChildren, Nullable<Int32> i_NumberDependentChildren, Nullable<Int32> i_OccupationTypeId, String v_OwnerName, Nullable<Int32> i_NumberLiveChildren, Nullable<Int32> i_NumberDeadChildren, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, Nullable<Int32> i_InsertNodeId, Nullable<Int32> i_UpdateNodeId, Nullable<Int32> i_Relationship, String v_ExploitedMineral, Nullable<Int32> i_AltitudeWorkId, Nullable<Int32> i_PlaceWorkId, String v_NroPoliza, Nullable<Decimal> v_Deducible, Nullable<Int32> i_NroHermanos, String v_Password, String v_Procedencia, String v_CentroEducativo, String v_Religion, String v_Nacionalidad, String v_ResidenciaAnterior, String v_Subs, String v_ComentaryUpdate, List<adolescenteDto> adolescente, List<adultoDto> adulto, List<adultomayorDto> adultomayor, List<blacklistpersonDto> blacklistperson, List<calendarDto> calendar, List<embarzoDto> embarzo, List<familymedicalantecedentsDto> familymedicalantecedents, List<historyDto> history, List<multimediafileDto> multimediafile, List<ninioDto> ninio, List<noxioushabitsDto> noxioushabits, pacientDto pacient, List<personmedicalhistoryDto> personmedicalhistory, professionalDto professional, List<serviceDto> service, List<systemuserDto> systemuser)
        {
			this.v_PersonId = v_PersonId;
			this.v_FirstName = v_FirstName;
			this.v_FirstLastName = v_FirstLastName;
			this.v_SecondLastName = v_SecondLastName;
			this.i_DocTypeId = i_DocTypeId;
			this.v_DocNumber = v_DocNumber;
			this.d_Birthdate = d_Birthdate;
			this.v_BirthPlace = v_BirthPlace;
			this.i_SexTypeId = i_SexTypeId;
			this.i_MaritalStatusId = i_MaritalStatusId;
			this.i_LevelOfId = i_LevelOfId;
			this.v_TelephoneNumber = v_TelephoneNumber;
			this.v_AdressLocation = v_AdressLocation;
			this.v_GeografyLocationId = v_GeografyLocationId;
			this.v_ContactName = v_ContactName;
			this.v_EmergencyPhone = v_EmergencyPhone;
			this.b_PersonImage = b_PersonImage;
			this.v_Mail = v_Mail;
			this.i_BloodGroupId = i_BloodGroupId;
			this.i_BloodFactorId = i_BloodFactorId;
			this.b_FingerPrintTemplate = b_FingerPrintTemplate;
			this.b_RubricImage = b_RubricImage;
			this.b_FingerPrintImage = b_FingerPrintImage;
			this.t_RubricImageText = t_RubricImageText;
			this.v_CurrentOccupation = v_CurrentOccupation;
			this.i_DepartmentId = i_DepartmentId;
			this.i_ProvinceId = i_ProvinceId;
			this.i_DistrictId = i_DistrictId;
			this.i_ResidenceInWorkplaceId = i_ResidenceInWorkplaceId;
			this.v_ResidenceTimeInWorkplace = v_ResidenceTimeInWorkplace;
			this.i_TypeOfInsuranceId = i_TypeOfInsuranceId;
			this.i_NumberLivingChildren = i_NumberLivingChildren;
			this.i_NumberDependentChildren = i_NumberDependentChildren;
			this.i_OccupationTypeId = i_OccupationTypeId;
			this.v_OwnerName = v_OwnerName;
			this.i_NumberLiveChildren = i_NumberLiveChildren;
			this.i_NumberDeadChildren = i_NumberDeadChildren;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.i_InsertNodeId = i_InsertNodeId;
			this.i_UpdateNodeId = i_UpdateNodeId;
			this.i_Relationship = i_Relationship;
			this.v_ExploitedMineral = v_ExploitedMineral;
			this.i_AltitudeWorkId = i_AltitudeWorkId;
			this.i_PlaceWorkId = i_PlaceWorkId;
			this.v_NroPoliza = v_NroPoliza;
			this.v_Deducible = v_Deducible;
			this.i_NroHermanos = i_NroHermanos;
			this.v_Password = v_Password;
			this.v_Procedencia = v_Procedencia;
			this.v_CentroEducativo = v_CentroEducativo;
			this.v_Religion = v_Religion;
			this.v_Nacionalidad = v_Nacionalidad;
			this.v_ResidenciaAnterior = v_ResidenciaAnterior;
			this.v_Subs = v_Subs;
			this.v_ComentaryUpdate = v_ComentaryUpdate;
			this.adolescente = adolescente;
			this.adulto = adulto;
			this.adultomayor = adultomayor;
			this.blacklistperson = blacklistperson;
			this.calendar = calendar;
			this.embarzo = embarzo;
			this.familymedicalantecedents = familymedicalantecedents;
			this.history = history;
			this.multimediafile = multimediafile;
			this.ninio = ninio;
			this.noxioushabits = noxioushabits;
			this.pacient = pacient;
			this.personmedicalhistory = personmedicalhistory;
			this.professional = professional;
			this.service = service;
			this.systemuser = systemuser;
        }
    }
}
