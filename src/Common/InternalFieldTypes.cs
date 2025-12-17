namespace Plexo.Models
{
    /// <summary>
    /// Defines standardized field types for merchant integration private metadata.
    /// </summary>
    /// <remarks>
    /// <para>
    /// These field types provide consistent keys for storing processor credentials and configuration
    /// in the encrypted private metadata dictionary. Each value is encrypted at rest.
    /// </para>
    /// <para>Additional custom keys can be stored as plain string keys when processor-specific fields are needed.</para>
    /// </remarks>
    public enum InternalFieldType
    {
        /// <summary>
        /// Controls whether CVV/CVC validation is skipped during payment authorization.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When set to "true", CVV validation is bypassed. This may be required for certain merchant categories
        /// (e.g., recurring payments, mail order) but can result in lower interchange rates and higher fraud risk.
        /// </para>
        /// <para><strong>Values:</strong> "true" or "false" (string)</para>
        /// <para><strong>Default:</strong> false (CVV required)</para>
        /// <para><strong>Security Note:</strong> Use only when business requirements necessitate. Document reason for compliance audits.</para>
        /// </remarks>
        /// <example>"false"</example>
        IgnoreCVV,

        /// <summary>
        /// Primary API key or secret for authenticating with the payment processor.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The main credential used for API authentication. Format varies by processor:
        /// </para>
        /// <list type="bullet">
        ///   <item><description><strong>STRIPE:</strong> Secret key (sk_live_... or sk_test_...)</description></item>
        ///   <item><description><strong>ADYEN:</strong> API key (AQE...)</description></item>
        ///   <item><description><strong>CYBERSOURCE:</strong> Shared secret key for HMAC signing</description></item>
        ///   <item><description><strong>PAYPAL:</strong> Client secret for OAuth</description></item>
        /// </list>
        /// <para><strong>Security:</strong> Never expose in logs, responses, or error messages. Rotate regularly per processor policy.</para>
        /// </remarks>
        /// <example>"sk_live_51MbxYz2eZvKYlo2C..." (Stripe) or "AQEvhmfx..." (Adyen)</example>
        ProviderApiKey
    }
}
