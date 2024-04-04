using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;

namespace Metin_Doğrulama_Yedek5
{
    public partial class Form1 : Form
    {
        public AnaSayfa anasayfa;
        private XmlReader reader;
        private XmlReader reader2;
        private XmlReader reader3;
        private XmlReader reader4;
        private XmlReader reader5;
        private XmlReader reader6;
        private XmlReader reader7;
        private XmlReader reader8;
        private XmlReader reader9;
        private XmlReader reader10;
        private XmlReader reader11;
        private XmlReader reader12;
        private XmlReader reader13;
        private XmlReader reader14;
        private XmlReader reader15;
        private XmlReader reader16;
        private XmlReader reader17;
        private XmlReader reader18;
        private XmlReader reader19;
        private XmlReader reader20;
        private XmlReader reader21;
        private XmlReader reader22;
        private XmlReader reader23;
        private XmlReader reader24;
        private XmlReader reader25;
        private XmlReader reader26;
        private XmlReader reader27;
        private XmlReader reader28;
        private XmlReader reader29;
        private XmlReader reader30;
        private XmlReader reader31;
        private XmlReader reader32;
        private XmlReader reader33;
        private XmlReader reader34;
        private XmlReader reader35;
        private XmlReader reader36;
        private XmlReader reader37;
        private XmlReader reader38;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label83.Text = AnaSayfa.dosyaYoluDegiskeni;//Ana Sayfada dosya yolunun uzantısını alırken label83 kullanılıyor.
            reader = XmlReader.Create(label83.Text, new XmlReaderSettings());//XML okumak için 1. döngü.
            reader2 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader3 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader4 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader5 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader6 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader7 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader8 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader9 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader10 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader11 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader12 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader13 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader14 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader15 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader16 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader17 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader18 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader19 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader20 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader21 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader22 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader23 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader24 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader25 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader26 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader27 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader28 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader29 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader30 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader31 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader32 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader33 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader34 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader35 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader36 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader37 = XmlReader.Create(label83.Text, new XmlReaderSettings());
            reader38 = XmlReader.Create(label83.Text, new XmlReaderSettings());


            Oku();//Verileri aktifleştirmek;
            reader.Close();
            Kontrol();
            label83.Hide();



        }
        private void Oku()
        {
            //Döngüler halinde XML tamamının verileri çekmek.
            while (reader.Read())
            {
                OkuUblVersionID();
                OkuCustomizationID();
                OkuProfileID(); 
                OkuUUID();
                OkuIssueDate();
                OkuInvoiceTypeCode();
                OkuDocumentCurrencyCode();
                OkuLineCountNumeric();
                
               




            }
            while (reader2.Read())
            {
                OkuID1();
                


            }
            while (reader3.Read())
            {
                OkuIssueDate2();
                

            }
            while (reader4.Read())
            {
                OkuDocumentType();
              

            }
            while (reader5.Read())
            {
                OkuRoom();
               
            }
            while (reader6.Read())
            {
                OkuStreetName();
                OkuCitySubdivisionName();
            }
            while (reader7.Read())
            {
              
                OkuCitySubdivisionName();
            }
            while (reader8.Read())
            {

                OkuCityName();
            
            }
            while (reader9.Read())
            {

             
                OkuPostalZone();
            }
            while (reader10.Read())
            {

                OkuRegion();


            }
            while (reader11.Read())
            {

                OkuName();


            }
            while (reader12.Read())
            {
                OkuTelephone();
               

            }
            while (reader13.Read())
            {
                OkuElectronicMail();
             

            }
            while (reader14.Read())
            {
                OkuSourceCurrencyCode();

            }
            while (reader15.Read())
            {
                OkuTargetCurrencyCode();

            }
            while (reader16.Read())
            {
                OkuCalculationRate();

            }
            while (reader17.Read())
            {
                OkuTaxAmount();

            }
            while (reader18.Read())
            {
                OkuTaxableAmount();

            }
            while (reader19.Read())
            {
                OkuCalculationSequenceNumeric();

            }
            while (reader20.Read())
            {
                OkutxtPercent1();
            }
            while (reader21.Read())
            {
                OkutxtPercent();
            }
            while (reader22.Read())
            {
                OkuLineExtensionAmount();
            }
            while (reader23.Read())
            {
                OkuTaxExclusiveAmount();
            }
            while (reader24.Read())
            {
                OkuTaxInclusiveAmount();
            }
            while (reader25.Read())
            {
                OkuAllowanceTotalAmount();
            }
            while (reader26.Read())
            {
                OkuChargeTotalAmount();
            }
            while (reader27.Read())
            {
                OkuPayableAmount();
            }
            while (reader28.Read())
            {
                OkuInvoicedQuantity();
            }
            while (reader29.Read())
            {
                OkuChargeIndicator();
            }
            while (reader30.Read())
            {
                OkuAmount();
            }
            while (reader31.Read())
            {
                OkuBaseAmount();
            }
            while (reader32.Read())
            {
                OkuIdentificationCode();
            }
            while (reader33.Read())
            {
                OkuPriceAmount();
            }
            while (reader34.Read())
            {
                OkuCopyIndicator();
            }
            while (reader35.Read())
            {
                OkuIssueDate();
            }
            while (reader36.Read())
            {
                OkuInvoiceTypeCode();
            }
            while (reader37.Read())
            {
                OkuDocumentCurrencyCode();
            }
            while (reader38.Read())
            {
                OkuLineCountNumeric();
            }



        }
        private void  OkuUblVersionID()
        {
           
            if (reader.NodeType == XmlNodeType.Element)
            {
                string name = reader.Name;
                if (name == "cbc:UBLVersionID")
                {
                    txtcbcUBLVersionID.Text = reader.ReadElementString();

                    int uzunluk = txtcbcUBLVersionID.Text.ToString().Length;

                   
                }
            }
        }
        private void OkuCustomizationID()
        {
           
            if (reader.NodeType == XmlNodeType.Element)
            {
                string name = reader.Name;
                if (name == "cbc:CustomizationID")
                {
                    txtcbcCustomizationID.Text = reader.ReadElementString();

                    int uzunluk = txtcbcCustomizationID.Text.ToString().Length;
                   
                    
                }
            }
        }
        private void OkuProfileID()
        {
           
            if (reader.NodeType == XmlNodeType.Element)
            {
                string name = reader.Name;

                if (name == "cbc:ProfileID")
                {

                    txtcbcProfileID.Text = reader.ReadElementString();
                    int uzunluk = txtcbcProfileID.Text.ToString().Length;
                    lblProfileID.Text = "Uzunluk" + uzunluk.ToString();
                    
                }

            }
        }
       
        private void OkuCopyIndicator()
        {
           
            if (reader34.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader34.Read())
                {
                    if (reader34.NodeType == XmlNodeType.Element && reader34.Name == "cbc:CopyIndicator")
                    {
                        string value = reader34.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtcbcCopyIndicator.Text = value;


                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuUUID()
        {
        
            if (reader.NodeType == XmlNodeType.Element)
            {
                string name = reader.Name;
                if (name == "cbc:UUID")
                {
                    txtcbcUUID.Text = reader.ReadElementString();
                    int uzunluk2 = txtcbcUUID.Text.Length;
                    label85.Text = "Uzunluk: " + uzunluk2.ToString();
                    
                    if (uzunluk2 == 36)
                    {
                        txtcbcUUID.BackColor = Color.Green;
                    }

                }



            }
        }
        private void OkuIssueDate()
        {
        
            if (reader35.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader35.Read())
                {
                    if (reader35.NodeType == XmlNodeType.Element && reader35.Name == "cbc:IssueDate")
                    {
                        string value = reader35.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtcbcIssueDate.Text = value;


                                
                            }


                            i++;
                        }
                    }
                }

            }
        }

        private void OkuInvoiceTypeCode()
        {
            
            if (reader36.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader36.Read())
                {
                    if (reader36.NodeType == XmlNodeType.Element && reader36.Name == "cbc:InvoiceTypeCode")
                    {
                        string value = reader36.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtcbcInvoiceTypeCode.Text = value;


                                
                            }


                            i++;
                        }
                    }
                }

            }
        }

        private void OkuDocumentCurrencyCode()
        {
           
            if (reader37.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader37.Read())
                {
                    if (reader37.NodeType == XmlNodeType.Element && reader37.Name == "cbc:DocumentCurrencyCode")
                    {
                        string value = reader37.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtcbcDocumentCurrencyCode.Text = value;


                            }


                            i++;
                        }
                    }
                }

            }
        }

        private void OkuLineCountNumeric()
        {
          
            if (reader38.NodeType == XmlNodeType.Element)
            {//
                int i = 0;

                while (reader38.Read())
                {
                    if (reader38.NodeType == XmlNodeType.Element && reader38.Name == "cbc:LineCountNumeric")
                    {
                        string value = reader38.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtcbcLineCountNumeric.Text = value;


                            }


                            i++;
                        }
                    }
                }

            }
        }
        
        private void OkuID1()
        {
            if (reader2.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader2.Read())
                {
                    if (reader2.NodeType == XmlNodeType.Element && reader2.Name == "cbc:ID")
                    {
                        string value = reader2.ReadElementContentAsString();

                        if (i < 9)
                        {
                            if (i == 0)
                            {
                                txtcbcID.Text = value;
                                int uzunluk1= txtcbcID.Text.Length;
                                label84.Text = "Uzunluk: " + uzunluk1.ToString();
                                
                                if (uzunluk1 == 16)
                                {
                                    txtcbcID.BackColor = Color.Green;
                                }


                            }
                            else if (i == 1)
                            {
                                txtcbcID2.Text = value;

                                int uzunluk1 = txtcbcID2.Text.Length;

                               

                            }
                            else if (i == 2)
                            {
                                txtcbcID3.Text = value;
                                int uzunluk3 = txtcbcID3.Text.Length;
                                label86.Text = "Uzunluk: " + uzunluk3.ToString();

                                

                            }
                            else if (i == 3)
                            {
                                txtcbcID4.Text = value;
                                int uzunluk4 = txtcbcID4.Text.Length;
                                label87.Text = "Uzunluk: " + uzunluk4.ToString();
                               

                            }
                            else if (i == 4)
                            {
                                txtcbcID5.Text = value;
                                int uzunluk5 = txtcbcID5.Text.Length;
                                label88.Text = "Uzunluk: " + uzunluk5.ToString();
                              
                            }
                            else if (i == 5)
                            {
                                txtcbcIdMersısno.Text = value;
                                int uzunluk6 = txtcbcIdMersısno.Text.Length;
                                label89.Text = "Uzunluk: " + uzunluk6.ToString();
                              
                                if (uzunluk6 == 16)
                                {
                                    txtcbcIdMersısno.BackColor = Color.Green;
                                }
                            }
                            else if (i == 6)
                            {
                                txtcbcID7.Text = value;
                                int uzunluk7 = txtcbcID7.Text.Length;
                                label90.Text = "Uzunluk: " + uzunluk7.ToString();
                               
                                if (uzunluk7 == 10)
                                {
                                    txtcbcID7.BackColor = Color.Green;
                                }
                            }
                            else if (i == 7)
                            {
                                txtcbcID8.Text = value;
                                int uzunluk9 = txtcbcID8.Text.Length;
                                label92.Text = "Uzunluk: " + uzunluk9.ToString();
                               
                                if (uzunluk9 == 10)
                                {
                                    txtcbcID8.BackColor = Color.Green;
                                }
                            }
                            else if (i == 8)
                            {
                                txtcbcID9.Text = value;

                                int uzunluk1 = txtcbcID9.Text.Length;

                               
                            }
                            i++;
                        }
                    }
                }

            }

        }
        private void OkuIssueDate2()
        {
       
            if (reader3.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader3.Read())
                {
                    if (reader3.NodeType == XmlNodeType.Element && reader3.Name == "cbc:IssueDate")
                    {
                        string value = reader3.ReadElementContentAsString();

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtcbcIssueDate.Text = value;

                                int uzunluk1 = txtcbcIssueDate.Text.Length;

                                

                            }
                            else if (i == 1)
                            {
                                txtcbcIssueDate2.Text = value;

                                int uzunluk1 = txtcbcIssueDate2.Text.Length;

                                
                            }
                            else if (i == 2)
                            {
                                txtcbcIssueDate3.Text = value;

                                int uzunluk1 = txtcbcIssueDate3.Text.Length;

                               
                            }

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuDocumentType()
        {
       
            if (reader4.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader4.Read())
                {
                    if (reader4.NodeType == XmlNodeType.Element && reader4.Name == "cbc:DocumentType")
                    {
                        string value = reader4.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtcbcDocumentTypeQrcode.Text = value;

                                int uzunluk1 = txtcbcDocumentTypeQrcode.Text.Length;

                               
                            }
                            else if (i == 1)
                            {
                                txtcbcDocumentTypeXSLT.Text = value;

                                int uzunluk1 = txtcbcDocumentTypeXSLT.Text.Length;

                                
                            }
                            

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuRoom()
        {
            
            if (reader5.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader5.Read())
                {
                    if (reader5.NodeType == XmlNodeType.Element && reader5.Name == "cbc:Room")
                    {
                        string value = reader5.ReadElementContentAsString();

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtRoom1.Text = value;

                                int uzunluk1 = txtRoom1.Text.Length;

                               

                            }
                            else if (i == 1)
                            {
                                txtRoom2.Text = value;

                                int uzunluk1 = txtRoom2.Text.Length;

                              

                            }
                            else if (i == 2)
                            {
                                txtRoom3.Text = value;

                                int uzunluk1 = txtRoom3.Text.Length;

                              
                            }
                           
                            i++;
                        }
                    }
                }

            }
        }
        private void OkuStreetName()
        {
           
            if (reader6.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader6.Read())
                {
                    if (reader6.NodeType == XmlNodeType.Element && reader6.Name == "cbc:StreetName")
                    {
                        string value = reader6.ReadElementContentAsString();

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtStreetName1.Text = value;

                                int uzunluk1 = txtStreetName1.Text.Length;

                               

                            }
                            else if (i == 1)
                            {
                                txtStreetName2.Text = value;

                                int uzunluk1 = txtStreetName2.Text.Length;

                              
                            }
                            else if (i == 2)
                            {
                                txtStreetName3.Text = value;
                                int uzunluk1 = txtStreetName3.Text.Length;

                            }

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuCitySubdivisionName()
        {
           
            if (reader7.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader7.Read())
                {
                    if (reader7.NodeType == XmlNodeType.Element && reader7.Name == "cbc:CitySubdivisionName")
                    {
                        string value = reader7.ReadElementContentAsString();

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtCitySubdivisionName1.Text = value;
                                int uzunluk1 = txtCitySubdivisionName1.Text.Length;

                                

                            }
                            else if (i == 1)
                            {
                                txtCitySubdivisionName2.Text = value;
                                int uzunluk1 = txtCitySubdivisionName2.Text.Length;

                               
                            }
                            else if (i == 2)
                            {
                                txtCitySubdivisionName3.Text = value;
                                int uzunluk1 = txtCitySubdivisionName3.Text.Length;

                            }

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuCityName()
        {
         
            if (reader8.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader8.Read())
                {
                    if (reader8.NodeType == XmlNodeType.Element && reader8.Name == "cbc:CityName")
                    {
                        string value = reader8.ReadElementContentAsString();

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtCityName1.Text = value;
                                int uzunluk1 = txtCityName1.Text.Length;


                            }
                            else if (i == 1)
                            {
                                txtCityName2.Text = value;
                                int uzunluk1 = txtCityName2.Text.Length;

                                
                            }
                            else if (i == 2)
                            {
                                txtCityName3.Text = value;
                                int uzunluk1 = txtCityName3.Text.Length;

                                
                            }

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuPostalZone()
        {
           
            if (reader9.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader9.Read())
                {
                    if (reader9.NodeType == XmlNodeType.Element && reader9.Name == "cbc:PostalZone")
                    {
                        string value = reader9.ReadElementContentAsString();

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtPostalZone1.Text = value;
                                int uzunluk1 = txtPostalZone1.Text.Length;

                               
                            }
                            else if (i == 1)
                            {
                                txtPostalZone2.Text = value;
                                int uzunluk1 = txtPostalZone2.Text.Length;

                               
                            }
                            else if (i == 2)
                            {
                                txtPostalZone3.Text = value;
                                int uzunluk1 = txtPostalZone3.Text.Length;

                                
                            }

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuRegion()
        {
            
            if (reader10.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader10.Read())
                {
                    if (reader10.NodeType == XmlNodeType.Element && reader10.Name == "cbc:Region")
                    {
                        string value = reader10.ReadElementContentAsString();

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtRegion1.Text = value;
                                int uzunluk1 = txtRegion1.Text.Length;

                               

                            }
                            else if (i == 1)
                            {
                                txtRegion2.Text = value;
                                int uzunluk1 = txtRegion2.Text.Length;

                               
                            }
                            else if (i == 2)
                            {
                                txtRegion3.Text = value;
                                int uzunluk1 = txtRegion3.Text.Length;

                                
                            }

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuName()
        {
            
            if (reader11.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader11.Read())
                {
                    if (reader11.NodeType == XmlNodeType.Element && reader11.Name == "cbc:Name")
                    {
                        string value = reader11.ReadElementContentAsString();

                        if (i <11)
                        {
                            if (i == 0)
                            {
                                txtName1.Text = value;
                                int uzunluk1 = txtName1.Text.Length;

                               

                            }
                            else if (i == 1)
                            {
                                txtName2.Text = value;
                                int uzunluk1 = txtName2.Text.Length;

                            }
                            else if (i == 2)
                            {
                                txtName3.Text = value;
                                int uzunluk1 = txtName3.Text.Length;

                               
                            }
                            else if (i == 3)
                            {
                                txtName4.Text = value;
                                int uzunluk1 = txtName4.Text.Length;

                            }
                            else if (i == 4)
                            {
                                txtName5.Text = value;
                                int uzunluk1 = txtName5.Text.Length;

                                
                            }
                            else if (i == 5)
                            {
                                txtName6.Text = value;
                                int uzunluk1 = txtName6.Text.Length;

                                
                            }
                            else if (i == 6)
                            {
                                txtName7.Text = value;
                                int uzunluk1 = txtName7.Text.Length;

                                
                            }
                            else if (i == 7)
                            {
                                txtName8.Text = value;
                                int uzunluk1 = txtName8.Text.Length;

                               
                            }
                            else if (i == 8)
                            {
                                txtName9.Text = value;
                                int uzunluk1 = txtName9.Text.Length;

                                
                            }
                            else if (i == 9)
                            {
                                txtName10.Text = value;
                                int uzunluk1 = txtName10.Text.Length;

                                
                            }
                            else if (i == 10)
                            {
                                txtName11.Text = value;
                                int uzunluk1 = txtName11.Text.Length;

                                
                            }
                            


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuTelephone()
        {
           
            if (reader12.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader12.Read())
                {
                    if (reader12.NodeType == XmlNodeType.Element && reader12.Name == "cbc:Telephone")
                    {
                        string value = reader12.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtTelephone1.Text = value;
                                


                               

                               
                            }
                            else if (i == 1)
                            {
                                txtTelephone2.Text = value;
                               
                                
                            }
                           


                            i++;
                        }
                    }
                }

            }
        }

        private void OkuElectronicMail()
        {
           
            if (reader13.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader13.Read())
                {
                    if (reader13.NodeType == XmlNodeType.Element && reader13.Name == "cbc:ElectronicMail")
                    {
                        string value = reader13.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtElectronicMail1.Text = value;
                                int uzunluk1 = txtElectronicMail1.Text.Length;

                               

                            }
                            else if (i == 1)
                            {
                                txtElectronicMail2.Text = value;
                                int uzunluk1 = txtElectronicMail2.Text.Length;
                               
                            }



                            i++;
                        }
                    }
                }

            }
        }
        private void OkuSourceCurrencyCode()
        {
            
            if (reader14.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader14.Read())
                {
                    if (reader14.NodeType == XmlNodeType.Element && reader14.Name == "cbc:SourceCurrencyCode")
                    {
                        string value = reader14.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtSourceCurrencyCode.Text = value;

                                int uzunluk1 = txtSourceCurrencyCode.Text.Length;

                              
                            }
                            



                            i++;
                        }
                    }
                }

            }
        }
        private void OkuTargetCurrencyCode()
        {
            
            if (reader15.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader15.Read())
                {
                    if (reader15.NodeType == XmlNodeType.Element && reader15.Name == "cbc:TargetCurrencyCode")
                    {
                        string value = reader15.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtTargetCurrencyCode.Text = value;

                                int uzunluk1 = txtTargetCurrencyCode.Text.Length;

                               
                            }




                            i++;
                        }
                    }
                }

            }
        }
        private void OkuCalculationRate()
        {
           
            if (reader16.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader16.Read())
                {
                    if (reader16.NodeType == XmlNodeType.Element && reader16.Name == "cbc:CalculationRate")
                    {
                        string value = reader16.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtCalculationRate.Text = value;

                                int uzunluk1 = txtCalculationRate.Text.Length;

                                
                            }




                            i++;
                        }
                    }
                }

            }
        }
        private void OkuTaxAmount()
        {
           
            if (reader17.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader17.Read())
                {
                    if (reader17.NodeType == XmlNodeType.Element && reader17.Name == "cbc:TaxAmount")
                    {
                        string value = reader17.ReadElementContentAsString();

                        if (i < 4)
                        {
                            if (i == 0)
                            {
                                txtTaxAmount1.Text = value;

                                int uzunluk1 = txtTaxAmount1.Text.Length;

                                

                            }
                            else if (i == 1)
                            {
                                txtTaxAmount2.Text = value;
                                int uzunluk1 = txtTaxAmount2.Text.Length;

                               

                            }
                            else if (i == 2)
                            {
                                txtTaxAmount3.Text = value;
                                int uzunluk1 = txtTaxAmount3.Text.Length;


                            }
                            else if (i == 3)
                            {
                                txtTaxAmount4.Text = value;
                                int uzunluk1 = txtTaxAmount4.Text.Length;

                                

                            }




                            i++;
                        }
                    }
                }

            }
        }

        private void OkuTaxableAmount()
        {
           
            if (reader18.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader18.Read())
                {
                    if (reader18.NodeType == XmlNodeType.Element && reader18.Name == "cbc:TaxableAmount")
                    {
                        string value = reader18.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtTaxableAmount1.Text = value;
                                int uzunluk1 = txtTaxableAmount1.Text.Length;

                               


                            }
                            else if (i == 1)
                            {
                                txtTaxableAmount2.Text = value;
                                int uzunluk1 = txtTaxableAmount2.Text.Length;

                                

                            }




                            i++;
                        }
                    }
                }

            }
        }
        private void OkuCalculationSequenceNumeric()
        {
           
            if (reader19.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader19.Read())
                {
                    if (reader19.NodeType == XmlNodeType.Element && reader19.Name == "cbc:CalculationSequenceNumeric")
                    {
                        string value = reader19.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtCalculationSequenceNumeric1.Text = value;
                                int uzunluk1 = txtCalculationSequenceNumeric1.Text.Length;

                                


                            }
                            else if (i == 1)
                            {
                                txtCalculationSequenceNumeric2.Text = value;

                                int uzunluk1 = txtCalculationSequenceNumeric2.Text.Length;

                                
                            }




                            i++;
                        }
                    }
                }

            }
        }
        private void OkutxtPercent1()
        {
            
            if (reader20.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader20.Read())
                {
                    if (reader20.NodeType == XmlNodeType.Element && reader20.Name == "cbc:Percent")
                    {
                        string value = reader20.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtPercent1.Text = value;
                                int uzunluk1 = txtPercent1.Text.Length;

                                


                            }
                            else if (i == 1)
                            {
                                txtPercent2.Text = value;
                                int uzunluk1 = txtPercent2.Text.Length;

                                

                            }




                            i++;
                        }
                    }
                }

            }
        }
        private void OkutxtPercent()
        {
           
            if (reader21.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader21.Read())
                {
                    if (reader21.NodeType == XmlNodeType.Element && reader21.Name == "cbc:TaxTypeCode")
                    {
                        string value = reader21.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtTaxTypeCode1.Text = value;

                                int uzunluk1 = txtTaxTypeCode1.Text.Length;

                                

                            }
                            else if (i == 1)
                            {
                                txtTaxTypeCode2.Text = value;
                                int uzunluk1 = txtTaxTypeCode2.Text.Length;

                                

                            }




                            i++;
                        }
                    }
                }

            }
        }
        private void OkuLineExtensionAmount()
        {
            if (reader22.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader22.Read())
                {
                    if (reader22.NodeType == XmlNodeType.Element && reader22.Name == "cbc:LineExtensionAmount")
                    {
                        string value = reader22.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtLineExtensionAmount1.Text = value;

                                int uzunluk1 = txtLineExtensionAmount1.Text.Length;

                               

                            }
                            else if (i == 1)
                            {
                                txtLineExtensionAmount2.Text = value;
                                int uzunluk1 = txtLineExtensionAmount2.Text.Length;

                               

                            }




                            i++;
                        }
                    }
                }

            }
        }
        private void OkuTaxExclusiveAmount()
        {
            if (reader23.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader23.Read())
                {
                    if (reader23.NodeType == XmlNodeType.Element && reader23.Name == "cbc:TaxExclusiveAmount")
                    {
                        string value = reader23.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtTaxExclusiveAmount.Text = value;
                                int uzunluk1 = txtTaxExclusiveAmount.Text.Length;

                                
                            }
                           

                            i++;
                        }
                    }
                }

            }
        }
        private void OkuTaxInclusiveAmount()
        {
            if (reader24.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader24.Read())
                {
                    if (reader24.NodeType == XmlNodeType.Element && reader24.Name == "cbc:TaxInclusiveAmount")
                    {
                        string value = reader24.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtTaxInclusiveAmount.Text = value;
                                int uzunluk1 = txtTaxInclusiveAmount.Text.Length;

                               
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuAllowanceTotalAmount()
        {
            if (reader25.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader25.Read())
                {
                    if (reader25.NodeType == XmlNodeType.Element && reader25.Name == "cbc:AllowanceTotalAmount")
                    {
                        string value = reader25.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtAllowanceTotalAmount.Text = value;
                                int uzunluk1 = txtAllowanceTotalAmount.Text.Length;

                               
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuChargeTotalAmount()
        {
            if (reader26.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader26.Read())
                {
                    if (reader26.NodeType == XmlNodeType.Element && reader26.Name == "cbc:ChargeTotalAmount")
                    {
                        string value = reader26.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtChargeTotalAmount.Text = value;
                                int uzunluk1 = txtChargeTotalAmount.Text.Length;

                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuPayableAmount()
        {
            if (reader27.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader27.Read())
                {
                    if (reader27.NodeType == XmlNodeType.Element && reader27.Name == "cbc:PayableAmount")
                    {
                        string value = reader27.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtPayableAmount.Text = value;
                                int uzunluk1 = txtPayableAmount.Text.Length;

                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuInvoicedQuantity()
        {
            if (reader28.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader28.Read())
                {
                    if (reader28.NodeType == XmlNodeType.Element && reader28.Name == "cbc:InvoicedQuantity")
                    {
                        string value = reader28.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtInvoicedQuantity.Text = value;
                                int uzunluk1 = txtInvoicedQuantity.Text.Length;

                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuChargeIndicator()
        {
            if (reader29.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader29.Read())
                {
                    if (reader29.NodeType == XmlNodeType.Element && reader29.Name == "cbc:ChargeIndicator")
                    {
                        string value = reader29.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtChargeIndicator.Text = value;
                                int uzunluk1 = txtChargeIndicator.Text.Length;

                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuAmount()
        {
            if (reader30.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader30.Read())
                {
                    if (reader30.NodeType == XmlNodeType.Element && reader30.Name == "cbc:Amount")
                    {
                        string value = reader30.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtAmount.Text = value;
                                int uzunluk1 = txtAmount.Text.Length;

                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuBaseAmount()
        {
            if (reader31.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader31.Read())
                {
                    if (reader31.NodeType == XmlNodeType.Element && reader31.Name == "cbc:BaseAmount")
                    {
                        string value = reader31.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtBaseAmount.Text = value;
                                int uzunluk1 = txtBaseAmount.Text.Length;

                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuIdentificationCode()
        {
            if (reader32.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader32.Read())
                {
                    if (reader32.NodeType == XmlNodeType.Element && reader32.Name == "cbc:IdentificationCode")
                    {
                        string value = reader32.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtIdentificationCode.Text = value;
                                int uzunluk1 = txtIdentificationCode.Text.Length;

                               
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void OkuPriceAmount()
        {
            if (reader33.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader33.Read())
                {
                    if (reader33.NodeType == XmlNodeType.Element && reader33.Name == "cbc:PriceAmount")
                    {
                        string value = reader33.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtPriceAmount.Text = value;
                                int uzunluk1 = txtPriceAmount.Text.Length;

                                
                            }


                            i++;
                        }
                    }
                }

            }
        }
        private void Kontrol()
        {
            
            if (txtcbcUBLVersionID.Text == "")
            {
                txtcbcUBLVersionID.BackColor = Color.Red;
            }
            if (txtcbcCustomizationID.Text == "")
            {
                txtcbcCustomizationID.BackColor = Color.Red;
            }
            if (txtcbcProfileID.Text == "")
            {
                txtcbcProfileID.BackColor = Color.Red;
            }
            if (txtcbcID.Text == "")
            {
                txtcbcID.BackColor = Color.Red;
                label84.Text = "Alan Boş";
            }
            if (txtcbcCopyIndicator.Text == "")
            {
                txtcbcCopyIndicator.BackColor = Color.Red;
            }
            if (txtcbcUUID.Text == "")
            {
                txtcbcUUID.BackColor = Color.Red;
                label85.Text = "Alan Boş";
            }
            if (txtcbcIssueDate.Text == "")
            {
                txtcbcIssueDate.BackColor = Color.Red;
            }
            if (txtcbcInvoiceTypeCode.Text == "")
            {
                txtcbcInvoiceTypeCode.BackColor = Color.Red;
            }
            if (txtcbcDocumentCurrencyCode.Text == "")
            {
                txtcbcDocumentCurrencyCode.BackColor = Color.Red;
            }
            if (txtcbcLineCountNumeric.Text == "")
            {
                txtcbcLineCountNumeric.BackColor = Color.Red;
            }
            if (txtcbcID2.Text == "")
            {
                txtcbcID2.BackColor = Color.Red;
            }
            if (txtcbcIssueDate2.Text == "")
            {
                txtcbcIssueDate2.BackColor = Color.Red;
            }
            if (txtcbcDocumentTypeQrcode.Text == "")
            {
                txtcbcDocumentTypeQrcode.BackColor = Color.Red;
            }
            if (txtcbcID3.Text == "")
            {
                txtcbcID3.BackColor = Color.Red;
                label86.Text = "Alan Boş";
            }
            if (txtcbcIssueDate3.Text == "")
            {
                txtcbcIssueDate3.BackColor = Color.Red;
            }
            if (txtcbcDocumentTypeXSLT.Text == "")
            {
                txtcbcDocumentTypeXSLT.BackColor = Color.Red;
            }
            if (txtcbcID4.Text == "")
            {
                txtcbcID4.BackColor = Color.Red;
                label87.Text = "Alan Boş";
            }
            if (txtcbcID5.Text == "")
            {
                txtcbcID5.BackColor = Color.Red;
                label88.Text = "Alan Boş";
            }
            if (txtRoom1.Text == "")
            {
                txtRoom1.BackColor = Color.Red;
            }
            if (txtStreetName1.Text == "")
            {
                txtStreetName1.BackColor = Color.Red;
            }
            if (txtCitySubdivisionName1.Text == "")
            {
                txtCitySubdivisionName1.BackColor = Color.Red;
            }
            if (txtCityName1.Text == "")
            {
                txtCityName1.BackColor = Color.Red;
            }
            if (txtPostalZone1.Text == "")
            {
                txtPostalZone1.BackColor = Color.Red;
            }
            if (txtRegion1.Text == "")
            {
                txtRegion1.BackColor = Color.Red;
            }
            if (txtName1.Text == "")
            {
                txtName1.BackColor = Color.Red;
            }
            if (txtcbcIdMersısno.Text == "")
            {
                txtcbcIdMersısno.BackColor = Color.Red;
                label89.Text = "Alan Boş";
            }
            if (txtcbcID7.Text == "")
            {
                txtcbcID7.BackColor = Color.Red;
                label90.Text = "Alan Boş";
            }
            if (txtName2.Text == "")
            {
                txtName2.BackColor = Color.Red;
            }
            if (txtRoom2.Text == "")
            {
                txtRoom2.BackColor = Color.Red;
            }
            if (txtStreetName2.Text == "")
            {
                txtStreetName2.BackColor = Color.Red;
            }
            if (txtCitySubdivisionName2.Text == "")
            {
                txtCitySubdivisionName2.BackColor = Color.Red;
            }
            if (txtCityName2.Text == "")
            {
                txtCityName2.BackColor = Color.Red;
            }
            if (txtPostalZone2.Text == "")
            {
                txtPostalZone2.BackColor = Color.Red;
            }
            if (txtRegion2.Text == "")
            {
                txtRegion2.BackColor = Color.Red;
            }
            if (txtName3.Text == "")
            {
                txtName3.BackColor = Color.Red;
            }
            if(txtName4.Text == "")
            {
                txtName4.BackColor = Color.Red;
            }
            if (txtTelephone1.Text == "")
            {
                txtTelephone1.BackColor = Color.Red;
            }
            if (txtElectronicMail1.Text == "")
            {
                txtElectronicMail1.BackColor = Color.Red;
            }
            if (txtcbcID8.Text == "")
            {
                txtcbcID8.BackColor = Color.Red;
                label92.Text = "Alan Boş";
            }
            if (txtName5.Text == "")
            {
                txtName5.BackColor = Color.Red;
            }
            if (txtRoom3.Text == "")
            {
                txtRoom3.BackColor = Color.Red;
            }
            if (txtStreetName3.Text == "")
            {
                txtStreetName3.BackColor = Color.Red;
            }
            if (txtCityName3.Text == "")
            {
                txtCityName3.BackColor = Color.Red;
            }
            if (txtPostalZone3.Text == "")
            {
                txtPostalZone3.BackColor = Color.Red;
            }
            if (txtRegion3.Text == "")
            {
                txtRegion3.BackColor = Color.Red;
            }
            if (txtName6.Text == "")
            {
                txtName6.BackColor = Color.Red;
            }
            if (txtCitySubdivisionName3.Text == "")
            {
                txtCitySubdivisionName3.BackColor = Color.Red;
            }
            if (txtName7.Text == "")
            {
                txtName7.BackColor = Color.Red;
            }
            if (txtTelephone2.Text == "")
            {
                txtTelephone2.BackColor = Color.Red;
            }
            if (txtElectronicMail2.Text == "")
            {
                txtElectronicMail2.BackColor = Color.Red;
            }
            if (txtSourceCurrencyCode.Text == "")
            {
                txtSourceCurrencyCode.BackColor = Color.Red;
            }
            if (txtTargetCurrencyCode.Text == "")
            {
                txtTargetCurrencyCode.BackColor = Color.Red;
            }
            if (txtCalculationRate.Text == "")
            {
                txtCalculationRate.BackColor = Color.Red;
            }
            if (txtTaxAmount1.Text == "")
            {
                txtTaxAmount1.BackColor = Color.Red;
            }
            if (txtTaxableAmount1.Text == "")
            {
                txtTaxableAmount1.BackColor = Color.Red;
            }
            if (txtTaxAmount2.Text == "")
            {
                txtTaxAmount2.BackColor = Color.Red;
            }
            if (txtCalculationSequenceNumeric1.Text == "")
            {
                txtCalculationSequenceNumeric1.BackColor = Color.Red;
            }
            if (txtPercent1.Text == "")
            {
                txtPercent1.BackColor = Color.Red;
            }
            if (txtName8.Text == "")
            {
                txtName8.BackColor = Color.Red;
            }
            if (txtTaxTypeCode1.Text == "")
            {
                txtTaxTypeCode1.BackColor = Color.Red;
            }
            if (txtLineExtensionAmount1.Text == "")
            {
                txtLineExtensionAmount1.BackColor = Color.Red;
            }
            if (txtTaxExclusiveAmount.Text == "")
            {
                txtTaxExclusiveAmount.BackColor = Color.Red;
            }
            if (txtTaxInclusiveAmount.Text == "")
            {
                txtTaxInclusiveAmount.BackColor = Color.Red;
            }
            if (txtAllowanceTotalAmount.Text == "")
            {
                txtAllowanceTotalAmount.BackColor = Color.Red;
            }
            if (txtChargeTotalAmount.Text == "")
            {
                txtChargeTotalAmount.BackColor = Color.Red;
            }
            if (txtPayableAmount.Text == "")
            {
                txtPayableAmount.BackColor = Color.Red;
            }
            if (txtcbcID9.Text == "")
            {
                txtcbcID9.BackColor = Color.Red;
            }
            if (txtInvoicedQuantity.Text == "")
            {
                txtInvoicedQuantity.BackColor = Color.Red;
            }
            if (txtLineExtensionAmount2.Text == "")
            {
                txtLineExtensionAmount2.BackColor = Color.Red;
            }
            if (txtChargeIndicator.Text == "")
            {
                txtChargeIndicator.BackColor = Color.Red;
            }
            if (txtAmount.Text == "")
            {
                txtAmount.BackColor = Color.Red;
            }
            if (txtBaseAmount.Text == "")
            {
                txtBaseAmount.BackColor = Color.Red;
            }
            if (txtTaxAmount3.Text == "")
            {
                txtTaxAmount3.BackColor = Color.Red;
            }
            if (txtTaxableAmount2.Text == "")
            {
                txtTaxableAmount2.BackColor = Color.Red;
            }
            if (txtTaxAmount4.Text == "")
            {
                txtTaxAmount4.BackColor = Color.Red;
            }
            if (txtCalculationSequenceNumeric2.Text == "")
            {
                txtCalculationSequenceNumeric2.BackColor = Color.Red;
            }
            if (txtPercent2.Text == "")
            {
                txtPercent2.BackColor = Color.Red;
            }
            if (txtName9.Text == "")
            {
                txtName9.BackColor = Color.Red;
            }
            if (txtTaxTypeCode2.Text == "")
            {
                txtTaxTypeCode2.BackColor = Color.Red;
            }
            if (txtName10.Text == "")
            {
                txtName10.BackColor = Color.Red;
            }
            if (txtIdentificationCode.Text == "")
            {
                txtIdentificationCode.BackColor = Color.Red;
            }
            if (txtName11.Text == "")
            {
                txtName11.BackColor = Color.Red;
            }
            if (txtPriceAmount.Text == "")
            {
                txtPriceAmount.BackColor = Color.Red;
            }





            
        }




    }
}
