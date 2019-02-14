using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Block.Models.Blocks
{
    [ContentType(DisplayName = "DefaultBlock1", GUID = "dd447a83-490c-4476-84a2-038c7251632d", Description = "")]
    public class DefaultBlock1 : BlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}