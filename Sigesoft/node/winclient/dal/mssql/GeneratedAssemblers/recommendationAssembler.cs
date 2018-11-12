//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/10 - 12:33:04
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
    /// Assembler for <see cref="recommendation"/> and <see cref="recommendationDto"/>.
    /// </summary>
    public static partial class recommendationAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="recommendationDto"/> converted from <see cref="recommendation"/>.</param>
        static partial void OnDTO(this recommendation entity, recommendationDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="recommendation"/> converted from <see cref="recommendationDto"/>.</param>
        static partial void OnEntity(this recommendationDto dto, recommendation entity);

        /// <summary>
        /// Converts this instance of <see cref="recommendationDto"/> to an instance of <see cref="recommendation"/>.
        /// </summary>
        /// <param name="dto"><see cref="recommendationDto"/> to convert.</param>
        public static recommendation ToEntity(this recommendationDto dto)
        {
            if (dto == null) return null;

            var entity = new recommendation();

            entity.v_RecommendationId = dto.v_RecommendationId;
            entity.v_ServiceId = dto.v_ServiceId;
            entity.v_DiagnosticRepositoryId = dto.v_DiagnosticRepositoryId;
            entity.v_ComponentId = dto.v_ComponentId;
            entity.v_MasterRecommendationId = dto.v_MasterRecommendationId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="recommendation"/> to an instance of <see cref="recommendationDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="recommendation"/> to convert.</param>
        public static recommendationDto ToDTO(this recommendation entity)
        {
            if (entity == null) return null;

            var dto = new recommendationDto();

            dto.v_RecommendationId = entity.v_RecommendationId;
            dto.v_ServiceId = entity.v_ServiceId;
            dto.v_DiagnosticRepositoryId = entity.v_DiagnosticRepositoryId;
            dto.v_ComponentId = entity.v_ComponentId;
            dto.v_MasterRecommendationId = entity.v_MasterRecommendationId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="recommendationDto"/> to an instance of <see cref="recommendation"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<recommendation> ToEntities(this IEnumerable<recommendationDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="recommendation"/> to an instance of <see cref="recommendationDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<recommendationDto> ToDTOs(this IEnumerable<recommendation> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
