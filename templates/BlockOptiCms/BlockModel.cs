using Episerver;
using Episerver.Core;
using EPiServer.DataAnnotations;

namespace OptiTemplates.Models.Blocks
{
    /// <summary>
    /// BlockModel 
    /// </summary>
    [ContentType(GUID = "BlockGuid")]
    [ImageUrl]
    public class BlockModel : BlockData
    {

    }
}