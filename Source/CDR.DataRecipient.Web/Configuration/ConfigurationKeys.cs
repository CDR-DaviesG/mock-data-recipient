﻿namespace CDR.DataRecipient.Web.Configuration
{
    public static class ConfigurationKeys
    {
        public const string REGISTER = "MockDataRecipient:Register";
        public const string REGISTER_TLS_BASE_URI = "MockDataRecipient:Register:tlsBaseUri";
        public const string REGISTER_MTLS_BASE_URI = "MockDataRecipient:Register:mtlsBaseUri";
        public const string REGISTER_OIDC_DISCOVERY_URI = "MockDataRecipient:Register:oidcDiscoveryUri";

        public const string SOFTWARE_PRODUCT = "MockDataRecipient:SoftwareProduct";
        public const string SOFTWARE_PRODUCT_ID = "MockDataRecipient:SoftwareProduct:softwareProductId";
        public const string SOFTWARE_PRODUCT_BRAND_ID = "MockDataRecipient:SoftwareProduct:brandId";
        public const string SOFTWARE_PRODUCT_JWKS_URI = "MockDataRecipient:SoftwareProduct:jwksUri";
        public const string SOFTWARE_PRODUCT_REDIRECT_URIS = "MockDataRecipient:SoftwareProduct:redirectUris";

        public const string DEFAULT_DATA_HOLDER = "MockDataRecipient:DataHolder";
        public const string DEFAULT_DATA_HOLDER_REGISTRATION_ENDPOINT = "MockDataRecipient:DataHolder:registrationEndpoint";
        public const string DEFAULT_DATA_HOLDER_OIDC_DISCOVERY_URI = "MockDataRecipient:DataHolder:oidcDiscoveryUri";
        public const string DEFAULT_DATA_HOLDER_JWKS_URI = "MockDataRecipient:DataHolder:jwksUri";
        
        public const string DEFAULT_PAGE_SIZE = "MockDataRecipient:Paging:DefaultPageSize";
    }
}
