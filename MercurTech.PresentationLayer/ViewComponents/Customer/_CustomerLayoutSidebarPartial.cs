﻿using Microsoft.AspNetCore.Mvc;

namespace MercurTech.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
