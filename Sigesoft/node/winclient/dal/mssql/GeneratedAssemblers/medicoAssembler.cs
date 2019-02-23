//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/20 - 08:16:28
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
    /// Assembler for <see cref="medico"/> and <see cref="medicoDto"/>.
    /// </summary>
    public static partial class medicoAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="medicoDto"/> converted from <see cref="medico"/>.</param>
        static partial void OnDTO(this medico entity, medicoDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="medico"/> converted from <see cref="medicoDto"/>.</param>
        static partial void OnEntity(this medicoDto dto, medico entity);

        /// <summary>
        /// Converts this instance of <see cref="medicoDto"/> to an instance of <see cref="medico"/>.
        /// </summary>
        /// <param name="dto"><see cref="medicoDto"/> to convert.</param>
        public static medico ToEntity(this medicoDto dto)
        {
            if (dto == null) return null;

            var entity = new medico();

            entity.v_MedicoId = dto.v_MedicoId;
            entity.i_MasterServiceId = dto.i_MasterServiceId;
            entity.i_SystemUserId = dto.i_SystemUserId;
            entity.i_MasterServiceTypeId = dto.i_MasterServiceTypeId;
            entity.r_Clinica = dto.r_Clinica;
            entity.r_Medico = dto.r_Medico;
            entity.i_CategoryId = dto.i_CategoryId;
            entity.r_Price = dto.r_Price;
            entity.v_EmployerOrganizationId = dto.v_EmployerOrganizationId;
            entity.v_CustomerOrganizationId = dto.v_CustomerOrganizationId;
            entity.v_WorkingOrganizationId = dto.v_WorkingOrganizationId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="medico"/> to an instance of <see cref="medicoDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="medico"/> to convert.</param>
        public static medicoDto ToDTO(this medico entity)
        {
            if (entity == null) return null;

            var dto = new medicoDto();

            dto.v_MedicoId = entity.v_MedicoId;
            dto.i_MasterServiceId = entity.i_MasterServiceId;
            dto.i_SystemUserId = entity.i_SystemUserId;
            dto.i_MasterServiceTypeId = entity.i_MasterServiceTypeId;
            dto.r_Clinica = entity.r_Clinica;
            dto.r_Medico = entity.r_Medico;
            dto.i_CategoryId = entity.i_CategoryId;
            dto.r_Price = entity.r_Price;
            dto.v_EmployerOrganizationId = entity.v_EmployerOrganizationId;
            dto.v_CustomerOrganizationId = entity.v_CustomerOrganizationId;
            dto.v_WorkingOrganizationId = entity.v_WorkingOrganizationId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="medicoDto"/> to an instance of <see cref="medico"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<medico> ToEntities(this IEnumerable<medicoDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="medico"/> to an instance of <see cref="medicoDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<medicoDto> ToDTOs(this IEnumerable<medico> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
