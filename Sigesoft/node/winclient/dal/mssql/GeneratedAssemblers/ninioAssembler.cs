//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/25 - 12:35:29
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
    /// Assembler for <see cref="ninio"/> and <see cref="ninioDto"/>.
    /// </summary>
    public static partial class ninioAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="ninioDto"/> converted from <see cref="ninio"/>.</param>
        static partial void OnDTO(this ninio entity, ninioDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="ninio"/> converted from <see cref="ninioDto"/>.</param>
        static partial void OnEntity(this ninioDto dto, ninio entity);

        /// <summary>
        /// Converts this instance of <see cref="ninioDto"/> to an instance of <see cref="ninio"/>.
        /// </summary>
        /// <param name="dto"><see cref="ninioDto"/> to convert.</param>
        public static ninio ToEntity(this ninioDto dto)
        {
            if (dto == null) return null;

            var entity = new ninio();

            entity.v_NinioId = dto.v_NinioId;
            entity.v_PersonId = dto.v_PersonId;
            entity.v_NombrePadre = dto.v_NombrePadre;
            entity.v_EdadPadre = dto.v_EdadPadre;
            entity.v_DniPadre = dto.v_DniPadre;
            entity.i_TipoAfiliacionPadre = dto.i_TipoAfiliacionPadre;
            entity.v_CodigoAfiliacionPadre = dto.v_CodigoAfiliacionPadre;
            entity.i_GradoInstruccionPadre = dto.i_GradoInstruccionPadre;
            entity.v_OcupacionPadre = dto.v_OcupacionPadre;
            entity.i_EstadoCivilIdPadre = dto.i_EstadoCivilIdPadre;
            entity.v_ReligionPadre = dto.v_ReligionPadre;
            entity.v_NombreMadre = dto.v_NombreMadre;
            entity.v_EdadMadre = dto.v_EdadMadre;
            entity.v_DniMadre = dto.v_DniMadre;
            entity.i_TipoAfiliacionMadre = dto.i_TipoAfiliacionMadre;
            entity.v_CodigoAfiliacionMadre = dto.v_CodigoAfiliacionMadre;
            entity.i_GradoInstruccionMadre = dto.i_GradoInstruccionMadre;
            entity.v_OcupacionMadre = dto.v_OcupacionMadre;
            entity.i_EstadoCivilIdMadre1 = dto.i_EstadoCivilIdMadre1;
            entity.v_ReligionMadre = dto.v_ReligionMadre;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="ninio"/> to an instance of <see cref="ninioDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="ninio"/> to convert.</param>
        public static ninioDto ToDTO(this ninio entity)
        {
            if (entity == null) return null;

            var dto = new ninioDto();

            dto.v_NinioId = entity.v_NinioId;
            dto.v_PersonId = entity.v_PersonId;
            dto.v_NombrePadre = entity.v_NombrePadre;
            dto.v_EdadPadre = entity.v_EdadPadre;
            dto.v_DniPadre = entity.v_DniPadre;
            dto.i_TipoAfiliacionPadre = entity.i_TipoAfiliacionPadre;
            dto.v_CodigoAfiliacionPadre = entity.v_CodigoAfiliacionPadre;
            dto.i_GradoInstruccionPadre = entity.i_GradoInstruccionPadre;
            dto.v_OcupacionPadre = entity.v_OcupacionPadre;
            dto.i_EstadoCivilIdPadre = entity.i_EstadoCivilIdPadre;
            dto.v_ReligionPadre = entity.v_ReligionPadre;
            dto.v_NombreMadre = entity.v_NombreMadre;
            dto.v_EdadMadre = entity.v_EdadMadre;
            dto.v_DniMadre = entity.v_DniMadre;
            dto.i_TipoAfiliacionMadre = entity.i_TipoAfiliacionMadre;
            dto.v_CodigoAfiliacionMadre = entity.v_CodigoAfiliacionMadre;
            dto.i_GradoInstruccionMadre = entity.i_GradoInstruccionMadre;
            dto.v_OcupacionMadre = entity.v_OcupacionMadre;
            dto.i_EstadoCivilIdMadre1 = entity.i_EstadoCivilIdMadre1;
            dto.v_ReligionMadre = entity.v_ReligionMadre;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="ninioDto"/> to an instance of <see cref="ninio"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<ninio> ToEntities(this IEnumerable<ninioDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="ninio"/> to an instance of <see cref="ninioDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<ninioDto> ToDTOs(this IEnumerable<ninio> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
