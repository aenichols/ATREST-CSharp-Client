/* 
 * Datto|Autotask PSA Rest API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
    /// SurveyResultsModel
    /// </summary>
    [DataContract]
    public partial class SurveyResultsModel :  IEquatable<SurveyResultsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyResultsModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="companyID">companyID.</param>
        /// <param name="companyRating">companyRating.</param>
        /// <param name="completeDate">completeDate.</param>
        /// <param name="contactID">contactID.</param>
        /// <param name="contactRating">contactRating.</param>
        /// <param name="resourceRating">resourceRating.</param>
        /// <param name="sendDate">sendDate.</param>
        /// <param name="surveyID">surveyID.</param>
        /// <param name="surveyRating">surveyRating.</param>
        /// <param name="ticketID">ticketID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public SurveyResultsModel(long? id = default(long?), int? companyID = default(int?), double? companyRating = default(double?), DateTime? completeDate = default(DateTime?), int? contactID = default(int?), double? contactRating = default(double?), double? resourceRating = default(double?), DateTime? sendDate = default(DateTime?), int? surveyID = default(int?), double? surveyRating = default(double?), int? ticketID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.CompanyID = companyID;
            this.CompanyRating = companyRating;
            this.CompleteDate = completeDate;
            this.ContactID = contactID;
            this.ContactRating = contactRating;
            this.ResourceRating = resourceRating;
            this.SendDate = sendDate;
            this.SurveyID = surveyID;
            this.SurveyRating = surveyRating;
            this.TicketID = ticketID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CompanyID
        /// </summary>
        [DataMember(Name="companyID", EmitDefaultValue=false)]
        public int? CompanyID { get; set; }

        /// <summary>
        /// Gets or Sets CompanyRating
        /// </summary>
        [DataMember(Name="companyRating", EmitDefaultValue=false)]
        public double? CompanyRating { get; set; }

        /// <summary>
        /// Gets or Sets CompleteDate
        /// </summary>
        [DataMember(Name="completeDate", EmitDefaultValue=false)]
        public DateTime? CompleteDate { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="contactID", EmitDefaultValue=false)]
        public int? ContactID { get; set; }

        /// <summary>
        /// Gets or Sets ContactRating
        /// </summary>
        [DataMember(Name="contactRating", EmitDefaultValue=false)]
        public double? ContactRating { get; set; }

        /// <summary>
        /// Gets or Sets ResourceRating
        /// </summary>
        [DataMember(Name="resourceRating", EmitDefaultValue=false)]
        public double? ResourceRating { get; set; }

        /// <summary>
        /// Gets or Sets SendDate
        /// </summary>
        [DataMember(Name="sendDate", EmitDefaultValue=false)]
        public DateTime? SendDate { get; set; }

        /// <summary>
        /// Gets or Sets SurveyID
        /// </summary>
        [DataMember(Name="surveyID", EmitDefaultValue=false)]
        public int? SurveyID { get; set; }

        /// <summary>
        /// Gets or Sets SurveyRating
        /// </summary>
        [DataMember(Name="surveyRating", EmitDefaultValue=false)]
        public double? SurveyRating { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID", EmitDefaultValue=false)]
        public int? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedFields
        /// </summary>
        [DataMember(Name="userDefinedFields", EmitDefaultValue=false)]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveyResultsModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyID: ").Append(CompanyID).Append("\n");
            sb.Append("  CompanyRating: ").Append(CompanyRating).Append("\n");
            sb.Append("  CompleteDate: ").Append(CompleteDate).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  ContactRating: ").Append(ContactRating).Append("\n");
            sb.Append("  ResourceRating: ").Append(ResourceRating).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
            sb.Append("  SurveyID: ").Append(SurveyID).Append("\n");
            sb.Append("  SurveyRating: ").Append(SurveyRating).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
            sb.Append("  UserDefinedFields: ").Append(UserDefinedFields).Append("\n");
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
            return this.Equals(input as SurveyResultsModel);
        }

        /// <summary>
        /// Returns true if SurveyResultsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SurveyResultsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyResultsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CompanyID == input.CompanyID ||
                    (this.CompanyID != null &&
                    this.CompanyID.Equals(input.CompanyID))
                ) && 
                (
                    this.CompanyRating == input.CompanyRating ||
                    (this.CompanyRating != null &&
                    this.CompanyRating.Equals(input.CompanyRating))
                ) && 
                (
                    this.CompleteDate == input.CompleteDate ||
                    (this.CompleteDate != null &&
                    this.CompleteDate.Equals(input.CompleteDate))
                ) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && 
                (
                    this.ContactRating == input.ContactRating ||
                    (this.ContactRating != null &&
                    this.ContactRating.Equals(input.ContactRating))
                ) && 
                (
                    this.ResourceRating == input.ResourceRating ||
                    (this.ResourceRating != null &&
                    this.ResourceRating.Equals(input.ResourceRating))
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    (this.SendDate != null &&
                    this.SendDate.Equals(input.SendDate))
                ) && 
                (
                    this.SurveyID == input.SurveyID ||
                    (this.SurveyID != null &&
                    this.SurveyID.Equals(input.SurveyID))
                ) && 
                (
                    this.SurveyRating == input.SurveyRating ||
                    (this.SurveyRating != null &&
                    this.SurveyRating.Equals(input.SurveyRating))
                ) && 
                (
                    this.TicketID == input.TicketID ||
                    (this.TicketID != null &&
                    this.TicketID.Equals(input.TicketID))
                ) && 
                (
                    this.UserDefinedFields == input.UserDefinedFields ||
                    this.UserDefinedFields != null &&
                    this.UserDefinedFields.SequenceEqual(input.UserDefinedFields)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CompanyID != null)
                    hashCode = hashCode * 59 + this.CompanyID.GetHashCode();
                if (this.CompanyRating != null)
                    hashCode = hashCode * 59 + this.CompanyRating.GetHashCode();
                if (this.CompleteDate != null)
                    hashCode = hashCode * 59 + this.CompleteDate.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.ContactRating != null)
                    hashCode = hashCode * 59 + this.ContactRating.GetHashCode();
                if (this.ResourceRating != null)
                    hashCode = hashCode * 59 + this.ResourceRating.GetHashCode();
                if (this.SendDate != null)
                    hashCode = hashCode * 59 + this.SendDate.GetHashCode();
                if (this.SurveyID != null)
                    hashCode = hashCode * 59 + this.SurveyID.GetHashCode();
                if (this.SurveyRating != null)
                    hashCode = hashCode * 59 + this.SurveyRating.GetHashCode();
                if (this.TicketID != null)
                    hashCode = hashCode * 59 + this.TicketID.GetHashCode();
                if (this.UserDefinedFields != null)
                    hashCode = hashCode * 59 + this.UserDefinedFields.GetHashCode();
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
