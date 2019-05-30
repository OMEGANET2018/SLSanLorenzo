//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/30 - 10:17:40
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
    /// Assembler for <see cref="organizationperson"/> and <see cref="organizationpersonDto"/>.
    /// </summary>
    public static partial class organizationpersonAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="organizationpersonDto"/> converted from <see cref="organizationperson"/>.</param>
        static partial void OnDTO(this organizationperson entity, organizationpersonDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="organizationperson"/> converted from <see cref="organizationpersonDto"/>.</param>
        static partial void OnEntity(this organizationpersonDto dto, organizationperson entity);

        /// <summary>
        /// Converts this instance of <see cref="organizationpersonDto"/> to an instance of <see cref="organizationperson"/>.
        /// </summary>
        /// <param name="dto"><see cref="organizationpersonDto"/> to convert.</param>
        public static organizationperson ToEntity(this organizationpersonDto dto)
        {
            if (dto == null) return null;

            var entity = new organizationperson();

            entity.v_OrganizationPersonId = dto.v_OrganizationPersonId;
            entity.v_PersonId = dto.v_PersonId;
            entity.v_OrganizationId = dto.v_OrganizationId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="organizationperson"/> to an instance of <see cref="organizationpersonDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="organizationperson"/> to convert.</param>
        public static organizationpersonDto ToDTO(this organizationperson entity)
        {
            if (entity == null) return null;

            var dto = new organizationpersonDto();

            dto.v_OrganizationPersonId = entity.v_OrganizationPersonId;
            dto.v_PersonId = entity.v_PersonId;
            dto.v_OrganizationId = entity.v_OrganizationId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="organizationpersonDto"/> to an instance of <see cref="organizationperson"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<organizationperson> ToEntities(this IEnumerable<organizationpersonDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="organizationperson"/> to an instance of <see cref="organizationpersonDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<organizationpersonDto> ToDTOs(this IEnumerable<organizationperson> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
