// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// The details and data returned from downloading a blob.
    /// </summary>
    public class BlobDownloadDataResult
    {
        /// <summary>
        /// Internal flattened property representation
        /// </summary>
        internal FlattenedDownloadProperties _flattened;

        /// <summary>
        /// The blob's type.
        /// </summary>
        public BlobType BlobType => _flattened.BlobType;

        /// <summary>
        /// The number of bytes present in the response body.
        /// </summary>
        public long ContentLength => _flattened.ContentLength;

        /// <summary>
        /// The media type of the body of the response. For Download Blob this is 'application/octet-stream'
        /// </summary>
        public string ContentType => _flattened.ContentType;

        /// <summary>
        /// If the blob has an MD5 hash and this operation is to read the full blob, this response header is returned so that the client can check for message content integrity.
        /// </summary>
#pragma warning disable CA1819 // Properties should not return arrays
        public byte[] ContentHash => _flattened.ContentHash;
#pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// Details returned when downloading a Blob
        /// </summary>
        public BlobDownloadDetails Details { get; private set; }

        /// <summary>
        /// Data.
        /// </summary>
        public BinaryData Data { get; private set; }

        internal BlobDownloadDataResult(BlobDownloadInfo blobDownloadInfo, BinaryData data)
        {
            _flattened = blobDownloadInfo._flattened;
            Details = blobDownloadInfo.Details;
            Data = data;
        }
    }
}
