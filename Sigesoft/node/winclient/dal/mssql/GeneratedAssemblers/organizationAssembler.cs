//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/03 - 00:50:26
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
    /// Assembler for <see cref="organization"/> and <see cref="organizationDto"/>.
    /// </summary>
    public static partial class organizationAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="organizationDto"/> converted from <see cref="organization"/>.</param>
        static partial void OnDTO(this organization entity, organizationDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="organization"/> converted from <see cref="organizationDto"/>.</param>
        static partial void OnEntity(this organizationDto dto, organization entity);

        /// <summary>
        /// Converts this instance of <see cref="organizationDto"/> to an instance of <see cref="organization"/>.
        /// </summary>
        /// <param name="dto"><see cref="organizationDto"/> to convert.</param>
        public static organization ToEntity(this organizationDto dto)
        {
            if (dto == null) return null;

            var entity = new organization();

            entity.v_OrganizationId = dto.v_OrganizationId;
            entity.i_OrganizationTypeId = dto.i_OrganizationTypeId;
            entity.i_SectorTypeId = dto.i_SectorTypeId;
            entity.v_SectorName = dto.v_SectorName;
            entity.v_SectorCodigo = dto.v_SectorCodigo;
            entity.v_IdentificationNumber = dto.v_IdentificationNumber;
            entity.v_Name = dto.v_Name;
            entity.v_Address = dto.v_Address;
            entity.v_PhoneNumber = dto.v_PhoneNumber;
            entity.v_Mail = dto.v_Mail;
            entity.v_ContacName = dto.v_ContacName;
            entity.v_Contacto = dto.v_Contacto;
            entity.v_EmailContacto = dto.v_EmailContacto;
            entity.v_Observation = dto.v_Observation;
            entity.i_NumberQuotasOrganization = dto.i_NumberQuotasOrganization;
            entity.i_NumberQuotasMen = dto.i_NumberQuotasMen;
            entity.i_NumberQuotasWomen = dto.i_NumberQuotasWomen;
            entity.i_DepartmentId = dto.i_DepartmentId;
            entity.i_ProvinceId = dto.i_ProvinceId;
            entity.i_DistrictId = dto.i_DistrictId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.b_Image = dto.b_Image;
            entity.v_ContactoMedico = dto.v_ContactoMedico;
            entity.v_EmailMedico = dto.v_EmailMedico;
            entity.r_Factor = dto.r_Factor;
            entity.r_FactorMed = dto.r_FactorMed;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="organization"/> to an instance of <see cref="organizationDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="organization"/> to convert.</param>
        public static organizationDto ToDTO(this organization entity)
        {
            if (entity == null) return null;

            var dto = new organizationDto();

            dto.v_OrganizationId = entity.v_OrganizationId;
            dto.i_OrganizationTypeId = entity.i_OrganizationTypeId;
            dto.i_SectorTypeId = entity.i_SectorTypeId;
            dto.v_SectorName = entity.v_SectorName;
            dto.v_SectorCodigo = entity.v_SectorCodigo;
            dto.v_IdentificationNumber = entity.v_IdentificationNumber;
            dto.v_Name = entity.v_Name;
            dto.v_Address = entity.v_Address;
            dto.v_PhoneNumber = entity.v_PhoneNumber;
            dto.v_Mail = entity.v_Mail;
            dto.v_ContacName = entity.v_ContacName;
            dto.v_Contacto = entity.v_Contacto;
            dto.v_EmailContacto = entity.v_EmailContacto;
            dto.v_Observation = entity.v_Observation;
            dto.i_NumberQuotasOrganization = entity.i_NumberQuotasOrganization;
            dto.i_NumberQuotasMen = entity.i_NumberQuotasMen;
            dto.i_NumberQuotasWomen = entity.i_NumberQuotasWomen;
            dto.i_DepartmentId = entity.i_DepartmentId;
            dto.i_ProvinceId = entity.i_ProvinceId;
            dto.i_DistrictId = entity.i_DistrictId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.b_Image = entity.b_Image;
            dto.v_ContactoMedico = entity.v_ContactoMedico;
            dto.v_EmailMedico = entity.v_EmailMedico;
            dto.r_Factor = entity.r_Factor;
            dto.r_FactorMed = entity.r_FactorMed;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="organizationDto"/> to an instance of <see cref="organization"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<organization> ToEntities(this IEnumerable<organizationDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="organization"/> to an instance of <see cref="organizationDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<organizationDto> ToDTOs(this IEnumerable<organization> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
