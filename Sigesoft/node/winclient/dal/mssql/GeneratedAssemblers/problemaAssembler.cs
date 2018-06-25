//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/25 - 15:48:49
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
    /// Assembler for <see cref="problema"/> and <see cref="problemaDto"/>.
    /// </summary>
    public static partial class problemaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="problemaDto"/> converted from <see cref="problema"/>.</param>
        static partial void OnDTO(this problema entity, problemaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="problema"/> converted from <see cref="problemaDto"/>.</param>
        static partial void OnEntity(this problemaDto dto, problema entity);

        /// <summary>
        /// Converts this instance of <see cref="problemaDto"/> to an instance of <see cref="problema"/>.
        /// </summary>
        /// <param name="dto"><see cref="problemaDto"/> to convert.</param>
        public static problema ToEntity(this problemaDto dto)
        {
            if (dto == null) return null;

            var entity = new problema();

            entity.v_ProblemaId = dto.v_ProblemaId;
            entity.i_Tipo = dto.i_Tipo;
            entity.v_PersonId = dto.v_PersonId;
            entity.d_Fecha = dto.d_Fecha;
            entity.v_Descripcion = dto.v_Descripcion;
            entity.i_EsControlado = dto.i_EsControlado;
            entity.v_Observacion = dto.v_Observacion;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="problema"/> to an instance of <see cref="problemaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="problema"/> to convert.</param>
        public static problemaDto ToDTO(this problema entity)
        {
            if (entity == null) return null;

            var dto = new problemaDto();

            dto.v_ProblemaId = entity.v_ProblemaId;
            dto.i_Tipo = entity.i_Tipo;
            dto.v_PersonId = entity.v_PersonId;
            dto.d_Fecha = entity.d_Fecha;
            dto.v_Descripcion = entity.v_Descripcion;
            dto.i_EsControlado = entity.i_EsControlado;
            dto.v_Observacion = entity.v_Observacion;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="problemaDto"/> to an instance of <see cref="problema"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<problema> ToEntities(this IEnumerable<problemaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="problema"/> to an instance of <see cref="problemaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<problemaDto> ToDTOs(this IEnumerable<problema> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
