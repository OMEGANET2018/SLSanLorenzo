//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/09 - 20:48:01
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
    /// Assembler for <see cref="hospitalizacion"/> and <see cref="hospitalizacionDto"/>.
    /// </summary>
    public static partial class hospitalizacionAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="hospitalizacionDto"/> converted from <see cref="hospitalizacion"/>.</param>
        static partial void OnDTO(this hospitalizacion entity, hospitalizacionDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="hospitalizacion"/> converted from <see cref="hospitalizacionDto"/>.</param>
        static partial void OnEntity(this hospitalizacionDto dto, hospitalizacion entity);

        /// <summary>
        /// Converts this instance of <see cref="hospitalizacionDto"/> to an instance of <see cref="hospitalizacion"/>.
        /// </summary>
        /// <param name="dto"><see cref="hospitalizacionDto"/> to convert.</param>
        public static hospitalizacion ToEntity(this hospitalizacionDto dto)
        {
            if (dto == null) return null;

            var entity = new hospitalizacion();

            entity.v_HopitalizacionId = dto.v_HopitalizacionId;
            entity.v_PersonId = dto.v_PersonId;
            entity.d_FechaIngreso = dto.d_FechaIngreso;
            entity.d_FechaAlta = dto.d_FechaAlta;
            entity.v_Comentario = dto.v_Comentario;
            entity.v_NroLiquidacion = dto.v_NroLiquidacion;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.d_PagoMedico = dto.d_PagoMedico;
            entity.i_MedicoPago = dto.i_MedicoPago;
            entity.d_PagoPaciente = dto.d_PagoPaciente;
            entity.i_PacientePago = dto.i_PacientePago;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="hospitalizacion"/> to an instance of <see cref="hospitalizacionDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="hospitalizacion"/> to convert.</param>
        public static hospitalizacionDto ToDTO(this hospitalizacion entity)
        {
            if (entity == null) return null;

            var dto = new hospitalizacionDto();

            dto.v_HopitalizacionId = entity.v_HopitalizacionId;
            dto.v_PersonId = entity.v_PersonId;
            dto.d_FechaIngreso = entity.d_FechaIngreso;
            dto.d_FechaAlta = entity.d_FechaAlta;
            dto.v_Comentario = entity.v_Comentario;
            dto.v_NroLiquidacion = entity.v_NroLiquidacion;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.d_PagoMedico = entity.d_PagoMedico;
            dto.i_MedicoPago = entity.i_MedicoPago;
            dto.d_PagoPaciente = entity.d_PagoPaciente;
            dto.i_PacientePago = entity.i_PacientePago;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="hospitalizacionDto"/> to an instance of <see cref="hospitalizacion"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<hospitalizacion> ToEntities(this IEnumerable<hospitalizacionDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="hospitalizacion"/> to an instance of <see cref="hospitalizacionDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<hospitalizacionDto> ToDTOs(this IEnumerable<hospitalizacion> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
