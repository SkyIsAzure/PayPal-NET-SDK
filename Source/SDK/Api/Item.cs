//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace PayPal.Api
{
    /// <summary>
    /// Item details.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class Item : PayPalSerializableObject
    {
        /// <summary>
        /// Stock keeping unit corresponding (SKU) to item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sku")]
        public string sku { get; set; }

        /// <summary>
        /// Item name. 127 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string name { get; set; }

        /// <summary>
        /// Description of the item. Only supported when the `payment_method` is set to `paypal`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string description { get; set; }

        /// <summary>
        /// Number of a particular item. 10 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public string quantity { get; set; }

        /// <summary>
        /// Item cost. 10 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price")]
        public string price { get; set; }

        /// <summary>
        /// 3-letter [currency code](https://developer.paypal.com/docs/integration/direct/rest_api_payment_country_currency_support/).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string currency { get; set; }

        /// <summary>
        /// Tax of the item. Only supported when the `payment_method` is set to `paypal`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax")]
        public string tax { get; set; }

        /// <summary>
        /// URL linking to item information. Available to payer in transaction history.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url")]
        public string url { get; set; }

        /// <summary>
        /// Set of optional data used for PayPal risk determination.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supplementary_data")]
        public List<NameValuePair> supplementary_data { get; set; }

        /// <summary>
        /// Set of optional data used for PayPal post-transaction notifications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postback_data")]
        public List<NameValuePair> postback_data { get; set; }

        #region Unsupported Properties
        /// <summary>
        /// Category type of the item.
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public string category { get; set; }

        /// <summary>
        /// Weight of the item.
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public Measurement weight { get; set; }

        /// <summary>
        /// Length of the item.
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public Measurement length { get; set; }

        /// <summary>
        /// Height of the item.
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public Measurement height { get; set; }

        /// <summary>
        /// Width of the item.
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public Measurement width { get; set; }
        #endregion
    }
}
