//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/10 - 15:12:05
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
    /// Assembler for <see cref="identitystring"/> and <see cref="identitystringDto"/>.
    /// </summary>
    public static partial class identitystringAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="identitystringDto"/> converted from <see cref="identitystring"/>.</param>
        static partial void OnDTO(this identitystring entity, identitystringDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="identitystring"/> converted from <see cref="identitystringDto"/>.</param>
        static partial void OnEntity(this identitystringDto dto, identitystring entity);

        /// <summary>
        /// Converts this instance of <see cref="identitystringDto"/> to an instance of <see cref="identitystring"/>.
        /// </summary>
        /// <param name="dto"><see cref="identitystringDto"/> to convert.</param>
        public static identitystring ToEntity(this identitystringDto dto)
        {
            if (dto == null) return null;

            var entity = new identitystring();

            entity.Id = dto.Id;
            entity.CombinedId = dto.CombinedId;
            entity.Nombre = dto.Nombre;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="identitystring"/> to an instance of <see cref="identitystringDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="identitystring"/> to convert.</param>
        public static identitystringDto ToDTO(this identitystring entity)
        {
            if (entity == null) return null;

            var dto = new identitystringDto();

            dto.Id = entity.Id;
            dto.CombinedId = entity.CombinedId;
            dto.Nombre = entity.Nombre;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="identitystringDto"/> to an instance of <see cref="identitystring"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<identitystring> ToEntities(this IEnumerable<identitystringDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="identitystring"/> to an instance of <see cref="identitystringDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<identitystringDto> ToDTOs(this IEnumerable<identitystring> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
