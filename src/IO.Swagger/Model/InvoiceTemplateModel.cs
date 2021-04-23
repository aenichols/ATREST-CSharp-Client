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
    /// InvoiceTemplateModel
    /// </summary>
    [DataContract]
    public partial class InvoiceTemplateModel :  IEquatable<InvoiceTemplateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTemplateModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="coveredByBlockRetainerContractLabel">coveredByBlockRetainerContractLabel.</param>
        /// <param name="coveredByRecurringServiceFixedPricePerTicketContractLabel">coveredByRecurringServiceFixedPricePerTicketContractLabel.</param>
        /// <param name="currencyNegativeFormat">currencyNegativeFormat.</param>
        /// <param name="currencyPositiveFormat">currencyPositiveFormat.</param>
        /// <param name="dateFormat">dateFormat.</param>
        /// <param name="displayFixedPriceContractLabor">displayFixedPriceContractLabor.</param>
        /// <param name="displayRecurringServiceContractLabor">displayRecurringServiceContractLabor.</param>
        /// <param name="displaySeparateLineItemForEachTax">displaySeparateLineItemForEachTax.</param>
        /// <param name="displayTaxCategory">displayTaxCategory.</param>
        /// <param name="displayTaxCategorySuperscripts">displayTaxCategorySuperscripts.</param>
        /// <param name="displayZeroAmountRecurringServicesAndBundles">displayZeroAmountRecurringServicesAndBundles.</param>
        /// <param name="groupBy">groupBy.</param>
        /// <param name="itemizeItemsInEachGroup">itemizeItemsInEachGroup.</param>
        /// <param name="itemizeServicesAndBundles">itemizeServicesAndBundles.</param>
        /// <param name="name">name.</param>
        /// <param name="nonBillableLaborLabel">nonBillableLaborLabel.</param>
        /// <param name="numberFormat">numberFormat.</param>
        /// <param name="pageLayout">pageLayout.</param>
        /// <param name="pageNumberFormat">pageNumberFormat.</param>
        /// <param name="paymentTerms">paymentTerms.</param>
        /// <param name="rateCostExpression">rateCostExpression.</param>
        /// <param name="showGridHeader">showGridHeader.</param>
        /// <param name="showVerticalGridLines">showVerticalGridLines.</param>
        /// <param name="sortBy">sortBy.</param>
        /// <param name="timeFormat">timeFormat.</param>
        /// <param name="userDefinedFields">userDefinedFields.</param>
        public InvoiceTemplateModel(long? id = default(long?), string coveredByBlockRetainerContractLabel = default(string), string coveredByRecurringServiceFixedPricePerTicketContractLabel = default(string), string currencyNegativeFormat = default(string), string currencyPositiveFormat = default(string), int? dateFormat = default(int?), bool? displayFixedPriceContractLabor = default(bool?), bool? displayRecurringServiceContractLabor = default(bool?), bool? displaySeparateLineItemForEachTax = default(bool?), bool? displayTaxCategory = default(bool?), bool? displayTaxCategorySuperscripts = default(bool?), bool? displayZeroAmountRecurringServicesAndBundles = default(bool?), int? groupBy = default(int?), int? itemizeItemsInEachGroup = default(int?), bool? itemizeServicesAndBundles = default(bool?), string name = default(string), string nonBillableLaborLabel = default(string), int? numberFormat = default(int?), int? pageLayout = default(int?), int? pageNumberFormat = default(int?), int? paymentTerms = default(int?), string rateCostExpression = default(string), bool? showGridHeader = default(bool?), bool? showVerticalGridLines = default(bool?), int? sortBy = default(int?), int? timeFormat = default(int?), List<UserDefinedField> userDefinedFields = default(List<UserDefinedField>))
        {
            this.Id = id;
            this.CoveredByBlockRetainerContractLabel = coveredByBlockRetainerContractLabel;
            this.CoveredByRecurringServiceFixedPricePerTicketContractLabel = coveredByRecurringServiceFixedPricePerTicketContractLabel;
            this.CurrencyNegativeFormat = currencyNegativeFormat;
            this.CurrencyPositiveFormat = currencyPositiveFormat;
            this.DateFormat = dateFormat;
            this.DisplayFixedPriceContractLabor = displayFixedPriceContractLabor;
            this.DisplayRecurringServiceContractLabor = displayRecurringServiceContractLabor;
            this.DisplaySeparateLineItemForEachTax = displaySeparateLineItemForEachTax;
            this.DisplayTaxCategory = displayTaxCategory;
            this.DisplayTaxCategorySuperscripts = displayTaxCategorySuperscripts;
            this.DisplayZeroAmountRecurringServicesAndBundles = displayZeroAmountRecurringServicesAndBundles;
            this.GroupBy = groupBy;
            this.ItemizeItemsInEachGroup = itemizeItemsInEachGroup;
            this.ItemizeServicesAndBundles = itemizeServicesAndBundles;
            this.Name = name;
            this.NonBillableLaborLabel = nonBillableLaborLabel;
            this.NumberFormat = numberFormat;
            this.PageLayout = pageLayout;
            this.PageNumberFormat = pageNumberFormat;
            this.PaymentTerms = paymentTerms;
            this.RateCostExpression = rateCostExpression;
            this.ShowGridHeader = showGridHeader;
            this.ShowVerticalGridLines = showVerticalGridLines;
            this.SortBy = sortBy;
            this.TimeFormat = timeFormat;
            this.UserDefinedFields = userDefinedFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CoveredByBlockRetainerContractLabel
        /// </summary>
        [DataMember(Name="coveredByBlockRetainerContractLabel", EmitDefaultValue=false)]
        public string CoveredByBlockRetainerContractLabel { get; set; }

        /// <summary>
        /// Gets or Sets CoveredByRecurringServiceFixedPricePerTicketContractLabel
        /// </summary>
        [DataMember(Name="coveredByRecurringServiceFixedPricePerTicketContractLabel", EmitDefaultValue=false)]
        public string CoveredByRecurringServiceFixedPricePerTicketContractLabel { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyNegativeFormat
        /// </summary>
        [DataMember(Name="currencyNegativeFormat", EmitDefaultValue=false)]
        public string CurrencyNegativeFormat { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyPositiveFormat
        /// </summary>
        [DataMember(Name="currencyPositiveFormat", EmitDefaultValue=false)]
        public string CurrencyPositiveFormat { get; set; }

        /// <summary>
        /// Gets or Sets DateFormat
        /// </summary>
        [DataMember(Name="dateFormat", EmitDefaultValue=false)]
        public int? DateFormat { get; set; }

        /// <summary>
        /// Gets or Sets DisplayFixedPriceContractLabor
        /// </summary>
        [DataMember(Name="displayFixedPriceContractLabor", EmitDefaultValue=false)]
        public bool? DisplayFixedPriceContractLabor { get; set; }

        /// <summary>
        /// Gets or Sets DisplayRecurringServiceContractLabor
        /// </summary>
        [DataMember(Name="displayRecurringServiceContractLabor", EmitDefaultValue=false)]
        public bool? DisplayRecurringServiceContractLabor { get; set; }

        /// <summary>
        /// Gets or Sets DisplaySeparateLineItemForEachTax
        /// </summary>
        [DataMember(Name="displaySeparateLineItemForEachTax", EmitDefaultValue=false)]
        public bool? DisplaySeparateLineItemForEachTax { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTaxCategory
        /// </summary>
        [DataMember(Name="displayTaxCategory", EmitDefaultValue=false)]
        public bool? DisplayTaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTaxCategorySuperscripts
        /// </summary>
        [DataMember(Name="displayTaxCategorySuperscripts", EmitDefaultValue=false)]
        public bool? DisplayTaxCategorySuperscripts { get; set; }

        /// <summary>
        /// Gets or Sets DisplayZeroAmountRecurringServicesAndBundles
        /// </summary>
        [DataMember(Name="displayZeroAmountRecurringServicesAndBundles", EmitDefaultValue=false)]
        public bool? DisplayZeroAmountRecurringServicesAndBundles { get; set; }

        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public int? GroupBy { get; set; }

        /// <summary>
        /// Gets or Sets ItemizeItemsInEachGroup
        /// </summary>
        [DataMember(Name="itemizeItemsInEachGroup", EmitDefaultValue=false)]
        public int? ItemizeItemsInEachGroup { get; set; }

        /// <summary>
        /// Gets or Sets ItemizeServicesAndBundles
        /// </summary>
        [DataMember(Name="itemizeServicesAndBundles", EmitDefaultValue=false)]
        public bool? ItemizeServicesAndBundles { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NonBillableLaborLabel
        /// </summary>
        [DataMember(Name="nonBillableLaborLabel", EmitDefaultValue=false)]
        public string NonBillableLaborLabel { get; set; }

        /// <summary>
        /// Gets or Sets NumberFormat
        /// </summary>
        [DataMember(Name="numberFormat", EmitDefaultValue=false)]
        public int? NumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets PageLayout
        /// </summary>
        [DataMember(Name="pageLayout", EmitDefaultValue=false)]
        public int? PageLayout { get; set; }

        /// <summary>
        /// Gets or Sets PageNumberFormat
        /// </summary>
        [DataMember(Name="pageNumberFormat", EmitDefaultValue=false)]
        public int? PageNumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTerms
        /// </summary>
        [DataMember(Name="paymentTerms", EmitDefaultValue=false)]
        public int? PaymentTerms { get; set; }

        /// <summary>
        /// Gets or Sets RateCostExpression
        /// </summary>
        [DataMember(Name="rateCostExpression", EmitDefaultValue=false)]
        public string RateCostExpression { get; set; }

        /// <summary>
        /// Gets or Sets ShowGridHeader
        /// </summary>
        [DataMember(Name="showGridHeader", EmitDefaultValue=false)]
        public bool? ShowGridHeader { get; set; }

        /// <summary>
        /// Gets or Sets ShowVerticalGridLines
        /// </summary>
        [DataMember(Name="showVerticalGridLines", EmitDefaultValue=false)]
        public bool? ShowVerticalGridLines { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public int? SortBy { get; set; }

        /// <summary>
        /// Gets or Sets TimeFormat
        /// </summary>
        [DataMember(Name="timeFormat", EmitDefaultValue=false)]
        public int? TimeFormat { get; set; }

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
            sb.Append("class InvoiceTemplateModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CoveredByBlockRetainerContractLabel: ").Append(CoveredByBlockRetainerContractLabel).Append("\n");
            sb.Append("  CoveredByRecurringServiceFixedPricePerTicketContractLabel: ").Append(CoveredByRecurringServiceFixedPricePerTicketContractLabel).Append("\n");
            sb.Append("  CurrencyNegativeFormat: ").Append(CurrencyNegativeFormat).Append("\n");
            sb.Append("  CurrencyPositiveFormat: ").Append(CurrencyPositiveFormat).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  DisplayFixedPriceContractLabor: ").Append(DisplayFixedPriceContractLabor).Append("\n");
            sb.Append("  DisplayRecurringServiceContractLabor: ").Append(DisplayRecurringServiceContractLabor).Append("\n");
            sb.Append("  DisplaySeparateLineItemForEachTax: ").Append(DisplaySeparateLineItemForEachTax).Append("\n");
            sb.Append("  DisplayTaxCategory: ").Append(DisplayTaxCategory).Append("\n");
            sb.Append("  DisplayTaxCategorySuperscripts: ").Append(DisplayTaxCategorySuperscripts).Append("\n");
            sb.Append("  DisplayZeroAmountRecurringServicesAndBundles: ").Append(DisplayZeroAmountRecurringServicesAndBundles).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  ItemizeItemsInEachGroup: ").Append(ItemizeItemsInEachGroup).Append("\n");
            sb.Append("  ItemizeServicesAndBundles: ").Append(ItemizeServicesAndBundles).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NonBillableLaborLabel: ").Append(NonBillableLaborLabel).Append("\n");
            sb.Append("  NumberFormat: ").Append(NumberFormat).Append("\n");
            sb.Append("  PageLayout: ").Append(PageLayout).Append("\n");
            sb.Append("  PageNumberFormat: ").Append(PageNumberFormat).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  RateCostExpression: ").Append(RateCostExpression).Append("\n");
            sb.Append("  ShowGridHeader: ").Append(ShowGridHeader).Append("\n");
            sb.Append("  ShowVerticalGridLines: ").Append(ShowVerticalGridLines).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
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
            return this.Equals(input as InvoiceTemplateModel);
        }

        /// <summary>
        /// Returns true if InvoiceTemplateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceTemplateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceTemplateModel input)
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
                    this.CoveredByBlockRetainerContractLabel == input.CoveredByBlockRetainerContractLabel ||
                    (this.CoveredByBlockRetainerContractLabel != null &&
                    this.CoveredByBlockRetainerContractLabel.Equals(input.CoveredByBlockRetainerContractLabel))
                ) && 
                (
                    this.CoveredByRecurringServiceFixedPricePerTicketContractLabel == input.CoveredByRecurringServiceFixedPricePerTicketContractLabel ||
                    (this.CoveredByRecurringServiceFixedPricePerTicketContractLabel != null &&
                    this.CoveredByRecurringServiceFixedPricePerTicketContractLabel.Equals(input.CoveredByRecurringServiceFixedPricePerTicketContractLabel))
                ) && 
                (
                    this.CurrencyNegativeFormat == input.CurrencyNegativeFormat ||
                    (this.CurrencyNegativeFormat != null &&
                    this.CurrencyNegativeFormat.Equals(input.CurrencyNegativeFormat))
                ) && 
                (
                    this.CurrencyPositiveFormat == input.CurrencyPositiveFormat ||
                    (this.CurrencyPositiveFormat != null &&
                    this.CurrencyPositiveFormat.Equals(input.CurrencyPositiveFormat))
                ) && 
                (
                    this.DateFormat == input.DateFormat ||
                    (this.DateFormat != null &&
                    this.DateFormat.Equals(input.DateFormat))
                ) && 
                (
                    this.DisplayFixedPriceContractLabor == input.DisplayFixedPriceContractLabor ||
                    (this.DisplayFixedPriceContractLabor != null &&
                    this.DisplayFixedPriceContractLabor.Equals(input.DisplayFixedPriceContractLabor))
                ) && 
                (
                    this.DisplayRecurringServiceContractLabor == input.DisplayRecurringServiceContractLabor ||
                    (this.DisplayRecurringServiceContractLabor != null &&
                    this.DisplayRecurringServiceContractLabor.Equals(input.DisplayRecurringServiceContractLabor))
                ) && 
                (
                    this.DisplaySeparateLineItemForEachTax == input.DisplaySeparateLineItemForEachTax ||
                    (this.DisplaySeparateLineItemForEachTax != null &&
                    this.DisplaySeparateLineItemForEachTax.Equals(input.DisplaySeparateLineItemForEachTax))
                ) && 
                (
                    this.DisplayTaxCategory == input.DisplayTaxCategory ||
                    (this.DisplayTaxCategory != null &&
                    this.DisplayTaxCategory.Equals(input.DisplayTaxCategory))
                ) && 
                (
                    this.DisplayTaxCategorySuperscripts == input.DisplayTaxCategorySuperscripts ||
                    (this.DisplayTaxCategorySuperscripts != null &&
                    this.DisplayTaxCategorySuperscripts.Equals(input.DisplayTaxCategorySuperscripts))
                ) && 
                (
                    this.DisplayZeroAmountRecurringServicesAndBundles == input.DisplayZeroAmountRecurringServicesAndBundles ||
                    (this.DisplayZeroAmountRecurringServicesAndBundles != null &&
                    this.DisplayZeroAmountRecurringServicesAndBundles.Equals(input.DisplayZeroAmountRecurringServicesAndBundles))
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    (this.GroupBy != null &&
                    this.GroupBy.Equals(input.GroupBy))
                ) && 
                (
                    this.ItemizeItemsInEachGroup == input.ItemizeItemsInEachGroup ||
                    (this.ItemizeItemsInEachGroup != null &&
                    this.ItemizeItemsInEachGroup.Equals(input.ItemizeItemsInEachGroup))
                ) && 
                (
                    this.ItemizeServicesAndBundles == input.ItemizeServicesAndBundles ||
                    (this.ItemizeServicesAndBundles != null &&
                    this.ItemizeServicesAndBundles.Equals(input.ItemizeServicesAndBundles))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NonBillableLaborLabel == input.NonBillableLaborLabel ||
                    (this.NonBillableLaborLabel != null &&
                    this.NonBillableLaborLabel.Equals(input.NonBillableLaborLabel))
                ) && 
                (
                    this.NumberFormat == input.NumberFormat ||
                    (this.NumberFormat != null &&
                    this.NumberFormat.Equals(input.NumberFormat))
                ) && 
                (
                    this.PageLayout == input.PageLayout ||
                    (this.PageLayout != null &&
                    this.PageLayout.Equals(input.PageLayout))
                ) && 
                (
                    this.PageNumberFormat == input.PageNumberFormat ||
                    (this.PageNumberFormat != null &&
                    this.PageNumberFormat.Equals(input.PageNumberFormat))
                ) && 
                (
                    this.PaymentTerms == input.PaymentTerms ||
                    (this.PaymentTerms != null &&
                    this.PaymentTerms.Equals(input.PaymentTerms))
                ) && 
                (
                    this.RateCostExpression == input.RateCostExpression ||
                    (this.RateCostExpression != null &&
                    this.RateCostExpression.Equals(input.RateCostExpression))
                ) && 
                (
                    this.ShowGridHeader == input.ShowGridHeader ||
                    (this.ShowGridHeader != null &&
                    this.ShowGridHeader.Equals(input.ShowGridHeader))
                ) && 
                (
                    this.ShowVerticalGridLines == input.ShowVerticalGridLines ||
                    (this.ShowVerticalGridLines != null &&
                    this.ShowVerticalGridLines.Equals(input.ShowVerticalGridLines))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.TimeFormat == input.TimeFormat ||
                    (this.TimeFormat != null &&
                    this.TimeFormat.Equals(input.TimeFormat))
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
                if (this.CoveredByBlockRetainerContractLabel != null)
                    hashCode = hashCode * 59 + this.CoveredByBlockRetainerContractLabel.GetHashCode();
                if (this.CoveredByRecurringServiceFixedPricePerTicketContractLabel != null)
                    hashCode = hashCode * 59 + this.CoveredByRecurringServiceFixedPricePerTicketContractLabel.GetHashCode();
                if (this.CurrencyNegativeFormat != null)
                    hashCode = hashCode * 59 + this.CurrencyNegativeFormat.GetHashCode();
                if (this.CurrencyPositiveFormat != null)
                    hashCode = hashCode * 59 + this.CurrencyPositiveFormat.GetHashCode();
                if (this.DateFormat != null)
                    hashCode = hashCode * 59 + this.DateFormat.GetHashCode();
                if (this.DisplayFixedPriceContractLabor != null)
                    hashCode = hashCode * 59 + this.DisplayFixedPriceContractLabor.GetHashCode();
                if (this.DisplayRecurringServiceContractLabor != null)
                    hashCode = hashCode * 59 + this.DisplayRecurringServiceContractLabor.GetHashCode();
                if (this.DisplaySeparateLineItemForEachTax != null)
                    hashCode = hashCode * 59 + this.DisplaySeparateLineItemForEachTax.GetHashCode();
                if (this.DisplayTaxCategory != null)
                    hashCode = hashCode * 59 + this.DisplayTaxCategory.GetHashCode();
                if (this.DisplayTaxCategorySuperscripts != null)
                    hashCode = hashCode * 59 + this.DisplayTaxCategorySuperscripts.GetHashCode();
                if (this.DisplayZeroAmountRecurringServicesAndBundles != null)
                    hashCode = hashCode * 59 + this.DisplayZeroAmountRecurringServicesAndBundles.GetHashCode();
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.ItemizeItemsInEachGroup != null)
                    hashCode = hashCode * 59 + this.ItemizeItemsInEachGroup.GetHashCode();
                if (this.ItemizeServicesAndBundles != null)
                    hashCode = hashCode * 59 + this.ItemizeServicesAndBundles.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NonBillableLaborLabel != null)
                    hashCode = hashCode * 59 + this.NonBillableLaborLabel.GetHashCode();
                if (this.NumberFormat != null)
                    hashCode = hashCode * 59 + this.NumberFormat.GetHashCode();
                if (this.PageLayout != null)
                    hashCode = hashCode * 59 + this.PageLayout.GetHashCode();
                if (this.PageNumberFormat != null)
                    hashCode = hashCode * 59 + this.PageNumberFormat.GetHashCode();
                if (this.PaymentTerms != null)
                    hashCode = hashCode * 59 + this.PaymentTerms.GetHashCode();
                if (this.RateCostExpression != null)
                    hashCode = hashCode * 59 + this.RateCostExpression.GetHashCode();
                if (this.ShowGridHeader != null)
                    hashCode = hashCode * 59 + this.ShowGridHeader.GetHashCode();
                if (this.ShowVerticalGridLines != null)
                    hashCode = hashCode * 59 + this.ShowVerticalGridLines.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.TimeFormat != null)
                    hashCode = hashCode * 59 + this.TimeFormat.GetHashCode();
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
