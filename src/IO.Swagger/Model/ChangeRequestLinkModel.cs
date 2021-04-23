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
    /// ChangeRequestLinkModel
    /// </summary>
    [DataContract]
    public partial class ChangeRequestLinkModel :  IEquatable<ChangeRequestLinkModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeRequestLinkModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="changeRequestTicketID">changeRequestTicketID.</param>
        /// <param name="problemOrIncidentTicketID">problemOrIncidentTicketID.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public ChangeRequestLinkModel(long? id = default(long?), int? changeRequestTicketID = default(int?), int? problemOrIncidentTicketID = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.ChangeRequestTicketID = changeRequestTicketID;
            this.ProblemOrIncidentTicketID = problemOrIncidentTicketID;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ChangeRequestTicketID
        /// </summary>
        [DataMember(Name="changeRequestTicketID", EmitDefaultValue=false)]
        public int? ChangeRequestTicketID { get; set; }

        /// <summary>
        /// Gets or Sets ProblemOrIncidentTicketID
        /// </summary>
        [DataMember(Name="problemOrIncidentTicketID", EmitDefaultValue=false)]
        public int? ProblemOrIncidentTicketID { get; set; }

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
            sb.Append("class ChangeRequestLinkModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChangeRequestTicketID: ").Append(ChangeRequestTicketID).Append("\n");
            sb.Append("  ProblemOrIncidentTicketID: ").Append(ProblemOrIncidentTicketID).Append("\n");
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
            return this.Equals(input as ChangeRequestLinkModel);
        }

        /// <summary>
        /// Returns true if ChangeRequestLinkModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeRequestLinkModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeRequestLinkModel input)
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
                    this.ChangeRequestTicketID == input.ChangeRequestTicketID ||
                    (this.ChangeRequestTicketID != null &&
                    this.ChangeRequestTicketID.Equals(input.ChangeRequestTicketID))
                ) && 
                (
                    this.ProblemOrIncidentTicketID == input.ProblemOrIncidentTicketID ||
                    (this.ProblemOrIncidentTicketID != null &&
                    this.ProblemOrIncidentTicketID.Equals(input.ProblemOrIncidentTicketID))
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
                if (this.ChangeRequestTicketID != null)
                    hashCode = hashCode * 59 + this.ChangeRequestTicketID.GetHashCode();
                if (this.ProblemOrIncidentTicketID != null)
                    hashCode = hashCode * 59 + this.ProblemOrIncidentTicketID.GetHashCode();
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