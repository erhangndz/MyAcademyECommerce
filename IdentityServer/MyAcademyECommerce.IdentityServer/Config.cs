// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace MyAcademyECommerce.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("ResourceCatalog"){Scopes={"CatalogFullPermission"} },
            new ApiResource("ResourceReadCatalog"){Scopes={"CatalogReadPermission" } },
            new ApiResource("ResourceDiscount"){Scopes={"DiscountReadPermission","DiscountCreatePermission" } },
            new ApiResource("ResourceDiscountFull"){Scopes={"DiscountFullPermission" } },
            new ApiResource("ResourceOrderEdit"){Scopes={"OrderEditPermission" } },
            new ApiResource("ResourceOrderFull"){Scopes={"OrderFullPermission" } },
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };


        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermission","Full Authority for Catalog Operations"),
            new ApiScope("CatalogReadPermission","Catalog Read Authority for Catalog Read Operations")




        };

    }
}
