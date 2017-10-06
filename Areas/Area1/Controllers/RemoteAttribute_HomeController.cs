// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace RemoteAttributeInArea
{
    [Area("Area1")]
    [Route("FormArea")]
    public class RemoteAttribute_HomeController : Controller
    {
        private static RemoteAttributeUser _user;

        [HttpGet]
        [Route("AreaAction")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RemoteAttributeUser user)
        {
            ModelState.Remove("id");
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            _user = user;
            return RedirectToAction(nameof(Details));
        }

        public IActionResult Details()
        {
            return View(_user);
        }
    }
}
