// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a list of Experiment resources and a link for pagination.</summary>
    public partial class ExperimentListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperiment> Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to retrieve the next page of Experiment resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperiment> _value;

        /// <summary>List of Experiment resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperiment> Value { get => this._value; }

        /// <summary>Creates an new <see cref="ExperimentListResult" /> instance.</summary>
        public ExperimentListResult()
        {

        }
    }
    /// Model that represents a list of Experiment resources and a link for pagination.
    public partial interface IExperimentListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>URL to retrieve the next page of Experiment resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"URL to retrieve the next page of Experiment resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of Experiment resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of Experiment resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperiment) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperiment> Value { get;  }

    }
    /// Model that represents a list of Experiment resources and a link for pagination.
    internal partial interface IExperimentListResultInternal

    {
        /// <summary>URL to retrieve the next page of Experiment resources.</summary>
        string NextLink { get; set; }
        /// <summary>List of Experiment resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperiment> Value { get; set; }

    }
}