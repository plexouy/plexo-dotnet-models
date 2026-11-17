# Plexo.Models

`Plexo.Models` provides shared .NET contracts for Plexo integrations. Use it to build typed payment requests and work with transactions, payment instruments, checkout sessions, and callbacks. Your API client handles HTTP requests, authentication, and message signing.

The package targets **.NET Standard 2.0** and can be used from compatible .NET applications.

## Install

From the directory containing your application project, run:

```sh
dotnet package add Plexo.Models
```

With the .NET 9 SDK or earlier, use `dotnet add package Plexo.Models`.

## Create a payment request

Use the currency ID for your Plexo integration, the token returned by your tokenization flow, and your own order reference. This example creates a single-item payment request for one installment.

```csharp
using System.Collections.Generic;
using Plexo.Models;

static PaymentRequest CreatePaymentRequest(
    string orderReference, int currencyId, string instrumentToken, decimal amount)
{
    return new PaymentRequest
    {
        ClientReferenceId = orderReference,
        CurrencyId = currencyId,
        Installments = 1,
        PaymentInstrumentInput = new PaymentInstrumentInput
        {
            InstrumentToken = instrumentToken
        },
        Items = new List<Item>
        {
            new Item { Name = "Order item", Quantity = 1, Amount = amount }
        }
    };
}
```

Pass the request to the Plexo client for your integration. If you serialize requests or callbacks yourself, follow your endpoint's serialization and signing requirements. Many of the models declare their serialized members with `[DataContract]` and `[DataMember]`.

## Model overview

Most types are in the `Plexo.Models` namespace.

| Area | Example types |
| --- | --- |
| Transactions | `PaymentRequest`, `ReserveRequest`, `CancelRequest`, `RefundRequest`, `Transaction`, `TransactionCallback` |
| Payment instruments | `PaymentInstrument`, `PaymentInstrumentInput`, `CreateExternalInstrumentRequest` |
| Checkout and tokenization | `ExpressCheckoutRequest`, `Session`, `TokenizationSettings` |
| Commerces and issuers | `Commerce`, `IssuerInfo` |
| 3-D Secure | `ThreeDSSession`, `ThreeDSValidation` in `Plexo.Models.ThreeDS` |
| Shared contracts | `Currency`, `ResultCodes`, `SignedObject<T>` |

## License and source

Licensed under the GNU Affero General Public License v3.0 or later ([AGPL-3.0-or-later](https://spdx.org/licenses/AGPL-3.0-or-later.html)).

[NuGet package](https://www.nuget.org/packages/Plexo.Models) · [Source repository](https://github.com/plexouy/plexo-dotnet-models)
