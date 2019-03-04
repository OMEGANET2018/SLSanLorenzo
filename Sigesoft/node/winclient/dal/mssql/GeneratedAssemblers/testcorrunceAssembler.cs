//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/03/03 - 14:34:37
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
    /// Assembler for <see cref="testcorrunce"/> and <see cref="testcorrunceDto"/>.
    /// </summary>
    public static partial class testcorrunceAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="testcorrunceDto"/> converted from <see cref="testcorrunce"/>.</param>
        static partial void OnDTO(this testcorrunce entity, testcorrunceDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="testcorrunce"/> converted from <see cref="testcorrunceDto"/>.</param>
        static partial void OnEntity(this testcorrunceDto dto, testcorrunce entity);

        /// <summary>
        /// Converts this instance of <see cref="testcorrunceDto"/> to an instance of <see cref="testcorrunce"/>.
        /// </summary>
        /// <param name="dto"><see cref="testcorrunceDto"/> to convert.</param>
        public static testcorrunce ToEntity(this testcorrunceDto dto)
        {
            if (dto == null) return null;

            var entity = new testcorrunce();

            entity.TestConcurrenceId = dto.TestConcurrenceId;
            entity.Value = dto.Value;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="testcorrunce"/> to an instance of <see cref="testcorrunceDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="testcorrunce"/> to convert.</param>
        public static testcorrunceDto ToDTO(this testcorrunce entity)
        {
            if (entity == null) return null;

            var dto = new testcorrunceDto();

            dto.TestConcurrenceId = entity.TestConcurrenceId;
            dto.Value = entity.Value;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="testcorrunceDto"/> to an instance of <see cref="testcorrunce"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<testcorrunce> ToEntities(this IEnumerable<testcorrunceDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="testcorrunce"/> to an instance of <see cref="testcorrunceDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<testcorrunceDto> ToDTOs(this IEnumerable<testcorrunce> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
