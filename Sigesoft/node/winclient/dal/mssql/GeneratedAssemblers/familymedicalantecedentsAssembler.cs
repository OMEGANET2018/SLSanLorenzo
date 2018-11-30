//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/30 - 12:37:45
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
    /// Assembler for <see cref="familymedicalantecedents"/> and <see cref="familymedicalantecedentsDto"/>.
    /// </summary>
    public static partial class familymedicalantecedentsAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="familymedicalantecedentsDto"/> converted from <see cref="familymedicalantecedents"/>.</param>
        static partial void OnDTO(this familymedicalantecedents entity, familymedicalantecedentsDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="familymedicalantecedents"/> converted from <see cref="familymedicalantecedentsDto"/>.</param>
        static partial void OnEntity(this familymedicalantecedentsDto dto, familymedicalantecedents entity);

        /// <summary>
        /// Converts this instance of <see cref="familymedicalantecedentsDto"/> to an instance of <see cref="familymedicalantecedents"/>.
        /// </summary>
        /// <param name="dto"><see cref="familymedicalantecedentsDto"/> to convert.</param>
        public static familymedicalantecedents ToEntity(this familymedicalantecedentsDto dto)
        {
            if (dto == null) return null;

            var entity = new familymedicalantecedents();

            entity.v_FamilyMedicalAntecedentsId = dto.v_FamilyMedicalAntecedentsId;
            entity.v_PersonId = dto.v_PersonId;
            entity.v_DiseasesId = dto.v_DiseasesId;
            entity.i_TypeFamilyId = dto.i_TypeFamilyId;
            entity.v_Comment = dto.v_Comment;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="familymedicalantecedents"/> to an instance of <see cref="familymedicalantecedentsDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="familymedicalantecedents"/> to convert.</param>
        public static familymedicalantecedentsDto ToDTO(this familymedicalantecedents entity)
        {
            if (entity == null) return null;

            var dto = new familymedicalantecedentsDto();

            dto.v_FamilyMedicalAntecedentsId = entity.v_FamilyMedicalAntecedentsId;
            dto.v_PersonId = entity.v_PersonId;
            dto.v_DiseasesId = entity.v_DiseasesId;
            dto.i_TypeFamilyId = entity.i_TypeFamilyId;
            dto.v_Comment = entity.v_Comment;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="familymedicalantecedentsDto"/> to an instance of <see cref="familymedicalantecedents"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<familymedicalantecedents> ToEntities(this IEnumerable<familymedicalantecedentsDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="familymedicalantecedents"/> to an instance of <see cref="familymedicalantecedentsDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<familymedicalantecedentsDto> ToDTOs(this IEnumerable<familymedicalantecedents> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
