//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/30 - 10:17:13
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
    /// Assembler for <see cref="adolescente"/> and <see cref="adolescenteDto"/>.
    /// </summary>
    public static partial class adolescenteAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="adolescenteDto"/> converted from <see cref="adolescente"/>.</param>
        static partial void OnDTO(this adolescente entity, adolescenteDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="adolescente"/> converted from <see cref="adolescenteDto"/>.</param>
        static partial void OnEntity(this adolescenteDto dto, adolescente entity);

        /// <summary>
        /// Converts this instance of <see cref="adolescenteDto"/> to an instance of <see cref="adolescente"/>.
        /// </summary>
        /// <param name="dto"><see cref="adolescenteDto"/> to convert.</param>
        public static adolescente ToEntity(this adolescenteDto dto)
        {
            if (dto == null) return null;

            var entity = new adolescente();

            entity.v_AdolescenteId = dto.v_AdolescenteId;
            entity.v_PersonId = dto.v_PersonId;
            entity.v_EdadInicioTrabajo = dto.v_EdadInicioTrabajo;
            entity.v_TipoTrabajo = dto.v_TipoTrabajo;
            entity.v_NroHorasTv = dto.v_NroHorasTv;
            entity.v_NroHorasJuegos = dto.v_NroHorasJuegos;
            entity.v_MenarquiaEspermarquia = dto.v_MenarquiaEspermarquia;
            entity.v_EdadInicioRS = dto.v_EdadInicioRS;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.v_NombreCuidador = dto.v_NombreCuidador;
            entity.v_EdadCuidador = dto.v_EdadCuidador;
            entity.v_DniCuidador = dto.v_DniCuidador;
            entity.v_ViveCon = dto.v_ViveCon;
            entity.v_Observaciones = dto.v_Observaciones;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="adolescente"/> to an instance of <see cref="adolescenteDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="adolescente"/> to convert.</param>
        public static adolescenteDto ToDTO(this adolescente entity)
        {
            if (entity == null) return null;

            var dto = new adolescenteDto();

            dto.v_AdolescenteId = entity.v_AdolescenteId;
            dto.v_PersonId = entity.v_PersonId;
            dto.v_EdadInicioTrabajo = entity.v_EdadInicioTrabajo;
            dto.v_TipoTrabajo = entity.v_TipoTrabajo;
            dto.v_NroHorasTv = entity.v_NroHorasTv;
            dto.v_NroHorasJuegos = entity.v_NroHorasJuegos;
            dto.v_MenarquiaEspermarquia = entity.v_MenarquiaEspermarquia;
            dto.v_EdadInicioRS = entity.v_EdadInicioRS;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.v_NombreCuidador = entity.v_NombreCuidador;
            dto.v_EdadCuidador = entity.v_EdadCuidador;
            dto.v_DniCuidador = entity.v_DniCuidador;
            dto.v_ViveCon = entity.v_ViveCon;
            dto.v_Observaciones = entity.v_Observaciones;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="adolescenteDto"/> to an instance of <see cref="adolescente"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<adolescente> ToEntities(this IEnumerable<adolescenteDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="adolescente"/> to an instance of <see cref="adolescenteDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<adolescenteDto> ToDTOs(this IEnumerable<adolescente> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
