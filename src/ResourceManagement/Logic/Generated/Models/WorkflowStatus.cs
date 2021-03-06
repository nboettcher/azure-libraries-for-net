// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WorkflowStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowStatus
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Paused")]
        Paused,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Waiting")]
        Waiting,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Skipped")]
        Skipped,
        [EnumMember(Value = "Suspended")]
        Suspended,
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Faulted")]
        Faulted,
        [EnumMember(Value = "TimedOut")]
        TimedOut,
        [EnumMember(Value = "Aborted")]
        Aborted,
        [EnumMember(Value = "Ignored")]
        Ignored
    }
    internal static class WorkflowStatusEnumExtension
    {
        internal static string ToSerializedValue(this WorkflowStatus? value)
        {
            return value == null ? null : ((WorkflowStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WorkflowStatus value)
        {
            switch( value )
            {
                case WorkflowStatus.NotSpecified:
                    return "NotSpecified";
                case WorkflowStatus.Paused:
                    return "Paused";
                case WorkflowStatus.Running:
                    return "Running";
                case WorkflowStatus.Waiting:
                    return "Waiting";
                case WorkflowStatus.Succeeded:
                    return "Succeeded";
                case WorkflowStatus.Skipped:
                    return "Skipped";
                case WorkflowStatus.Suspended:
                    return "Suspended";
                case WorkflowStatus.Cancelled:
                    return "Cancelled";
                case WorkflowStatus.Failed:
                    return "Failed";
                case WorkflowStatus.Faulted:
                    return "Faulted";
                case WorkflowStatus.TimedOut:
                    return "TimedOut";
                case WorkflowStatus.Aborted:
                    return "Aborted";
                case WorkflowStatus.Ignored:
                    return "Ignored";
            }
            return null;
        }

        internal static WorkflowStatus? ParseWorkflowStatus(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return WorkflowStatus.NotSpecified;
                case "Paused":
                    return WorkflowStatus.Paused;
                case "Running":
                    return WorkflowStatus.Running;
                case "Waiting":
                    return WorkflowStatus.Waiting;
                case "Succeeded":
                    return WorkflowStatus.Succeeded;
                case "Skipped":
                    return WorkflowStatus.Skipped;
                case "Suspended":
                    return WorkflowStatus.Suspended;
                case "Cancelled":
                    return WorkflowStatus.Cancelled;
                case "Failed":
                    return WorkflowStatus.Failed;
                case "Faulted":
                    return WorkflowStatus.Faulted;
                case "TimedOut":
                    return WorkflowStatus.TimedOut;
                case "Aborted":
                    return WorkflowStatus.Aborted;
                case "Ignored":
                    return WorkflowStatus.Ignored;
            }
            return null;
        }
    }
}
