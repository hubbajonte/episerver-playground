using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Block.Models.Blocks
{
    [ContentType(DisplayName = "Carousel Block Item", GUID = "3afed2b7-c199-4504-a940-1096f14dac80", Description = "Used to represent a single item in a Carousel")]
    [AvailableContentTypes(Availability.Specific, IncludeOn = new[] { typeof(CarouselBlock) })]
    public class CarouselBlockItem : BlockData
    {
        [Display(
            Name = "Background Image",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackgroundImage { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Title",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Subtitle",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string Subtitle { get; set; }
    }
}