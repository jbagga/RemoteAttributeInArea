// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace RemoteAttributeInArea
{
    public class RemoteAttributeUser
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "UserEmail is required")]
        [Remote(
            action: "IsEmailAvailable",
            controller: "RemoteAttribute_Verify",
            areaName: "Area1",
            ErrorMessage = "/Area1/RemoteAttribute_Verify/IsEmailAvailable rejects you.")]
        public string UserEmail { get; set; }
    }
}
