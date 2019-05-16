//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/16 - 16:36:14
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
    /// Assembler for <see cref="workstationdangers"/> and <see cref="workstationdangersDto"/>.
    /// </summary>
    public static partial class workstationdangersAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="workstationdangersDto"/> converted from <see cref="workstationdangers"/>.</param>
        static partial void OnDTO(this workstationdangers entity, workstationdangersDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="workstationdangers"/> converted from <see cref="workstationdangersDto"/>.</param>
        static partial void OnEntity(this workstationdangersDto dto, workstationdangers entity);

        /// <summary>
        /// Converts this instance of <see cref="workstationdangersDto"/> to an instance of <see cref="workstationdangers"/>.
        /// </summary>
        /// <param name="dto"><see cref="workstationdangersDto"/> to convert.</param>
        public static workstationdangers ToEntity(this workstationdangersDto dto)
        {
            if (dto == null) return null;

            var entity = new workstationdangers();

            entity.v_WorkstationDangersId = dto.v_WorkstationDangersId;
            entity.v_HistoryId = dto.v_HistoryId;
            entity.i_DangerId = dto.i_DangerId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.i_NoiseSource = dto.i_NoiseSource;
            entity.i_NoiseLevel = dto.i_NoiseLevel;
            entity.v_TimeOfExposureToNoise = dto.v_TimeOfExposureToNoise;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="workstationdangers"/> to an instance of <see cref="workstationdangersDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="workstationdangers"/> to convert.</param>
        public static workstationdangersDto ToDTO(this workstationdangers entity)
        {
            if (entity == null) return null;

            var dto = new workstationdangersDto();

            dto.v_WorkstationDangersId = entity.v_WorkstationDangersId;
            dto.v_HistoryId = entity.v_HistoryId;
            dto.i_DangerId = entity.i_DangerId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.i_NoiseSource = entity.i_NoiseSource;
            dto.i_NoiseLevel = entity.i_NoiseLevel;
            dto.v_TimeOfExposureToNoise = entity.v_TimeOfExposureToNoise;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="workstationdangersDto"/> to an instance of <see cref="workstationdangers"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<workstationdangers> ToEntities(this IEnumerable<workstationdangersDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="workstationdangers"/> to an instance of <see cref="workstationdangersDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<workstationdangersDto> ToDTOs(this IEnumerable<workstationdangers> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
