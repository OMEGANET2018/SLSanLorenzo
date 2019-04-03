//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/03 - 00:50:00
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
    /// Assembler for <see cref="blacklistperson"/> and <see cref="blacklistpersonDto"/>.
    /// </summary>
    public static partial class blacklistpersonAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="blacklistpersonDto"/> converted from <see cref="blacklistperson"/>.</param>
        static partial void OnDTO(this blacklistperson entity, blacklistpersonDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="blacklistperson"/> converted from <see cref="blacklistpersonDto"/>.</param>
        static partial void OnEntity(this blacklistpersonDto dto, blacklistperson entity);

        /// <summary>
        /// Converts this instance of <see cref="blacklistpersonDto"/> to an instance of <see cref="blacklistperson"/>.
        /// </summary>
        /// <param name="dto"><see cref="blacklistpersonDto"/> to convert.</param>
        public static blacklistperson ToEntity(this blacklistpersonDto dto)
        {
            if (dto == null) return null;

            var entity = new blacklistperson();

            entity.v_BlackListPerson = dto.v_BlackListPerson;
            entity.v_PersonId = dto.v_PersonId;
            entity.v_Comment = dto.v_Comment;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.i_Status = dto.i_Status;
            entity.d_DateRegister = dto.d_DateRegister;
            entity.d_DateDetection = dto.d_DateDetection;
            entity.d_DateSolution = dto.d_DateSolution;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="blacklistperson"/> to an instance of <see cref="blacklistpersonDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="blacklistperson"/> to convert.</param>
        public static blacklistpersonDto ToDTO(this blacklistperson entity)
        {
            if (entity == null) return null;

            var dto = new blacklistpersonDto();

            dto.v_BlackListPerson = entity.v_BlackListPerson;
            dto.v_PersonId = entity.v_PersonId;
            dto.v_Comment = entity.v_Comment;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.i_Status = entity.i_Status;
            dto.d_DateRegister = entity.d_DateRegister;
            dto.d_DateDetection = entity.d_DateDetection;
            dto.d_DateSolution = entity.d_DateSolution;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="blacklistpersonDto"/> to an instance of <see cref="blacklistperson"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<blacklistperson> ToEntities(this IEnumerable<blacklistpersonDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="blacklistperson"/> to an instance of <see cref="blacklistpersonDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<blacklistpersonDto> ToDTOs(this IEnumerable<blacklistperson> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
