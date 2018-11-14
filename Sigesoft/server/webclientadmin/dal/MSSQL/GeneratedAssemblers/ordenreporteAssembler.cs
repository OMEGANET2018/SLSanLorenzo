//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/10 - 09:34:15
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Sigesoft.Server.WebClientAdmin.DAL;

namespace Sigesoft.Server.WebClientAdmin.BE
{

    /// <summary>
    /// Assembler for <see cref="ordenreporte"/> and <see cref="ordenreporteDto"/>.
    /// </summary>
    public static partial class ordenreporteAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="ordenreporteDto"/> converted from <see cref="ordenreporte"/>.</param>
        static partial void OnDTO(this ordenreporte entity, ordenreporteDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="ordenreporte"/> converted from <see cref="ordenreporteDto"/>.</param>
        static partial void OnEntity(this ordenreporteDto dto, ordenreporte entity);

        /// <summary>
        /// Converts this instance of <see cref="ordenreporteDto"/> to an instance of <see cref="ordenreporte"/>.
        /// </summary>
        /// <param name="dto"><see cref="ordenreporteDto"/> to convert.</param>
        public static ordenreporte ToEntity(this ordenreporteDto dto)
        {
            if (dto == null) return null;

            var entity = new ordenreporte();

            entity.v_OrdenReporteId = dto.v_OrdenReporteId;
            entity.v_OrganizationId = dto.v_OrganizationId;
            entity.v_NombreReporte = dto.v_NombreReporte;
            entity.v_ComponenteId = dto.v_ComponenteId;
            entity.i_Orden = dto.i_Orden;
            entity.v_NombreCrystal = dto.v_NombreCrystal;
            entity.i_NombreCrystalId = dto.i_NombreCrystalId;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="ordenreporte"/> to an instance of <see cref="ordenreporteDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="ordenreporte"/> to convert.</param>
        public static ordenreporteDto ToDTO(this ordenreporte entity)
        {
            if (entity == null) return null;

            var dto = new ordenreporteDto();

            dto.v_OrdenReporteId = entity.v_OrdenReporteId;
            dto.v_OrganizationId = entity.v_OrganizationId;
            dto.v_NombreReporte = entity.v_NombreReporte;
            dto.v_ComponenteId = entity.v_ComponenteId;
            dto.i_Orden = entity.i_Orden;
            dto.v_NombreCrystal = entity.v_NombreCrystal;
            dto.i_NombreCrystalId = entity.i_NombreCrystalId;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="ordenreporteDto"/> to an instance of <see cref="ordenreporte"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<ordenreporte> ToEntities(this IEnumerable<ordenreporteDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="ordenreporte"/> to an instance of <see cref="ordenreporteDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<ordenreporteDto> ToDTOs(this IEnumerable<ordenreporte> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
