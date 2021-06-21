using System.Collections.Generic;
using Plexo.Models.Common;

namespace Plexo.Models.Issuers
{
    public class BankDto
    {
        public int Id { get; set; }
        public string Pattern { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Prepaid { get; set; }
        public string Type { get; set; } // credit, debit
        public bool LockedPurchases { get; set; } // Requiere habilitar homebanking ej itau
        public string ExternalId { get; set; }
        public string PictureUrl { get; set; }
        public bool Enabled { get; set; }
    }
    public class PaymentIssuerSettingsDto
    {
        public BinSettingsDto Bin { get; set; }
        public CardNumberSettingsDto CardNumber { get; set; }
        public SecurityCodeSettingsDto SecurityCode { get; set; }
        public CommerceSettingsDto Commerce { get; set; }
    }

    public class CommerceSettingsDto
    {
        public IEnumerable<CommerceField> Fields { get; set; }
    }

    public class BinSettingsDto
    {
        public string Pattern { get; set; }
    }

    public class SecurityCodeSettingsDto
    {
        public int Length { get; set; }
        public bool Required { get; set; }
    }

    public class CardNumberSettingsDto
    {
        public int Length { get; set; }
        public bool Luhn { get; set; }
    }

    public class PaymentIssuerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string Type { get; set; }
        public PaymentIssuerSettingsDto Settings { get; set; }
        public IEnumerable<IssuerField> Fields { get; set; }
        public IEnumerable<BankDto> Banks { get; set; }
        public bool Enabled { get; set; }
        public bool IsAsync { get; set; }
    }

    public class IssuerField
    {
        public string Name { get; set; }
        public FieldType Type { get; set; }
        public string Value { get; set; }
        public string Width { get; set; } = "normal";
    }

    public class CommerceField
    {
        public string Name { get; set; }
        public FieldType Type { get; set; }
    }
}
