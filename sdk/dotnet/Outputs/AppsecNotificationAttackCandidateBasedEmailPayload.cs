// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class AppsecNotificationAttackCandidateBasedEmailPayload
    {
        /// <summary>
        /// The template of the email notifications.  
        /// In case a value of a security problem is not set, the placeholder will be replaced by an empty string.. **Note:** Security notifications contain sensitive information. Excessive usage of placeholders in the body might leak information to untrusted parties.  
        ///   
        /// Available placeholders:  
        /// **{AttackDisplayId}**: The unique identifier assigned by Dynatrace, for example: "A-1234".  
        /// **{Title}**: Location of the attack, for example: "com.dynatrace.Class.method():120"  
        /// **{Type}**: The type of attack, for example: "SQL Injection".  
        /// **{AttackUrl}**: URL of the attack in Dynatrace.  
        /// **{ProcessGroupId}**: Details about the process group attacked.  
        /// **{EntryPoint}**: The entry point of the attack into the process, for example: "/login". Can be empty.  
        /// **{Status}**: The status of the attack, for example: "Exploited"  
        /// **{Timestamp}**: When the attack happened.  
        /// **{VulnerabilityName}**: Name of the associated code-level vulnerability, for example: "InMemoryDatabaseCaller.getAccountInfo():51". Can be empty.
        /// </summary>
        public readonly string Body;
        /// <summary>
        /// The subject of the email notifications.. Available placeholders:  
        /// **{AttackDisplayId}**: The unique identifier assigned by Dynatrace, for example, "A-1234".  
        /// **{Title}**: Location of the attack, for example: "com.dynatrace.Class.method():120"  
        /// **{Type}**: The type of attack, for example: "SQL Injection".  
        /// **{AttackUrl}**: URL of the attack in Dynatrace.  
        /// **{ProcessGroupId}**: Details about the process group attacked.  
        /// **{EntryPoint}**: The entry point of the attack into the process, for example: "/login". Can be empty.  
        /// **{Status}**: The status of the attack, for example: "Exploited"  
        /// **{Timestamp}**: When the attack happened.  
        /// **{VulnerabilityName}**: Name of the associated code-level vulnerability, for example: "InMemoryDatabaseCaller.getAccountInfo():51". Can be empty.
        /// </summary>
        public readonly string Subject;

        [OutputConstructor]
        private AppsecNotificationAttackCandidateBasedEmailPayload(
            string body,

            string subject)
        {
            Body = body;
            Subject = subject;
        }
    }
}