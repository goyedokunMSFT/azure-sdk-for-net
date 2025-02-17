// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub WnsCredential. </summary>
    public partial class NotificationHubWnsCredential
    {
        /// <summary> Initializes a new instance of NotificationHubWnsCredential. </summary>
        public NotificationHubWnsCredential()
        {
        }

        /// <summary> Initializes a new instance of NotificationHubWnsCredential. </summary>
        /// <param name="packageSid"> The package ID for this credential. </param>
        /// <param name="secretKey"> The secret key. </param>
        /// <param name="windowsLiveEndpoint"> The Windows Live endpoint. </param>
        internal NotificationHubWnsCredential(string packageSid, string secretKey, Uri windowsLiveEndpoint)
        {
            PackageSid = packageSid;
            SecretKey = secretKey;
            WindowsLiveEndpoint = windowsLiveEndpoint;
        }

        /// <summary> The package ID for this credential. </summary>
        public string PackageSid { get; set; }
        /// <summary> The secret key. </summary>
        public string SecretKey { get; set; }
        /// <summary> The Windows Live endpoint. </summary>
        public Uri WindowsLiveEndpoint { get; set; }
    }
}
