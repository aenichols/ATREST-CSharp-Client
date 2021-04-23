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
    /// CollectionItem
    /// </summary>
    [DataContract]
    public partial class CollectionItem :  IEquatable<CollectionItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionItem" /> class.
        /// </summary>
        /// <param name="longValue">longValue.</param>
        /// <param name="stringValue">stringValue.</param>
        public CollectionItem(long? longValue = default(long?), string stringValue = default(string))
        {
            this.LongValue = longValue;
            this.StringValue = stringValue;
        }
        
        /// <summary>
        /// Gets or Sets LongValue
        /// </summary>
        [DataMember(Name="longValue", EmitDefaultValue=false)]
        public long? LongValue { get; set; }

        /// <summary>
        /// Gets or Sets StringValue
        /// </summary>
        [DataMember(Name="stringValue", EmitDefaultValue=false)]
        public string StringValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionItem {\n");
            sb.Append("  LongValue: ").Append(LongValue).Append("\n");
            sb.Append("  StringValue: ").Append(StringValue).Append("\n");
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
            return this.Equals(input as CollectionItem);
        }

        /// <summary>
        /// Returns true if CollectionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LongValue == input.LongValue ||
                    (this.LongValue != null &&
                    this.LongValue.Equals(input.LongValue))
                ) && 
                (
                    this.StringValue == input.StringValue ||
                    (this.StringValue != null &&
                    this.StringValue.Equals(input.StringValue))
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
                if (this.LongValue != null)
                    hashCode = hashCode * 59 + this.LongValue.GetHashCode();
                if (this.StringValue != null)
                    hashCode = hashCode * 59 + this.StringValue.GetHashCode();
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