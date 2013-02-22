﻿using System;
using System.Collections.Generic;
using System.Linq;
using MvcSiteMapProvider.Collections;

namespace MvcSiteMapProvider
{
    /// <summary>
    /// Specialized string collection for providing business logic that manages
    /// the behavior of the roles.
    /// </summary>
    public class RoleCollection
        : LockableList<string>, IRoleCollection
    {
        public RoleCollection(
            ISiteMap siteMap
            )
            : base(siteMap)
        {
        }
    }
}