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
    /// DocumentModel
    /// </summary>
    [DataContract]
    public partial class DocumentModel :  IEquatable<DocumentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="companyID">companyID.</param>
        /// <param name="createdByResourceID">createdByResourceID.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="documentCategoryID">documentCategoryID.</param>
        /// <param name="errorCodes">errorCodes.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="lastModifiedByResourceID">lastModifiedByResourceID.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="publish">publish.</param>
        /// <param name="referenceLink">referenceLink.</param>
        /// <param name="title">title.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public DocumentModel(long? id = default(long?), int? companyID = default(int?), int? createdByResourceID = default(int?), DateTime? createdDateTime = default(DateTime?), int? documentCategoryID = default(int?), string errorCodes = default(string), bool? isActive = default(bool?), string keywords = default(string), int? lastModifiedByResourceID = default(int?), DateTime? lastModifiedDateTime = default(DateTime?), int? publish = default(int?), string referenceLink = default(string), string title = default(string), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.CompanyID = companyID;
            this.CreatedByResourceID = createdByResourceID;
            this.CreatedDateTime = createdDateTime;
            this.DocumentCategoryID = documentCategoryID;
            this.ErrorCodes = errorCodes;
            this.IsActive = isActive;
            this.Keywords = keywords;
            this.LastModifiedByResourceID = lastModifiedByResourceID;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.Publish = publish;
            this.ReferenceLink = referenceLink;
            this.Title = title;
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
        /// Gets or Sets CreatedByResourceID
        /// </summary>
        [DataMember(Name="createdByResourceID", EmitDefaultValue=false)]
        public int? CreatedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCategoryID
        /// </summary>
        [DataMember(Name="documentCategoryID", EmitDefaultValue=false)]
        public int? DocumentCategoryID { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCodes
        /// </summary>
        [DataMember(Name="errorCodes", EmitDefaultValue=false)]
        public string ErrorCodes { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedByResourceID
        /// </summary>
        [DataMember(Name="lastModifiedByResourceID", EmitDefaultValue=false)]
        public int? LastModifiedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="lastModifiedDateTime", EmitDefaultValue=false)]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Publish
        /// </summary>
        [DataMember(Name="publish", EmitDefaultValue=false)]
        public int? Publish { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceLink
        /// </summary>
        [DataMember(Name="referenceLink", EmitDefaultValue=false)]
        public string ReferenceLink { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId", EmitDefaultValue=false)]
        public ExpressionFuncDocumentInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class DocumentModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyID: ").Append(CompanyID).Append("\n");
            sb.Append("  CreatedByResourceID: ").Append(CreatedByResourceID).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  DocumentCategoryID: ").Append(DocumentCategoryID).Append("\n");
            sb.Append("  ErrorCodes: ").Append(ErrorCodes).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  LastModifiedByResourceID: ").Append(LastModifiedByResourceID).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  Publish: ").Append(Publish).Append("\n");
            sb.Append("  ReferenceLink: ").Append(ReferenceLink).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as DocumentModel);
        }

        /// <summary>
        /// Returns true if DocumentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentModel input)
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
                    this.CreatedByResourceID == input.CreatedByResourceID ||
                    (this.CreatedByResourceID != null &&
                    this.CreatedByResourceID.Equals(input.CreatedByResourceID))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.DocumentCategoryID == input.DocumentCategoryID ||
                    (this.DocumentCategoryID != null &&
                    this.DocumentCategoryID.Equals(input.DocumentCategoryID))
                ) && 
                (
                    this.ErrorCodes == input.ErrorCodes ||
                    (this.ErrorCodes != null &&
                    this.ErrorCodes.Equals(input.ErrorCodes))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.LastModifiedByResourceID == input.LastModifiedByResourceID ||
                    (this.LastModifiedByResourceID != null &&
                    this.LastModifiedByResourceID.Equals(input.LastModifiedByResourceID))
                ) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && 
                (
                    this.Publish == input.Publish ||
                    (this.Publish != null &&
                    this.Publish.Equals(input.Publish))
                ) && 
                (
                    this.ReferenceLink == input.ReferenceLink ||
                    (this.ReferenceLink != null &&
                    this.ReferenceLink.Equals(input.ReferenceLink))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.CompanyID != null)
                    hashCode = hashCode * 59 + this.CompanyID.GetHashCode();
                if (this.CreatedByResourceID != null)
                    hashCode = hashCode * 59 + this.CreatedByResourceID.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.DocumentCategoryID != null)
                    hashCode = hashCode * 59 + this.DocumentCategoryID.GetHashCode();
                if (this.ErrorCodes != null)
                    hashCode = hashCode * 59 + this.ErrorCodes.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.LastModifiedByResourceID != null)
                    hashCode = hashCode * 59 + this.LastModifiedByResourceID.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.Publish != null)
                    hashCode = hashCode * 59 + this.Publish.GetHashCode();
                if (this.ReferenceLink != null)
                    hashCode = hashCode * 59 + this.ReferenceLink.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
