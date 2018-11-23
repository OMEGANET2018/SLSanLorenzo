//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/23 - 16:15:06
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
    /// Assembler for <see cref="attentioninarea"/> and <see cref="attentioninareaDto"/>.
    /// </summary>
    public static partial class attentioninareaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="attentioninareaDto"/> converted from <see cref="attentioninarea"/>.</param>
        static partial void OnDTO(this attentioninarea entity, attentioninareaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="attentioninarea"/> converted from <see cref="attentioninareaDto"/>.</param>
        static partial void OnEntity(this attentioninareaDto dto, attentioninarea entity);

        /// <summary>
        /// Converts this instance of <see cref="attentioninareaDto"/> to an instance of <see cref="attentioninarea"/>.
        /// </summary>
        /// <param name="dto"><see cref="attentioninareaDto"/> to convert.</param>
        public static attentioninarea ToEntity(this attentioninareaDto dto)
        {
            if (dto == null) return null;

            var entity = new attentioninarea();

            entity.v_AttentionInAreaId = dto.v_AttentionInAreaId;
            entity.i_NodeId = dto.i_NodeId;
            entity.v_Name = dto.v_Name;
            entity.v_OfficeNumber = dto.v_OfficeNumber;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="attentioninarea"/> to an instance of <see cref="attentioninareaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="attentioninarea"/> to convert.</param>
        public static attentioninareaDto ToDTO(this attentioninarea entity)
        {
            if (entity == null) return null;

            var dto = new attentioninareaDto();

            dto.v_AttentionInAreaId = entity.v_AttentionInAreaId;
            dto.i_NodeId = entity.i_NodeId;
            dto.v_Name = entity.v_Name;
            dto.v_OfficeNumber = entity.v_OfficeNumber;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="attentioninareaDto"/> to an instance of <see cref="attentioninarea"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<attentioninarea> ToEntities(this IEnumerable<attentioninareaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="attentioninarea"/> to an instance of <see cref="attentioninareaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<attentioninareaDto> ToDTOs(this IEnumerable<attentioninarea> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
