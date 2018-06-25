//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/25 - 17:06:57
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
    /// Assembler for <see cref="nodedatabasestatus"/> and <see cref="nodedatabasestatusDto"/>.
    /// </summary>
    public static partial class nodedatabasestatusAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="nodedatabasestatusDto"/> converted from <see cref="nodedatabasestatus"/>.</param>
        static partial void OnDTO(this nodedatabasestatus entity, nodedatabasestatusDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="nodedatabasestatus"/> converted from <see cref="nodedatabasestatusDto"/>.</param>
        static partial void OnEntity(this nodedatabasestatusDto dto, nodedatabasestatus entity);

        /// <summary>
        /// Converts this instance of <see cref="nodedatabasestatusDto"/> to an instance of <see cref="nodedatabasestatus"/>.
        /// </summary>
        /// <param name="dto"><see cref="nodedatabasestatusDto"/> to convert.</param>
        public static nodedatabasestatus ToEntity(this nodedatabasestatusDto dto)
        {
            if (dto == null) return null;

            var entity = new nodedatabasestatus();

            entity.i_NodeId = dto.i_NodeId;
            entity.v_CurrentDatabaseVersion = dto.v_CurrentDatabaseVersion;
            entity.v_PreviousDatabaseVersion = dto.v_PreviousDatabaseVersion;
            entity.i_CurrentDatabaseStatus = dto.i_CurrentDatabaseStatus;
            entity.d_LastDatabaseUpgrade = dto.d_LastDatabaseUpgrade;
            entity.d_LastDatabaseDataSync = dto.d_LastDatabaseDataSync;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="nodedatabasestatus"/> to an instance of <see cref="nodedatabasestatusDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="nodedatabasestatus"/> to convert.</param>
        public static nodedatabasestatusDto ToDTO(this nodedatabasestatus entity)
        {
            if (entity == null) return null;

            var dto = new nodedatabasestatusDto();

            dto.i_NodeId = entity.i_NodeId;
            dto.v_CurrentDatabaseVersion = entity.v_CurrentDatabaseVersion;
            dto.v_PreviousDatabaseVersion = entity.v_PreviousDatabaseVersion;
            dto.i_CurrentDatabaseStatus = entity.i_CurrentDatabaseStatus;
            dto.d_LastDatabaseUpgrade = entity.d_LastDatabaseUpgrade;
            dto.d_LastDatabaseDataSync = entity.d_LastDatabaseDataSync;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="nodedatabasestatusDto"/> to an instance of <see cref="nodedatabasestatus"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<nodedatabasestatus> ToEntities(this IEnumerable<nodedatabasestatusDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="nodedatabasestatus"/> to an instance of <see cref="nodedatabasestatusDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<nodedatabasestatusDto> ToDTOs(this IEnumerable<nodedatabasestatus> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
