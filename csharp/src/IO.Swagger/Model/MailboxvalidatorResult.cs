/* 
 * Email Validator
 *
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// MailboxvalidatorResult
    /// </summary>
    [DataContract]
        public partial class MailboxvalidatorResult :  IEquatable<MailboxvalidatorResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxvalidatorResult" /> class.
        /// </summary>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="domain">domain.</param>
        /// <param name="isFree">isFree.</param>
        /// <param name="isSyntax">isSyntax.</param>
        /// <param name="isDomain">isDomain.</param>
        /// <param name="isSmtp">isSmtp.</param>
        /// <param name="isVerified">isVerified.</param>
        /// <param name="isServerDown">isServerDown.</param>
        /// <param name="isGreylisted">isGreylisted.</param>
        /// <param name="isDisposable">isDisposable.</param>
        /// <param name="isSuppressed">isSuppressed.</param>
        /// <param name="isRole">isRole.</param>
        /// <param name="isHighRisk">isHighRisk.</param>
        /// <param name="isCatchall">isCatchall.</param>
        /// <param name="mailboxvalidatorScore">mailboxvalidatorScore.</param>
        /// <param name="timeTaken">timeTaken.</param>
        /// <param name="status">status.</param>
        /// <param name="creditsAvailable">creditsAvailable.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        public MailboxvalidatorResult(string emailAddress = default(string), string domain = default(string), string isFree = default(string), string isSyntax = default(string), string isDomain = default(string), string isSmtp = default(string), string isVerified = default(string), string isServerDown = default(string), string isGreylisted = default(string), string isDisposable = default(string), string isSuppressed = default(string), string isRole = default(string), string isHighRisk = default(string), string isCatchall = default(string), string mailboxvalidatorScore = default(string), string timeTaken = default(string), string status = default(string), long? creditsAvailable = default(long?), string errorCode = default(string), string errorMessage = default(string))
        {
            this.EmailAddress = emailAddress;
            this.Domain = domain;
            this.IsFree = isFree;
            this.IsSyntax = isSyntax;
            this.IsDomain = isDomain;
            this.IsSmtp = isSmtp;
            this.IsVerified = isVerified;
            this.IsServerDown = isServerDown;
            this.IsGreylisted = isGreylisted;
            this.IsDisposable = isDisposable;
            this.IsSuppressed = isSuppressed;
            this.IsRole = isRole;
            this.IsHighRisk = isHighRisk;
            this.IsCatchall = isCatchall;
            this.MailboxvalidatorScore = mailboxvalidatorScore;
            this.TimeTaken = timeTaken;
            this.Status = status;
            this.CreditsAvailable = creditsAvailable;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets IsFree
        /// </summary>
        [DataMember(Name="is_free", EmitDefaultValue=false)]
        public string IsFree { get; set; }

        /// <summary>
        /// Gets or Sets IsSyntax
        /// </summary>
        [DataMember(Name="is_syntax", EmitDefaultValue=false)]
        public string IsSyntax { get; set; }

        /// <summary>
        /// Gets or Sets IsDomain
        /// </summary>
        [DataMember(Name="is_domain", EmitDefaultValue=false)]
        public string IsDomain { get; set; }

        /// <summary>
        /// Gets or Sets IsSmtp
        /// </summary>
        [DataMember(Name="is_smtp", EmitDefaultValue=false)]
        public string IsSmtp { get; set; }

        /// <summary>
        /// Gets or Sets IsVerified
        /// </summary>
        [DataMember(Name="is_verified", EmitDefaultValue=false)]
        public string IsVerified { get; set; }

        /// <summary>
        /// Gets or Sets IsServerDown
        /// </summary>
        [DataMember(Name="is_server_down", EmitDefaultValue=false)]
        public string IsServerDown { get; set; }

        /// <summary>
        /// Gets or Sets IsGreylisted
        /// </summary>
        [DataMember(Name="is_greylisted", EmitDefaultValue=false)]
        public string IsGreylisted { get; set; }

        /// <summary>
        /// Gets or Sets IsDisposable
        /// </summary>
        [DataMember(Name="is_disposable", EmitDefaultValue=false)]
        public string IsDisposable { get; set; }

        /// <summary>
        /// Gets or Sets IsSuppressed
        /// </summary>
        [DataMember(Name="is_suppressed", EmitDefaultValue=false)]
        public string IsSuppressed { get; set; }

        /// <summary>
        /// Gets or Sets IsRole
        /// </summary>
        [DataMember(Name="is_role", EmitDefaultValue=false)]
        public string IsRole { get; set; }

        /// <summary>
        /// Gets or Sets IsHighRisk
        /// </summary>
        [DataMember(Name="is_high_risk", EmitDefaultValue=false)]
        public string IsHighRisk { get; set; }

        /// <summary>
        /// Gets or Sets IsCatchall
        /// </summary>
        [DataMember(Name="is_catchall", EmitDefaultValue=false)]
        public string IsCatchall { get; set; }

        /// <summary>
        /// Gets or Sets MailboxvalidatorScore
        /// </summary>
        [DataMember(Name="mailboxvalidator_score", EmitDefaultValue=false)]
        public string MailboxvalidatorScore { get; set; }

        /// <summary>
        /// Gets or Sets TimeTaken
        /// </summary>
        [DataMember(Name="time_taken", EmitDefaultValue=false)]
        public string TimeTaken { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CreditsAvailable
        /// </summary>
        [DataMember(Name="credits_available", EmitDefaultValue=false)]
        public long? CreditsAvailable { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="error_code", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailboxvalidatorResult {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  IsFree: ").Append(IsFree).Append("\n");
            sb.Append("  IsSyntax: ").Append(IsSyntax).Append("\n");
            sb.Append("  IsDomain: ").Append(IsDomain).Append("\n");
            sb.Append("  IsSmtp: ").Append(IsSmtp).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  IsServerDown: ").Append(IsServerDown).Append("\n");
            sb.Append("  IsGreylisted: ").Append(IsGreylisted).Append("\n");
            sb.Append("  IsDisposable: ").Append(IsDisposable).Append("\n");
            sb.Append("  IsSuppressed: ").Append(IsSuppressed).Append("\n");
            sb.Append("  IsRole: ").Append(IsRole).Append("\n");
            sb.Append("  IsHighRisk: ").Append(IsHighRisk).Append("\n");
            sb.Append("  IsCatchall: ").Append(IsCatchall).Append("\n");
            sb.Append("  MailboxvalidatorScore: ").Append(MailboxvalidatorScore).Append("\n");
            sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreditsAvailable: ").Append(CreditsAvailable).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MailboxvalidatorResult);
        }

        /// <summary>
        /// Returns true if MailboxvalidatorResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MailboxvalidatorResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailboxvalidatorResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.IsFree == input.IsFree ||
                    (this.IsFree != null &&
                    this.IsFree.Equals(input.IsFree))
                ) && 
                (
                    this.IsSyntax == input.IsSyntax ||
                    (this.IsSyntax != null &&
                    this.IsSyntax.Equals(input.IsSyntax))
                ) && 
                (
                    this.IsDomain == input.IsDomain ||
                    (this.IsDomain != null &&
                    this.IsDomain.Equals(input.IsDomain))
                ) && 
                (
                    this.IsSmtp == input.IsSmtp ||
                    (this.IsSmtp != null &&
                    this.IsSmtp.Equals(input.IsSmtp))
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    (this.IsVerified != null &&
                    this.IsVerified.Equals(input.IsVerified))
                ) && 
                (
                    this.IsServerDown == input.IsServerDown ||
                    (this.IsServerDown != null &&
                    this.IsServerDown.Equals(input.IsServerDown))
                ) && 
                (
                    this.IsGreylisted == input.IsGreylisted ||
                    (this.IsGreylisted != null &&
                    this.IsGreylisted.Equals(input.IsGreylisted))
                ) && 
                (
                    this.IsDisposable == input.IsDisposable ||
                    (this.IsDisposable != null &&
                    this.IsDisposable.Equals(input.IsDisposable))
                ) && 
                (
                    this.IsSuppressed == input.IsSuppressed ||
                    (this.IsSuppressed != null &&
                    this.IsSuppressed.Equals(input.IsSuppressed))
                ) && 
                (
                    this.IsRole == input.IsRole ||
                    (this.IsRole != null &&
                    this.IsRole.Equals(input.IsRole))
                ) && 
                (
                    this.IsHighRisk == input.IsHighRisk ||
                    (this.IsHighRisk != null &&
                    this.IsHighRisk.Equals(input.IsHighRisk))
                ) && 
                (
                    this.IsCatchall == input.IsCatchall ||
                    (this.IsCatchall != null &&
                    this.IsCatchall.Equals(input.IsCatchall))
                ) && 
                (
                    this.MailboxvalidatorScore == input.MailboxvalidatorScore ||
                    (this.MailboxvalidatorScore != null &&
                    this.MailboxvalidatorScore.Equals(input.MailboxvalidatorScore))
                ) && 
                (
                    this.TimeTaken == input.TimeTaken ||
                    (this.TimeTaken != null &&
                    this.TimeTaken.Equals(input.TimeTaken))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreditsAvailable == input.CreditsAvailable ||
                    (this.CreditsAvailable != null &&
                    this.CreditsAvailable.Equals(input.CreditsAvailable))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.IsFree != null)
                    hashCode = hashCode * 59 + this.IsFree.GetHashCode();
                if (this.IsSyntax != null)
                    hashCode = hashCode * 59 + this.IsSyntax.GetHashCode();
                if (this.IsDomain != null)
                    hashCode = hashCode * 59 + this.IsDomain.GetHashCode();
                if (this.IsSmtp != null)
                    hashCode = hashCode * 59 + this.IsSmtp.GetHashCode();
                if (this.IsVerified != null)
                    hashCode = hashCode * 59 + this.IsVerified.GetHashCode();
                if (this.IsServerDown != null)
                    hashCode = hashCode * 59 + this.IsServerDown.GetHashCode();
                if (this.IsGreylisted != null)
                    hashCode = hashCode * 59 + this.IsGreylisted.GetHashCode();
                if (this.IsDisposable != null)
                    hashCode = hashCode * 59 + this.IsDisposable.GetHashCode();
                if (this.IsSuppressed != null)
                    hashCode = hashCode * 59 + this.IsSuppressed.GetHashCode();
                if (this.IsRole != null)
                    hashCode = hashCode * 59 + this.IsRole.GetHashCode();
                if (this.IsHighRisk != null)
                    hashCode = hashCode * 59 + this.IsHighRisk.GetHashCode();
                if (this.IsCatchall != null)
                    hashCode = hashCode * 59 + this.IsCatchall.GetHashCode();
                if (this.MailboxvalidatorScore != null)
                    hashCode = hashCode * 59 + this.MailboxvalidatorScore.GetHashCode();
                if (this.TimeTaken != null)
                    hashCode = hashCode * 59 + this.TimeTaken.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreditsAvailable != null)
                    hashCode = hashCode * 59 + this.CreditsAvailable.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
