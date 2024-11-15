// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.PowerShell;

    /// <summary>Represents a task to be used in customizing a Dev Box.</summary>
    [System.ComponentModel.TypeConverter(typeof(CustomizationTaskDefinitionTypeConverter))]
    public partial class CustomizationTaskDefinition
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.CustomizationTaskDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomizationTaskDefinition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("CatalogName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).CatalogName = (string) content.GetValueForProperty("CatalogName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).CatalogName, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.CustomizationTaskDefinitionParametersTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.CustomizationTaskDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomizationTaskDefinition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("CatalogName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).CatalogName = (string) content.GetValueForProperty("CatalogName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).CatalogName, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinitionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.CustomizationTaskDefinitionParametersTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.CustomizationTaskDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomizationTaskDefinition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.CustomizationTaskDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomizationTaskDefinition(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomizationTaskDefinition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CustomizationTaskDefinition" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.ICustomizationTaskDefinition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents a task to be used in customizing a Dev Box.
    [System.ComponentModel.TypeConverter(typeof(CustomizationTaskDefinitionTypeConverter))]
    public partial interface ICustomizationTaskDefinition

    {

    }
}