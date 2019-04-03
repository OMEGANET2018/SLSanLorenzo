//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/03 - 00:50:50
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
    /// Assembler for <see cref="servicecomponentmultimedia"/> and <see cref="servicecomponentmultimediaDto"/>.
    /// </summary>
    public static partial class servicecomponentmultimediaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="servicecomponentmultimediaDto"/> converted from <see cref="servicecomponentmultimedia"/>.</param>
        static partial void OnDTO(this servicecomponentmultimedia entity, servicecomponentmultimediaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="servicecomponentmultimedia"/> converted from <see cref="servicecomponentmultimediaDto"/>.</param>
        static partial void OnEntity(this servicecomponentmultimediaDto dto, servicecomponentmultimedia entity);

        /// <summary>
        /// Converts this instance of <see cref="servicecomponentmultimediaDto"/> to an instance of <see cref="servicecomponentmultimedia"/>.
        /// </summary>
        /// <param name="dto"><see cref="servicecomponentmultimediaDto"/> to convert.</param>
        public static servicecomponentmultimedia ToEntity(this servicecomponentmultimediaDto dto)
        {
            if (dto == null) return null;

            var entity = new servicecomponentmultimedia();

            entity.v_ServiceComponentMultimediaId = dto.v_ServiceComponentMultimediaId;
            entity.v_ServiceComponentId = dto.v_ServiceComponentId;
            entity.v_MultimediaFileId = dto.v_MultimediaFileId;
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
        /// Converts this instance of <see cref="servicecomponentmultimedia"/> to an instance of <see cref="servicecomponentmultimediaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="servicecomponentmultimedia"/> to convert.</param>
        public static servicecomponentmultimediaDto ToDTO(this servicecomponentmultimedia entity)
        {
            if (entity == null) return null;

            var dto = new servicecomponentmultimediaDto();

            dto.v_ServiceComponentMultimediaId = entity.v_ServiceComponentMultimediaId;
            dto.v_ServiceComponentId = entity.v_ServiceComponentId;
            dto.v_MultimediaFileId = entity.v_MultimediaFileId;
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
        /// Converts each instance of <see cref="servicecomponentmultimediaDto"/> to an instance of <see cref="servicecomponentmultimedia"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<servicecomponentmultimedia> ToEntities(this IEnumerable<servicecomponentmultimediaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="servicecomponentmultimedia"/> to an instance of <see cref="servicecomponentmultimediaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<servicecomponentmultimediaDto> ToDTOs(this IEnumerable<servicecomponentmultimedia> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
