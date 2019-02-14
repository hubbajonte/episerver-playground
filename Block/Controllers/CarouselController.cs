using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Block.Models.Blocks;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace Block.Controllers
{
    public class CarouselController : BlockController<CarouselBlock>
    {
        public override ActionResult Index(CarouselBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
