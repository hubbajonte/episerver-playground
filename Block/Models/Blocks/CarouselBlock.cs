using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Block.Models.Blocks
{
   [ContentType(DisplayName = "Carousel Block", 
	GUID = "419a365c-d6dc-4258-a777-294973fd4580", 
	Description = "Used to display a Carousel")]
public class CarouselBlock : BlockData
{
	[Display(
		Name = "Carousel Items",
		GroupName = SystemTabNames.Content,
		Order = 1)]
	[AllowedTypes(typeof(CarouselBlockItem))]
	public virtual ContentArea Items { get; set; }
}
}