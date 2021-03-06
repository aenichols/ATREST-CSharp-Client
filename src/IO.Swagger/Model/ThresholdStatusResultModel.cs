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
    /// ThresholdStatusResultModel
    /// </summary>
    [DataContract]
    public partial class ThresholdStatusResultModel :  IEquatable<ThresholdStatusResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThresholdStatusResultModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ThresholdStatusResultModel()
        {
        }
        
        /// <summary>
        /// Gets or Sets ExternalRequestThreshold
        /// </summary>
        [DataMember(Name="externalRequestThreshold", EmitDefaultValue=false)]
        public int? ExternalRequestThreshold { get; private set; }

        /// <summary>
        /// Gets or Sets RequestThresholdTimeframe
        /// </summary>
        [DataMember(Name="requestThresholdTimeframe", EmitDefaultValue=false)]
        public int? RequestThresholdTimeframe { get; private set; }

        /// <summary>
        /// Gets or Sets CurrentTimeframeRequestCount
        /// </summary>
        [DataMember(Name="currentTimeframeRequestCount", EmitDefaultValue=false)]
        public int? CurrentTimeframeRequestCount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThresholdStatusResultModel {\n");
            sb.Append("  ExternalRequestThreshold: ").Append(ExternalRequestThreshold).Append("\n");
            sb.Append("  RequestThresholdTimeframe: ").Append(RequestThresholdTimeframe).Append("\n");
            sb.Append("  CurrentTimeframeRequestCount: ").Append(CurrentTimeframeRequestCount).Append("\n");
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
            return this.Equals(input as ThresholdStatusResultModel);
        }

        /// <summary>
        /// Returns true if ThresholdStatusResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ThresholdStatusResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThresholdStatusResultModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalRequestThreshold == input.ExternalRequestThreshold ||
                    (this.ExternalRequestThreshold != null &&
                    this.ExternalRequestThreshold.Equals(input.ExternalRequestThreshold))
                ) && 
                (
                    this.RequestThresholdTimeframe == input.RequestThresholdTimeframe ||
                    (this.RequestThresholdTimeframe != null &&
                    this.RequestThresholdTimeframe.Equals(input.RequestThresholdTimeframe))
                ) && 
                (
                    this.CurrentTimeframeRequestCount == input.CurrentTimeframeRequestCount ||
                    (this.CurrentTimeframeRequestCount != null &&
                    this.CurrentTimeframeRequestCount.Equals(input.CurrentTimeframeRequestCount))
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
                if (this.ExternalRequestThreshold != null)
                    hashCode = hashCode * 59 + this.ExternalRequestThreshold.GetHashCode();
                if (this.RequestThresholdTimeframe != null)
                    hashCode = hashCode * 59 + this.RequestThresholdTimeframe.GetHashCode();
                if (this.CurrentTimeframeRequestCount != null)
                    hashCode = hashCode * 59 + this.CurrentTimeframeRequestCount.GetHashCode();
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
