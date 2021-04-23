// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Azure.WebJobs.Extensions.Storage.Blobs
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using global::Azure.Storage.Blobs.Specialized;

    /// <summary>
    /// This type should ideally be not part of extension.
    /// </summary>
    public class BlobAndStream
    {
        /// <summary>
        /// TODO.
        /// </summary>
        public Stream BlobStream { get; set; }

        /// <summary>
        /// TODO.
        /// </summary>
        public BlobBaseClient Client { get; set; }
    }
}
