//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/01/04 - 10:00:31
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Sigesoft.Node.WinClient.DAL;

namespace Sigesoft.Node.WinClient.BE
{

    /// <summary>
    /// Assembler for <see cref="person"/> and <see cref="personDto"/>.
    /// </summary>
    public static partial class personAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="personDto"/> converted from <see cref="person"/>.</param>
        static partial void OnDTO(this person entity, personDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="person"/> converted from <see cref="personDto"/>.</param>
        static partial void OnEntity(this personDto dto, person entity);

        /// <summary>
        /// Converts this instance of <see cref="personDto"/> to an instance of <see cref="person"/>.
        /// </summary>
        /// <param name="dto"><see cref="personDto"/> to convert.</param>
        public static person ToEntity(this personDto dto)
        {
            if (dto == null) return null;

            var entity = new person();

            entity.v_PersonId = dto.v_PersonId;
            entity.v_FirstName = dto.v_FirstName;
            entity.v_FirstLastName = dto.v_FirstLastName;
            entity.v_SecondLastName = dto.v_SecondLastName;
            entity.i_DocTypeId = dto.i_DocTypeId;
            entity.v_DocNumber = dto.v_DocNumber;
            entity.d_Birthdate = dto.d_Birthdate;
            entity.v_BirthPlace = dto.v_BirthPlace;
            entity.i_SexTypeId = dto.i_SexTypeId;
            entity.i_MaritalStatusId = dto.i_MaritalStatusId;
            entity.i_LevelOfId = dto.i_LevelOfId;
            entity.v_TelephoneNumber = dto.v_TelephoneNumber;
            entity.v_AdressLocation = dto.v_AdressLocation;
            entity.v_GeografyLocationId = dto.v_GeografyLocationId;
            entity.v_ContactName = dto.v_ContactName;
            entity.v_EmergencyPhone = dto.v_EmergencyPhone;
            entity.b_PersonImage = dto.b_PersonImage;
            entity.v_Mail = dto.v_Mail;
            entity.i_BloodGroupId = dto.i_BloodGroupId;
            entity.i_BloodFactorId = dto.i_BloodFactorId;
            entity.b_FingerPrintTemplate = dto.b_FingerPrintTemplate;
            entity.b_RubricImage = dto.b_RubricImage;
            entity.b_FingerPrintImage = dto.b_FingerPrintImage;
            entity.t_RubricImageText = dto.t_RubricImageText;
            entity.v_CurrentOccupation = dto.v_CurrentOccupation;
            entity.i_DepartmentId = dto.i_DepartmentId;
            entity.i_ProvinceId = dto.i_ProvinceId;
            entity.i_DistrictId = dto.i_DistrictId;
            entity.i_ResidenceInWorkplaceId = dto.i_ResidenceInWorkplaceId;
            entity.v_ResidenceTimeInWorkplace = dto.v_ResidenceTimeInWorkplace;
            entity.i_TypeOfInsuranceId = dto.i_TypeOfInsuranceId;
            entity.i_NumberLivingChildren = dto.i_NumberLivingChildren;
            entity.i_NumberDependentChildren = dto.i_NumberDependentChildren;
            entity.i_OccupationTypeId = dto.i_OccupationTypeId;
            entity.v_OwnerName = dto.v_OwnerName;
            entity.i_NumberLiveChildren = dto.i_NumberLiveChildren;
            entity.i_NumberDeadChildren = dto.i_NumberDeadChildren;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.i_InsertNodeId = dto.i_InsertNodeId;
            entity.i_UpdateNodeId = dto.i_UpdateNodeId;
            entity.i_Relationship = dto.i_Relationship;
            entity.v_ExploitedMineral = dto.v_ExploitedMineral;
            entity.i_AltitudeWorkId = dto.i_AltitudeWorkId;
            entity.i_PlaceWorkId = dto.i_PlaceWorkId;
            entity.v_NroPoliza = dto.v_NroPoliza;
            entity.v_Deducible = dto.v_Deducible;
            entity.i_NroHermanos = dto.i_NroHermanos;
            entity.v_Password = dto.v_Password;
            entity.v_Procedencia = dto.v_Procedencia;
            entity.v_CentroEducativo = dto.v_CentroEducativo;
            entity.v_Religion = dto.v_Religion;
            entity.v_Nacionalidad = dto.v_Nacionalidad;
            entity.v_ResidenciaAnterior = dto.v_ResidenciaAnterior;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="person"/> to an instance of <see cref="personDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="person"/> to convert.</param>
        public static personDto ToDTO(this person entity)
        {
            if (entity == null) return null;

            var dto = new personDto();

            dto.v_PersonId = entity.v_PersonId;
            dto.v_FirstName = entity.v_FirstName;
            dto.v_FirstLastName = entity.v_FirstLastName;
            dto.v_SecondLastName = entity.v_SecondLastName;
            dto.i_DocTypeId = entity.i_DocTypeId;
            dto.v_DocNumber = entity.v_DocNumber;
            dto.d_Birthdate = entity.d_Birthdate;
            dto.v_BirthPlace = entity.v_BirthPlace;
            dto.i_SexTypeId = entity.i_SexTypeId;
            dto.i_MaritalStatusId = entity.i_MaritalStatusId;
            dto.i_LevelOfId = entity.i_LevelOfId;
            dto.v_TelephoneNumber = entity.v_TelephoneNumber;
            dto.v_AdressLocation = entity.v_AdressLocation;
            dto.v_GeografyLocationId = entity.v_GeografyLocationId;
            dto.v_ContactName = entity.v_ContactName;
            dto.v_EmergencyPhone = entity.v_EmergencyPhone;
            dto.b_PersonImage = entity.b_PersonImage;
            dto.v_Mail = entity.v_Mail;
            dto.i_BloodGroupId = entity.i_BloodGroupId;
            dto.i_BloodFactorId = entity.i_BloodFactorId;
            dto.b_FingerPrintTemplate = entity.b_FingerPrintTemplate;
            dto.b_RubricImage = entity.b_RubricImage;
            dto.b_FingerPrintImage = entity.b_FingerPrintImage;
            dto.t_RubricImageText = entity.t_RubricImageText;
            dto.v_CurrentOccupation = entity.v_CurrentOccupation;
            dto.i_DepartmentId = entity.i_DepartmentId;
            dto.i_ProvinceId = entity.i_ProvinceId;
            dto.i_DistrictId = entity.i_DistrictId;
            dto.i_ResidenceInWorkplaceId = entity.i_ResidenceInWorkplaceId;
            dto.v_ResidenceTimeInWorkplace = entity.v_ResidenceTimeInWorkplace;
            dto.i_TypeOfInsuranceId = entity.i_TypeOfInsuranceId;
            dto.i_NumberLivingChildren = entity.i_NumberLivingChildren;
            dto.i_NumberDependentChildren = entity.i_NumberDependentChildren;
            dto.i_OccupationTypeId = entity.i_OccupationTypeId;
            dto.v_OwnerName = entity.v_OwnerName;
            dto.i_NumberLiveChildren = entity.i_NumberLiveChildren;
            dto.i_NumberDeadChildren = entity.i_NumberDeadChildren;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.i_InsertNodeId = entity.i_InsertNodeId;
            dto.i_UpdateNodeId = entity.i_UpdateNodeId;
            dto.i_Relationship = entity.i_Relationship;
            dto.v_ExploitedMineral = entity.v_ExploitedMineral;
            dto.i_AltitudeWorkId = entity.i_AltitudeWorkId;
            dto.i_PlaceWorkId = entity.i_PlaceWorkId;
            dto.v_NroPoliza = entity.v_NroPoliza;
            dto.v_Deducible = entity.v_Deducible;
            dto.i_NroHermanos = entity.i_NroHermanos;
            dto.v_Password = entity.v_Password;
            dto.v_Procedencia = entity.v_Procedencia;
            dto.v_CentroEducativo = entity.v_CentroEducativo;
            dto.v_Religion = entity.v_Religion;
            dto.v_Nacionalidad = entity.v_Nacionalidad;
            dto.v_ResidenciaAnterior = entity.v_ResidenciaAnterior;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="personDto"/> to an instance of <see cref="person"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<person> ToEntities(this IEnumerable<personDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="person"/> to an instance of <see cref="personDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<personDto> ToDTOs(this IEnumerable<person> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
