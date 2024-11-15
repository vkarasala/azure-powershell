// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Extensions;

    /// <summary>Gets or sets the provider specific properties.</summary>
    public partial class ProviderSpecificProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ProviderType" /> property.</summary>
        private string _providerType;

        /// <summary>The provider type. For example, the value can be SapHana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string ProviderType { get => this._providerType; set => this._providerType = value; }

        /// <summary>Creates an new <see cref="ProviderSpecificProperties" /> instance.</summary>
        public ProviderSpecificProperties()
        {

        }
    }
    /// Gets or sets the provider specific properties.
    public partial interface IProviderSpecificProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IJsonSerializable
    {
        /// <summary>The provider type. For example, the value can be SapHana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The provider type. For example, the value can be SapHana.",
        SerializedName = @"providerType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderType { get; set; }

    }
    /// Gets or sets the provider specific properties.
    internal partial interface IProviderSpecificPropertiesInternal

    {
        /// <summary>The provider type. For example, the value can be SapHana.</summary>
        string ProviderType { get; set; }

    }
}