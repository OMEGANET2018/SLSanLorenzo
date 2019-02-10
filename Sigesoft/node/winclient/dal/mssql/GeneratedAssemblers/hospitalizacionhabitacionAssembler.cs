//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/02 - 16:09:22
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
    /// Assembler for <see cref="hospitalizacionhabitacion"/> and <see cref="hospitalizacionhabitacionDto"/>.
    /// </summary>
    public static partial class hospitalizacionhabitacionAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="hospitalizacionhabitacionDto"/> converted from <see cref="hospitalizacionhabitacion"/>.</param>
        static partial void OnDTO(this hospitalizacionhabitacion entity, hospitalizacionhabitacionDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="hospitalizacionhabitacion"/> converted from <see cref="hospitalizacionhabitacionDto"/>.</param>
        static partial void OnEntity(this hospitalizacionhabitacionDto dto, hospitalizacionhabitacion entity);

        /// <summary>
        /// Converts this instance of <see cref="hospitalizacionhabitacionDto"/> to an instance of <see cref="hospitalizacionhabitacion"/>.
        /// </summary>
        /// <param name="dto"><see cref="hospitalizacionhabitacionDto"/> to convert.</param>
        public static hospitalizacionhabitacion ToEntity(this hospitalizacionhabitacionDto dto)
        {
            if (dto == null) return null;

            var entity = new hospitalizacionhabitacion();

            entity.v_HospitalizacionHabitacionId = dto.v_HospitalizacionHabitacionId;
            entity.v_HopitalizacionId = dto.v_HopitalizacionId;
            entity.i_HabitacionId = dto.i_HabitacionId;
            entity.d_StartDate = dto.d_StartDate;
            entity.d_EndDate = dto.d_EndDate;
            entity.d_Precio = dto.d_Precio;
            entity.i_ConCargoA = dto.i_ConCargoA;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="hospitalizacionhabitacion"/> to an instance of <see cref="hospitalizacionhabitacionDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="hospitalizacionhabitacion"/> to convert.</param>
        public static hospitalizacionhabitacionDto ToDTO(this hospitalizacionhabitacion entity)
        {
            if (entity == null) return null;

            var dto = new hospitalizacionhabitacionDto();

            dto.v_HospitalizacionHabitacionId = entity.v_HospitalizacionHabitacionId;
            dto.v_HopitalizacionId = entity.v_HopitalizacionId;
            dto.i_HabitacionId = entity.i_HabitacionId;
            dto.d_StartDate = entity.d_StartDate;
            dto.d_EndDate = entity.d_EndDate;
            dto.d_Precio = entity.d_Precio;
            dto.i_ConCargoA = entity.i_ConCargoA;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="hospitalizacionhabitacionDto"/> to an instance of <see cref="hospitalizacionhabitacion"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<hospitalizacionhabitacion> ToEntities(this IEnumerable<hospitalizacionhabitacionDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="hospitalizacionhabitacion"/> to an instance of <see cref="hospitalizacionhabitacionDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<hospitalizacionhabitacionDto> ToDTOs(this IEnumerable<hospitalizacionhabitacion> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
