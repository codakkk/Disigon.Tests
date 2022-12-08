using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Cyberneid.Disigon.Core.Tests
{
    public partial class Form1 : Form
    {
        // C:\Windows\System32\CIEPKI.dll
        private const string DefaultPKI = "C:\\Windows\\System32\\CIEPKI.dll";
        private const int SessionSlot = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DigitalSigner.Licensee = "licensee";
            DigitalSigner.ProductKey = "yourproductkey";                             
        }

        private void signTextButton_Click(object sender, EventArgs e)
        {
            if (!checkParam())
                return;

            try
            {
                string p11dll;
                if(textBoxP11.Text.ToLower().Equals("auto"))
                {
                    try
                    {
                        p11dll = DefaultPKI; //"bit4xpki.dll";
                    }
                    catch (DigitalSignatureException)
                    {
                        MessageBox.Show("No Matching pkcs11 dll found. Try to set the PKCS#11 dll instead of use 'auto'");
                        return;
                    }
                }
                else
                {
                    p11dll = textBoxP11.Text;
                }
                DigitalSigner dsign = new P11DigitalSigner(p11dll);

                // open a session taking the first available READER
                dsign.OpenSession(SessionSlot);

                // login
                dsign.Login(textBoxPIN.Text);

                dsign.Multisignature = false;
                dsign.Detached = false;

                SignedDocument sd = dsign.Sign(Encoding.Default.GetBytes(textToSign.Text), new SimpleCertificateSelector());
                byte[] data = sd.ToByteArray();

                dsign.Logout();

                dsign.CloseSession();
               
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.DefaultExt = "p7m";
                dlgSave.Filter = "Signature File (*.p7m)|*.p7m";
                if (dlgSave.ShowDialog(this) == DialogResult.OK)
                {
                    Stream stream = dlgSave.OpenFile();
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                }

            }
            catch (DigitalSignatureException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.AddExtension = true;
            dlgOpen.Filter = "All Files (*.*)|*.*";
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                fileToSign.Text = dlgOpen.FileName;
            }
        }

        private void signFileButton_Click(object sender, EventArgs e)
        {
            if (!checkParam())
                return;

            if (fileToSign.Text.Equals(""))
            {
                MessageBox.Show("No file selected");
                return;
            }

            try
            {
                FileStream fs = new FileStream(fileToSign.Text, FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();

                string p11dll;
                if (textBoxP11.Text.ToLower().Equals("auto"))
                {
                    try
                    {
                        p11dll = DefaultPKI;  //"bit3xpki.dll";// DigitalSigner.GetMatchingCryptokiPath();
                    }
                    catch (DigitalSignatureException)
                    {
                        MessageBox.Show("No Matching pkcs11 dll found. Try to set the PKCS#11 dll instead of use 'auto'");
                        return;
                    }
                }
                else
                {
                    p11dll = textBoxP11.Text;
                }
                DigitalSigner dsign = new P11DigitalSigner(p11dll);

                // open a session taking the first available READER
                dsign.OpenSession(SessionSlot);

                // login
                dsign.Login(textBoxPIN.Text);

                ICertificateSelector selector = new SimpleCertificateSelector();

                //if (checkBoxQualified.Checked)
                //    selector = new QualifiedCertificateSelector();
                //else
                //    selector = new SimpleCertificateSelector();

                // creates a TSA client

                TSAClient tsaClient = null;
                if (checkBoxTimeStamp.Checked)
                {                   
                    tsaClient = new TSAClient("https://freetsa.org/tsr");
                }

                dsign.Multisignature = checkBoxMultisignature.Checked;
                dsign.Detached = false;
                dsign.TsaClient = tsaClient;
                dsign.AddCACertificate = checkBoxAddCA.Checked;

                SignedDocument sd = dsign.Sign(data, selector);
                byte[] signedData = sd.ToByteArray();

                dsign.Logout();

                dsign.CloseSession();
              
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.DefaultExt = "p7m";
                dlgSave.Filter = "Signature File (*.p7m)|*.p7m";
                if (dlgSave.ShowDialog(this) == DialogResult.OK)
                {
                    Stream stream = dlgSave.OpenFile();
                    stream.Write(signedData, 0, signedData.Length);
                    stream.Close();
                }
            }
            catch (DigitalSignatureException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.AddExtension = true;
            dlgOpen.Filter = "Signed File(*.p7m)|*.p7m";
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                textBoxFileToVerify.Text = dlgOpen.FileName;
            }
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            if (textBoxFileToVerify.Text.Equals(""))
            {
                MessageBox.Show("No file selected");
                return;
            }

            try
            {
                var fs = new FileStream(textBoxFileToVerify.Text, FileMode.Open);
                var data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();

                var signedDoc = SignedDocument.FromByteArray(data);

                var signerCount = signedDoc.SignersCount;

                for (int i = 0; i < signerCount; i++)
                {
                    string crlStatus = null;

                    var verify = signedDoc.Verify(i);
                    var sigData = signedDoc.GetSigner(i);
                    
                    X509Certificate cert = sigData.SignerCertificate;
                    var cades = sigData.IsCades;
                    if(checkBoxCRL.Checked)
                    {                      
                        try
                        {
                            //RevocationStatus status0 = OCSPVerifier.CheckRevocationStatus(cert);
                            var status = CRLVerifier.CheckRevocationStatus(cert);
                            switch (status)
                            {
                                case RevocationStatus.Good:
                                    crlStatus = "Revocation Status OK";
                                    break;
                                case RevocationStatus.Revoked:
                                    crlStatus = "Revocation Status NOT OK";
                                    break;
                                case RevocationStatus.Unknown:
                                    break;
                                default:
                                    crlStatus = "Revocation Status is UNKNONW";
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                            crlStatus = "Revocation Status is UNKNONW";
                        }
                        //}
                    }

                    var message =
                        $"Signer: {sigData.SignerCommonName}\nSignature: {(verify ? "OK" : "NOT OK")}\nCAdES: {(cades ? "YES" : "NO")}\nCRL: {crlStatus}";
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void browsePDFButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.AddExtension = true;
            dlgOpen.Filter = "All Files (*.pdf)|*.pdf";
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                textBoxToSignPDF.Text = dlgOpen.FileName;
            }
        }

        private void signPDF_Click(object sender, EventArgs e)
        {
            if (!checkParam())
                return;

            if (textBoxToSignPDF.Text.Equals(""))
            {
                MessageBox.Show("No file selected");
                return;
            }

            try
            {
                string p11dll;
                if (textBoxP11.Text.ToLower().Equals("auto"))
                {
                    try
                    {
                        p11dll = DefaultPKI; // "bit4xpki.dll";
                    }
                    catch (DigitalSignatureException)
                    {
                        MessageBox.Show("No Matching pkcs11 dll found. Try to set the PKCS#11 dll instead of use 'auto'");
                        return;
                    }
                }
                else
                {
                    p11dll = textBoxP11.Text;
                }
                DigitalSigner digitalSigner = new P11DigitalSigner(p11dll);

                // open a session taking the first available READER
                digitalSigner.OpenSession(SessionSlot);

                // login
                digitalSigner.Login(textBoxPIN.Text);

                ICertificateSelector selector;
                selector = new SimpleCertificateSelector();

                
                // creates a TSA client
                TSAClient tsaClient = null;
                if (checkBoxPDFTimeStamp.Checked)
                    tsaClient = new TSAClient("https://freetsa.org/tsr");


                PDFDigitalSigner pdfSigner = new PDFDigitalSigner(digitalSigner);

                pdfSigner.AddCACertificate = checkBoxPDFAddCA.Checked;
                pdfSigner.TsaClient = tsaClient;
                pdfSigner.SignatureReason = "Test signature";
                pdfSigner.SignatureLocation = "Naples";
                pdfSigner.SignatureContact = "Ugo Chirico";
                pdfSigner.SignatureOnPage = 1;
                pdfSigner.SignaturePositionLowerLeftX = 200;
                pdfSigner.SignaturePositionLowerLeftY = 150;
                pdfSigner.SignaturePositionUpperRightX = 500;
                pdfSigner.SignaturePositionUpperRightY = 200;
                pdfSigner.FontSize = 10;
                //pdfSigner.SignatureImg = new Bitmap();
                //pdfSigner.SignatureMessage = "Signed by NDigitSign";


                FileStream inStream = new FileStream(textBoxToSignPDF.Text, FileMode.Open);
                FileStream outStream = new FileStream(textBoxToSignPDF.Text + ".signed.pdf", FileMode.Create);

                pdfSigner.Sign(inStream, selector, outStream);
                               
                digitalSigner.Logout();

                digitalSigner.CloseSession();

                inStream.Close();
                outStream.Close();

                if (checkBoxPDFLTV.Checked)
                {
                    PDFDigitalSigner.AddLTVInfo(textBoxToSignPDF.Text + ".signed.pdf", textBoxToSignPDF.Text + ".signed.ltv.pdf", tsaClient);
                    Open(textBoxToSignPDF.Text + ".signed.ltv.pdf");
                }
                else
                {
                    Open(textBoxToSignPDF.Text + ".signed.pdf");
                }
            }
            catch (DigitalSignatureException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void browseP11_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.AddExtension = true;
            dlgOpen.Filter = "DLL Files (*.dll)|*.dll";
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                textBoxP11.Text = dlgOpen.FileName;
            }
        }

        private bool checkParam()
        {
            if (textBoxP11.Text.Equals(""))
            {
                MessageBox.Show("No PKCS#11 module selected. Insert it the PKCS#11 module section");
                return false;
            }

            if (textBoxPIN.Text.Equals(""))
            {
                MessageBox.Show("No PIN inserted. Insert it the PIN section");
                return false;
            }

            return true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.AddExtension = true;
            dlgOpen.Filter = "PDF Files (*.pdf)|*.pdf";
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                textBoxPDFToVerify.Text = dlgOpen.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBoxPDFToVerify.Text, FileMode.Open);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();

            PDFSignatureVerifier pdfVerifier = new PDFSignatureVerifier();
            pdfVerifier.Load(data);


            int signerCount = pdfVerifier.SignatureCount;

            for (int i = 0; i < signerCount; i++)
            {
                DateTime signDate = pdfVerifier.GetSignedDate(i);

                Console.WriteLine(signDate.ToString());

                SignedDocument signedDoc = pdfVerifier.GetSignature(i);

                string crlStatus = null;

                bool verify = signedDoc.Verify(i);
                SignerData sigData = signedDoc.GetSigner(i);

                X509Certificate2 cert = sigData.SignerCertificate;
                bool cades = sigData.IsCades;
                if (checkBoxPDFCRL.Checked)
                {
                    bool crlVerified = cert.Verify();
                    if (crlVerified)
                        crlStatus = "Revocation Status OK";
                    else
                        crlStatus = "Revocation Status NOT OK";
                }

                string message = string.Format("Signer: {0}\nSignature: {1}\nCAdES: {2}\nCRL: {3}", sigData.SignerCommonName, verify ? "OK" : "NOT OK", cades ? "YES" : "NO", crlStatus);
                MessageBox.Show(message);
            }            
        }

        static void Open(string filename)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true }); // Works ok on windows
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", filename);  // Works ok on linux
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", filename); // Not tested
            }
            else
            {
            }
        }
    }
}