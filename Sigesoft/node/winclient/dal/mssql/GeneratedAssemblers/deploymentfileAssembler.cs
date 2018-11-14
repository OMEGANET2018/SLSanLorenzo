//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/12 - 17:57:38
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
    /// Assembler for <see cref="deploymentfile"/> and <see cref="deploymentfileDto"/>.
    /// </summary>
    public static partial class deploymentfileAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="deploymentfileDto"/> converted from <see cref="deploymentfile"/>.</param>
        static partial void OnDTO(this deploymentfile entity, deploymentfileDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="deploymentfile"/> converted from <see cref="deploymentfileDto"/>.</param>
        static partial void OnEntity(this deploymentfileDto dto, deploymentfile entity);

        /// <summary>
        /// Converts this instance of <see cref="deploymentfileDto"/> to an instance of <see cref="deploymentfile"/>.
        /// </summary>
        /// <param name="dto"><see cref="deploymentfileDto"/> to convert.</param>
        public static deploymentfile ToEntity(this deploymentfileDto dto)
        {
            if (dto == null) return null;

            var entity = new deploymentfile();

            entity.i_DeploymentFileId = dto.i_DeploymentFileId;
            entity.v_FileName = dto.v_FileName;
            entity.b_FileData = dto.b_FileData;
            entity.v_Description = dto.v_Description;
            entity.i_SoftwareComponentId = dto.i_SoftwareComponentId;
            entity.v_TargetSoftwareComponentVersion = dto.v_TargetSoftwareComponentVersion;
            entity.v_PackageFiles = dto.v_PackageFiles;
            entity.r_PackageSizeKb = dto.r_PackageSizeKb;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="deploymentfile"/> to an instance of <see cref="deploymentfileDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="deploymentfile"/> to convert.</param>
        public static deploymentfileDto ToDTO(this deploymentfile entity)
        {
            if (entity == null) return null;

            var dto = new deploymentfileDto();

            dto.i_DeploymentFileId = entity.i_DeploymentFileId;
            dto.v_FileName = entity.v_FileName;
            dto.b_FileData = entity.b_FileData;
            dto.v_Description = entity.v_Description;
            dto.i_SoftwareComponentId = entity.i_SoftwareComponentId;
            dto.v_TargetSoftwareComponentVersion = entity.v_TargetSoftwareComponentVersion;
            dto.v_PackageFiles = entity.v_PackageFiles;
            dto.r_PackageSizeKb = entity.r_PackageSizeKb;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="deploymentfileDto"/> to an instance of <see cref="deploymentfile"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<deploymentfile> ToEntities(this IEnumerable<deploymentfileDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="deploymentfile"/> to an instance of <see cref="deploymentfileDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<deploymentfileDto> ToDTOs(this IEnumerable<deploymentfile> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
