﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace NuGetGallery
{
    public class PackageTypeEntity
        : IEntity
    {
        public Package Package { get; set; }
        public int PackageKey { get; set; }

        /// <remarks>
        ///     Has a max length of 4000. Is not indexed and not used for searches. Db column is nvarchar(max).
        /// </remarks>
        public string Name { get; set; }

        public string Version { get; set; }

        [Key]
        public int Key { get; set; }
    }
}