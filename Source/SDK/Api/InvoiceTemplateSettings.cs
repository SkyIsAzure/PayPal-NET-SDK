//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// Template settings.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class InvoiceTemplateSettings : PayPalSerializableObject
    {
        /// <summary>
        /// The field name for any field in `template_data` for which to map corresponding display preferences.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "field_name")]
        public string field_name { get; set; }

        /// <summary>
        /// The settings metadata for each field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "display_preference")]
        public InvoiceTemplateSettingsMetadata display_preference { get; set; }
    }
}
