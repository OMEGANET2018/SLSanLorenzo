//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/07/20 - 12:53:19
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
    /// Assembler for <see cref="habitacionservicio"/> and <see cref="habitacionservicioDto"/>.
    /// </summary>
    public static partial class habitacionservicioAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="habitacionservicioDto"/> converted from <see cref="habitacionservicio"/>.</param>
        static partial void OnDTO(this habitacionservicio entity, habitacionservicioDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="habitacionservicio"/> converted from <see cref="habitacionservicioDto"/>.</param>
        static partial void OnEntity(this habitacionservicioDto dto, habitacionservicio entity);

        /// <summary>
        /// Converts this instance of <see cref="habitacionservicioDto"/> to an instance of <see cref="habitacionservicio"/>.
        /// </summary>
        /// <param name="dto"><see cref="habitacionservicioDto"/> to convert.</param>
        public static habitacionservicio ToEntity(this habitacionservicioDto dto)
        {
            if (dto == null) return null;

            var entity = new habitacionservicio();

            entity.v_HabitacionServicioId = dto.v_HabitacionServicioId;
            entity.v_ServiceId = dto.v_ServiceId;
            entity.i_HabitacionId = dto.i_HabitacionId;
            entity.d_FechaInicio = dto.d_FechaInicio;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="habitacionservicio"/> to an instance of <see cref="habitacionservicioDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="habitacionservicio"/> to convert.</param>
        public static habitacionservicioDto ToDTO(this habitacionservicio entity)
        {
            if (entity == null) return null;

            var dto = new habitacionservicioDto();

            dto.v_HabitacionServicioId = entity.v_HabitacionServicioId;
            dto.v_ServiceId = entity.v_ServiceId;
            dto.i_HabitacionId = entity.i_HabitacionId;
            dto.d_FechaInicio = entity.d_FechaInicio;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="habitacionservicioDto"/> to an instance of <see cref="habitacionservicio"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<habitacionservicio> ToEntities(this IEnumerable<habitacionservicioDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="habitacionservicio"/> to an instance of <see cref="habitacionservicioDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<habitacionservicioDto> ToDTOs(this IEnumerable<habitacionservicio> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
