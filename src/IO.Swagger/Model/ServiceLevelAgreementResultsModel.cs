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
    /// ServiceLevelAgreementResultsModel
    /// </summary>
    [DataContract]
    public partial class ServiceLevelAgreementResultsModel :  IEquatable<ServiceLevelAgreementResultsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevelAgreementResultsModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="firstResponseElapsedHours">firstResponseElapsedHours.</param>
        /// <param name="firstResponseInitiatingResourceID">firstResponseInitiatingResourceID.</param>
        /// <param name="firstResponseResourceID">firstResponseResourceID.</param>
        /// <param name="isFirstResponseMet">isFirstResponseMet.</param>
        /// <param name="isResolutionMet">isResolutionMet.</param>
        /// <param name="isResolutionPlanMet">isResolutionPlanMet.</param>
        /// <param name="resolutionElapsedHours">resolutionElapsedHours.</param>
        /// <param name="resolutionPlanElapsedHours">resolutionPlanElapsedHours.</param>
        /// <param name="resolutionPlanResourceID">resolutionPlanResourceID.</param>
        /// <param name="resolutionResourceID">resolutionResourceID.</param>
        /// <param name="serviceLevelAgreementName">serviceLevelAgreementName.</param>
        /// <param name="ticketID">ticketID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ServiceLevelAgreementResultsModel(long? id = default(long?), double? firstResponseElapsedHours = default(double?), int? firstResponseInitiatingResourceID = default(int?), int? firstResponseResourceID = default(int?), bool? isFirstResponseMet = default(bool?), bool? isResolutionMet = default(bool?), bool? isResolutionPlanMet = default(bool?), double? resolutionElapsedHours = default(double?), double? resolutionPlanElapsedHours = default(double?), int? resolutionPlanResourceID = default(int?), int? resolutionResourceID = default(int?), string serviceLevelAgreementName = default(string), int? ticketID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.FirstResponseElapsedHours = firstResponseElapsedHours;
            this.FirstResponseInitiatingResourceID = firstResponseInitiatingResourceID;
            this.FirstResponseResourceID = firstResponseResourceID;
            this.IsFirstResponseMet = isFirstResponseMet;
            this.IsResolutionMet = isResolutionMet;
            this.IsResolutionPlanMet = isResolutionPlanMet;
            this.ResolutionElapsedHours = resolutionElapsedHours;
            this.ResolutionPlanElapsedHours = resolutionPlanElapsedHours;
            this.ResolutionPlanResourceID = resolutionPlanResourceID;
            this.ResolutionResourceID = resolutionResourceID;
            this.ServiceLevelAgreementName = serviceLevelAgreementName;
            this.TicketID = ticketID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstResponseElapsedHours
        /// </summary>
        [DataMember(Name="firstResponseElapsedHours", EmitDefaultValue=false)]
        public double? FirstResponseElapsedHours { get; set; }

        /// <summary>
        /// Gets or Sets FirstResponseInitiatingResourceID
        /// </summary>
        [DataMember(Name="firstResponseInitiatingResourceID", EmitDefaultValue=false)]
        public int? FirstResponseInitiatingResourceID { get; set; }

        /// <summary>
        /// Gets or Sets FirstResponseResourceID
        /// </summary>
        [DataMember(Name="firstResponseResourceID", EmitDefaultValue=false)]
        public int? FirstResponseResourceID { get; set; }

        /// <summary>
        /// Gets or Sets IsFirstResponseMet
        /// </summary>
        [DataMember(Name="isFirstResponseMet", EmitDefaultValue=false)]
        public bool? IsFirstResponseMet { get; set; }

        /// <summary>
        /// Gets or Sets IsResolutionMet
        /// </summary>
        [DataMember(Name="isResolutionMet", EmitDefaultValue=false)]
        public bool? IsResolutionMet { get; set; }

        /// <summary>
        /// Gets or Sets IsResolutionPlanMet
        /// </summary>
        [DataMember(Name="isResolutionPlanMet", EmitDefaultValue=false)]
        public bool? IsResolutionPlanMet { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionElapsedHours
        /// </summary>
        [DataMember(Name="resolutionElapsedHours", EmitDefaultValue=false)]
        public double? ResolutionElapsedHours { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionPlanElapsedHours
        /// </summary>
        [DataMember(Name="resolutionPlanElapsedHours", EmitDefaultValue=false)]
        public double? ResolutionPlanElapsedHours { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionPlanResourceID
        /// </summary>
        [DataMember(Name="resolutionPlanResourceID", EmitDefaultValue=false)]
        public int? ResolutionPlanResourceID { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionResourceID
        /// </summary>
        [DataMember(Name="resolutionResourceID", EmitDefaultValue=false)]
        public int? ResolutionResourceID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLevelAgreementName
        /// </summary>
        [DataMember(Name="serviceLevelAgreementName", EmitDefaultValue=false)]
        public string ServiceLevelAgreementName { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID", EmitDefaultValue=false)]
        public int? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public long? SoapParentPropertyId { get; private set; }

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
            sb.Append("class ServiceLevelAgreementResultsModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstResponseElapsedHours: ").Append(FirstResponseElapsedHours).Append("\n");
            sb.Append("  FirstResponseInitiatingResourceID: ").Append(FirstResponseInitiatingResourceID).Append("\n");
            sb.Append("  FirstResponseResourceID: ").Append(FirstResponseResourceID).Append("\n");
            sb.Append("  IsFirstResponseMet: ").Append(IsFirstResponseMet).Append("\n");
            sb.Append("  IsResolutionMet: ").Append(IsResolutionMet).Append("\n");
            sb.Append("  IsResolutionPlanMet: ").Append(IsResolutionPlanMet).Append("\n");
            sb.Append("  ResolutionElapsedHours: ").Append(ResolutionElapsedHours).Append("\n");
            sb.Append("  ResolutionPlanElapsedHours: ").Append(ResolutionPlanElapsedHours).Append("\n");
            sb.Append("  ResolutionPlanResourceID: ").Append(ResolutionPlanResourceID).Append("\n");
            sb.Append("  ResolutionResourceID: ").Append(ResolutionResourceID).Append("\n");
            sb.Append("  ServiceLevelAgreementName: ").Append(ServiceLevelAgreementName).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
            sb.Append("  SoapParentPropertyId: ").Append(SoapParentPropertyId).Append("\n");
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
            return this.Equals(input as ServiceLevelAgreementResultsModel);
        }

        /// <summary>
        /// Returns true if ServiceLevelAgreementResultsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceLevelAgreementResultsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceLevelAgreementResultsModel input)
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
                    this.FirstResponseElapsedHours == input.FirstResponseElapsedHours ||
                    (this.FirstResponseElapsedHours != null &&
                    this.FirstResponseElapsedHours.Equals(input.FirstResponseElapsedHours))
                ) && 
                (
                    this.FirstResponseInitiatingResourceID == input.FirstResponseInitiatingResourceID ||
                    (this.FirstResponseInitiatingResourceID != null &&
                    this.FirstResponseInitiatingResourceID.Equals(input.FirstResponseInitiatingResourceID))
                ) && 
                (
                    this.FirstResponseResourceID == input.FirstResponseResourceID ||
                    (this.FirstResponseResourceID != null &&
                    this.FirstResponseResourceID.Equals(input.FirstResponseResourceID))
                ) && 
                (
                    this.IsFirstResponseMet == input.IsFirstResponseMet ||
                    (this.IsFirstResponseMet != null &&
                    this.IsFirstResponseMet.Equals(input.IsFirstResponseMet))
                ) && 
                (
                    this.IsResolutionMet == input.IsResolutionMet ||
                    (this.IsResolutionMet != null &&
                    this.IsResolutionMet.Equals(input.IsResolutionMet))
                ) && 
                (
                    this.IsResolutionPlanMet == input.IsResolutionPlanMet ||
                    (this.IsResolutionPlanMet != null &&
                    this.IsResolutionPlanMet.Equals(input.IsResolutionPlanMet))
                ) && 
                (
                    this.ResolutionElapsedHours == input.ResolutionElapsedHours ||
                    (this.ResolutionElapsedHours != null &&
                    this.ResolutionElapsedHours.Equals(input.ResolutionElapsedHours))
                ) && 
                (
                    this.ResolutionPlanElapsedHours == input.ResolutionPlanElapsedHours ||
                    (this.ResolutionPlanElapsedHours != null &&
                    this.ResolutionPlanElapsedHours.Equals(input.ResolutionPlanElapsedHours))
                ) && 
                (
                    this.ResolutionPlanResourceID == input.ResolutionPlanResourceID ||
                    (this.ResolutionPlanResourceID != null &&
                    this.ResolutionPlanResourceID.Equals(input.ResolutionPlanResourceID))
                ) && 
                (
                    this.ResolutionResourceID == input.ResolutionResourceID ||
                    (this.ResolutionResourceID != null &&
                    this.ResolutionResourceID.Equals(input.ResolutionResourceID))
                ) && 
                (
                    this.ServiceLevelAgreementName == input.ServiceLevelAgreementName ||
                    (this.ServiceLevelAgreementName != null &&
                    this.ServiceLevelAgreementName.Equals(input.ServiceLevelAgreementName))
                ) && 
                (
                    this.TicketID == input.TicketID ||
                    (this.TicketID != null &&
                    this.TicketID.Equals(input.TicketID))
                ) && 
                (
                    this.SoapParentPropertyId == input.SoapParentPropertyId ||
                    (this.SoapParentPropertyId != null &&
                    this.SoapParentPropertyId.Equals(input.SoapParentPropertyId))
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
                if (this.FirstResponseElapsedHours != null)
                    hashCode = hashCode * 59 + this.FirstResponseElapsedHours.GetHashCode();
                if (this.FirstResponseInitiatingResourceID != null)
                    hashCode = hashCode * 59 + this.FirstResponseInitiatingResourceID.GetHashCode();
                if (this.FirstResponseResourceID != null)
                    hashCode = hashCode * 59 + this.FirstResponseResourceID.GetHashCode();
                if (this.IsFirstResponseMet != null)
                    hashCode = hashCode * 59 + this.IsFirstResponseMet.GetHashCode();
                if (this.IsResolutionMet != null)
                    hashCode = hashCode * 59 + this.IsResolutionMet.GetHashCode();
                if (this.IsResolutionPlanMet != null)
                    hashCode = hashCode * 59 + this.IsResolutionPlanMet.GetHashCode();
                if (this.ResolutionElapsedHours != null)
                    hashCode = hashCode * 59 + this.ResolutionElapsedHours.GetHashCode();
                if (this.ResolutionPlanElapsedHours != null)
                    hashCode = hashCode * 59 + this.ResolutionPlanElapsedHours.GetHashCode();
                if (this.ResolutionPlanResourceID != null)
                    hashCode = hashCode * 59 + this.ResolutionPlanResourceID.GetHashCode();
                if (this.ResolutionResourceID != null)
                    hashCode = hashCode * 59 + this.ResolutionResourceID.GetHashCode();
                if (this.ServiceLevelAgreementName != null)
                    hashCode = hashCode * 59 + this.ServiceLevelAgreementName.GetHashCode();
                if (this.TicketID != null)
                    hashCode = hashCode * 59 + this.TicketID.GetHashCode();
                if (this.SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + this.SoapParentPropertyId.GetHashCode();
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