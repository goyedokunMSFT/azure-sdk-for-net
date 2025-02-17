// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The language extension object. </summary>
    public partial class SynapseLanguageExtension
    {
        /// <summary> Initializes a new instance of SynapseLanguageExtension. </summary>
        public SynapseLanguageExtension()
        {
        }

        /// <summary> Initializes a new instance of SynapseLanguageExtension. </summary>
        /// <param name="languageExtensionName"> The language extension name. </param>
        internal SynapseLanguageExtension(SynapseLanguageExtensionName? languageExtensionName)
        {
            LanguageExtensionName = languageExtensionName;
        }

        /// <summary> The language extension name. </summary>
        public SynapseLanguageExtensionName? LanguageExtensionName { get; set; }
    }
}
