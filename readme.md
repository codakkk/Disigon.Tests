# Disigon Tests

First of all, to use DisigonSDK, add it as NuGet package from ---LINK---

## Signing
To start signing, we have to create a DigitalSigner instance.
In our sdk, we provide a PKCS#11 implementation (P11DigitalSigner).

In the following example, we're using a PKCS#11 implementation.
Card Reader is on slot 1 and PIN is taken from a TextBox.
When signing, we're allowing the user to select the correct certificate (SimpleCertificateSelector).
There's also QualifiedCertificateSelector, same behaviour as SimpleCertificateSelector but for Qualified Certificates (with qualified certificate we mean a certificate for EU qualified digital signature).


```csharp
DigitalSigner dsign = new P11DigitalSigner(p11dll);

// opens a session taking the first available READER
// make sure the reader is on the correct slot, or an error will be thrown.
dsign.OpenSession(1);

// Login flow
dsign.Login(textBoxPIN.Text);

// In this example, we're not allowing multi-signature
dsign.Multisignature = false;
// We don't need a detached signature
dsign.Detached = false;

byte[] dataToSign = // can be a file, text, etc

// Signs the specified data and add a time stamp taken from the given TSA Client
SignedDocument sd = dsign.Sign(dataToSign, new SimpleCertificateSelector());
byte[] data = sd.ToByteArray();

dsign.Logout();

// Make sure to close the session before exiting.
dsign.CloseSession();

// ....
```

## Step by Step usage
First of all, initialize licensee and product key:
```csharp
private void Form1_Load(object sender, EventArgs e)
{
  DigitalSigner.Licensee = "your_license_key";
  DigitalSigner.ProductKey = "your_product_key";
}
```
From there on create a DigitalSigner instance. In our case, we're using a PKCS#11 implementation.
As parameter, it takes a native cryptoki path.
```csharp
DigitalSigner dsign = new P11DigitalSigner(p11dll);
```

Then we need to call OpenSession to open session. It takes a slot index as parameter, indicating the reader to choose. Make sure to pick the right slot index.
```csharp
dsign.OpenSession(0);
```

After that we have to start the login flow. It requires a string as parameter, indicating the last 4 PIN digits.

```csharp
dsign.Login("3344");
```

Following we can edit some properties of our Digital Signer.
For example, we are going to enable Multisignature, disable Detached signature, use a TSAClient and add a CA Certificate. More properties can be found on [documentation](link).

```csharp
TSAClient tsaClient = new TSAClient("https://freetsa.org/tsr");
dsign.Multisignature = true;
dsign.Detached = false;
dsign.TsaClient = tsaClient;
dsign.AddCACertificate = true;
```

From there on, before actually signing, we have to provide a Certificate.
To do that, we have two ways:
- Provide a ICertificateSelector instance ([SimpleCertificateSelector]() or [QualifiedCertificateSelector]()).
- Provide a CertificateInfo instance.

For example, we decided to proceed with [SimpleCertificateSelector]().-
```csharp
SimpleCertificateSelector selector = new SimpleCertificateSelector();
```

We can finally sign our data. (More on [SignedDocument]() in our documentatioon).
For dimostrating purposes, we're also converting the signed document into a byte array.
```csharp
byte[] dataToSign = /* ....*/;
SignedDocument signedDocument = dsign.Sign(dataToSign, selector);
byte[] signedData = signedDocument.ToByteArray();
```

After all, we have to logout and close the previous session:
```csharp
dsign.Logout();
dsign.CloseSession();
```
