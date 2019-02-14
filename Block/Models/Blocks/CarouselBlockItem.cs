using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
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
            Name = "Header",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "SubHeader",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string SubHeader { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Text",
           GroupName = SystemTabNames.Content,
           Order = 4)]

        public virtual XhtmlString Text { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Url",
          GroupName = SystemTabNames.Content,
          Order = 5)]
        public virtual Url Url { get; set; }

    }
}