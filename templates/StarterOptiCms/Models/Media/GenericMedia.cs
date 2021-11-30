using System;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace StarterOptiCms.Models.Media
{
    [ContentType(GUID = "GenericMediaGUID")]
    public class GenericMedia : MediaData
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public virtual String Description { get; set; }
    }
}