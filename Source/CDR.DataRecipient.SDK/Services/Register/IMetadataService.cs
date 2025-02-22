﻿using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CDR.DataRecipient.SDK.Models;

namespace CDR.DataRecipient.SDK.Services.Register
{
    public interface IMetadataService
    {
        Task<Response<IList<DataHolderBrand>>> GetDataHolderBrands(
            string registerMtlsBaseUri,
            string version,
            string accessToken,
            X509Certificate2 clientCertificate,
            string softwareProductId,
            int? page = null,
            int? pageSize = null);
    }
}
