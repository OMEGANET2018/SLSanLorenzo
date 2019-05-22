//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/23 - 08:53:57
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
    /// Assembler for <see cref="tramas"/> and <see cref="tramasDto"/>.
    /// </summary>
    public static partial class tramasAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tramasDto"/> converted from <see cref="tramas"/>.</param>
        static partial void OnDTO(this tramas entity, tramasDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tramas"/> converted from <see cref="tramasDto"/>.</param>
        static partial void OnEntity(this tramasDto dto, tramas entity);

        /// <summary>
        /// Converts this instance of <see cref="tramasDto"/> to an instance of <see cref="tramas"/>.
        /// </summary>
        /// <param name="dto"><see cref="tramasDto"/> to convert.</param>
        public static tramas ToEntity(this tramasDto dto)
        {
            if (dto == null) return null;

            var entity = new tramas();

            entity.v_TramaId = dto.v_TramaId;
            entity.v_TipoRegistro = dto.v_TipoRegistro;
            entity.d_FechaIngreso = dto.d_FechaIngreso;
            entity.d_FechaAlta = dto.d_FechaAlta;
            entity.i_Genero = dto.i_Genero;
            entity.i_GrupoEtario = dto.i_GrupoEtario;
            entity.v_DiseasesName = dto.v_DiseasesName;
            entity.v_CIE10Id = dto.v_CIE10Id;
            entity.i_UPS = dto.i_UPS;
            entity.i_Procedimiento = dto.i_Procedimiento;
            entity.i_Especialidad = dto.i_Especialidad;
            entity.i_TipoParto = dto.i_TipoParto;
            entity.i_TipoNacimiento = dto.i_TipoNacimiento;
            entity.i_TipoComplicacion = dto.i_TipoComplicacion;
            entity.i_Programacion = dto.i_Programacion;
            entity.i_TipoCirugia = dto.i_TipoCirugia;
            entity.i_HorasProg = dto.i_HorasProg;
            entity.i_HorasEfect = dto.i_HorasEfect;
            entity.i_HorasActo = dto.i_HorasActo;
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
        /// Converts this instance of <see cref="tramas"/> to an instance of <see cref="tramasDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="tramas"/> to convert.</param>
        public static tramasDto ToDTO(this tramas entity)
        {
            if (entity == null) return null;

            var dto = new tramasDto();

            dto.v_TramaId = entity.v_TramaId;
            dto.v_TipoRegistro = entity.v_TipoRegistro;
            dto.d_FechaIngreso = entity.d_FechaIngreso;
            dto.d_FechaAlta = entity.d_FechaAlta;
            dto.i_Genero = entity.i_Genero;
            dto.i_GrupoEtario = entity.i_GrupoEtario;
            dto.v_DiseasesName = entity.v_DiseasesName;
            dto.v_CIE10Id = entity.v_CIE10Id;
            dto.i_UPS = entity.i_UPS;
            dto.i_Procedimiento = entity.i_Procedimiento;
            dto.i_Especialidad = entity.i_Especialidad;
            dto.i_TipoParto = entity.i_TipoParto;
            dto.i_TipoNacimiento = entity.i_TipoNacimiento;
            dto.i_TipoComplicacion = entity.i_TipoComplicacion;
            dto.i_Programacion = entity.i_Programacion;
            dto.i_TipoCirugia = entity.i_TipoCirugia;
            dto.i_HorasProg = entity.i_HorasProg;
            dto.i_HorasEfect = entity.i_HorasEfect;
            dto.i_HorasActo = entity.i_HorasActo;
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
        /// Converts each instance of <see cref="tramasDto"/> to an instance of <see cref="tramas"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tramas> ToEntities(this IEnumerable<tramasDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tramas"/> to an instance of <see cref="tramasDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tramasDto> ToDTOs(this IEnumerable<tramas> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
