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

    public partial class Form2 : Form
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
        private XmlReader reader39;
        private XmlReader reader40;
        private XmlReader reader41;
        private XmlReader reader42;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label66.Text = AnaSayfa.dosyaYoluDegiskeni;
            reader = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader2 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader3 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader4 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader5 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader6 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader7 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader8 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader9 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader10 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader11 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader12 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader13 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader14 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader15 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader16 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader17 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader18 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader19 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader20 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader21 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader22 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader23 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader24 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader25 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader26 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader27 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader28 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader29 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader30 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader31 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader32 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader33 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader34 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader35 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader36 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader37 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader38 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader39 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader40 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader41 = XmlReader.Create(label66.Text, new XmlReaderSettings());
            reader42 = XmlReader.Create(label66.Text, new XmlReaderSettings());


            Oku();
            reader.Close();
            Kontrol();
            label66.Hide();

        }
        private void Oku()
        {
            while (reader.Read())
            {
                OkuUblVersionID();
                OkuCustomizationID();
                OkuProfileID();
                OkuUUID();
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

                OkuValueAmount();
            }
            while (reader15.Read())
            {
                OkuLicensePlateID();

            }
            while (reader16.Read())
            {
                OkuActualDespatchDate();

            }
            while (reader17.Read())
            {
                OkuActualDespatchTime();

            }
            while (reader18.Read())
            {
                OkuDeliveredQuantity();

            }
            while (reader19.Read())
            {
                OkuOutstandingQuantity();

            }
            while (reader20.Read())
            {
                OkuOutstandingReason();


            }
            while (reader21.Read())
            {
                OkuLineID();
            }
            while (reader22.Read())
            {
                OkuLineExtensionAmount();
            }
            while (reader23.Read())
            {
                OkuInvoicedQuantity();
            }
            while (reader24.Read())
            {

            }
            while (reader25.Read())
            {

            }
            while (reader26.Read())
            {

            }
            while (reader27.Read())
            {

            }
            while (reader28.Read())
            {

            }
            while (reader29.Read())
            {

            }
            while (reader30.Read())
            {

            }
            while (reader31.Read())
            {

            }
            while (reader32.Read())
            {

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
                OkuBuildingName();
            }
            while (reader37.Read())
            {
                OkuBuildingNumber();
            }
            while (reader38.Read())
            {
                OkuLineCountNumeric();
            }
            while (reader39.Read())
            {
                OkuDespatchAdviceTypeCode();
            }
            while (reader40.Read())
            {
                OkuNote();

            }
            while (reader41.Read())
            {
                OkuWebsiteURI();
            }
            while (reader42.Read())
            {
                OkuTelefax();
            }





        }
        private void OkuUblVersionID()
        {
           
            if (reader.NodeType == XmlNodeType.Element)
            {
                string name = reader.Name;
                if (name == "cbc:UBLVersionID")
                {
                    txtcbcUBLVersionID.Text = reader.ReadElementString();
                   
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
                    label136.Text = "cbc:UUID Uzunluk:" + uzunluk2.ToString();
                    
                   
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





        private void OkuLineCountNumeric()
        {
           
            if (reader38.NodeType == XmlNodeType.Element)
            {
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

                        if (i < 27)
                        {
                            if (i == 0)
                            {
                                txtcbcID.Text = value;
                                int uzunluk1 = txtcbcID.Text.Length;
                                label124.Text = "cbc:ID Uzunluk:" + uzunluk1.ToString();
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
                                label137.Text = "cbc:ID-3 Uzunluk:" + uzunluk3.ToString();
                                
                            }
                           
                            else if (i == 3)
                            {
                                txtcbcID4.Text = value;
                                int uzunluk4 = txtcbcID4.Text.Length;
                                label138.Text = "cbc:ID-4 Uzunluk:" + uzunluk4.ToString();

                            }
                           
                            else if (i == 4)
                            {
                                txtcbcID5.Text = value;
                                int uzunluk5 = txtcbcID5.Text.Length;
                                label139.Text = "cbc:ID-5 Uzunluk:" + uzunluk5.ToString();
                                
                            }
                          
                            else if (i == 5)
                            {
                                txtcbcIdMersısno.Text = value;
                                int uzunluk6 = txtcbcIdMersısno.Text.Length;
                                label140.Text = "cbc:ID schemeID="+"MERSISNO"+" Uzunluk:" + uzunluk6.ToString();
                                if (uzunluk6 == 16)
                                {
                                    txtcbcIdMersısno.BackColor = Color.Green;
                                }
                            }
                           
                            else if (i == 6)
                            {
                                txtcbcID7.Text = value;
                                int uzunluk7 = txtcbcID7.Text.Length;
                                label141.Text = "cbc:ID schemeID="+"VKN"+"-1 Uzunluk:" + uzunluk7.ToString();
                                
                            }
                           
                            else if (i == 7)
                            {
                                txtcbcID8.Text = value;
                                int uzunluk8 = txtcbcID8.Text.Length;
                                label142.Text = "cbc:ID schemeID="+"VKN"+"-2 Uzunluk:" + uzunluk8.ToString();
                               
                            }
                           
                            else if (i == 8)
                            {
                                txtcbcID9.Text = value;
                                int uzunluk9 = txtcbcID9.Text.Length;
                                label143.Text = "cbc:ID schemeID="+"MUSTERINO"+" Uzunluk:" + uzunluk9.ToString();
                                
                            }
                          
                            else if (i == 9)
                            {
                                txtcbcID10.Text = value;
                                int uzunluk10 = txtcbcID10.Text.Length;
                                label144.Text = "cbc:ID schemeID="+"DISTRIBUTORNO"+" Uzunluk:" + uzunluk10.ToString();
                                
                            }
                           
                            else if (i == 10)
                            {
                                txtcbcID11.Text = value;
                                int uzunluk11 = txtcbcID11.Text.Length;
                                label145.Text = "cbc:ID schemeID="+"BAYINO"+" Uzunluk:" + uzunluk11.ToString();
                                
                            }
                          
                            else if (i == 11)
                            {
                                txtcbcID12.Text = value;
                                int uzunluk12 = txtcbcID12.Text.Length;
                                label155.Text = "cbc:ID schemeID="+ "ABONENO Uzunluk:" + uzunluk12.ToString();
                                
                            }
                           
                            else if (i == 12)
                            {
                                txtcbcID13.Text = value;
                                int uzunluk13 = txtcbcID13.Text.Length;
                                label146.Text = "cbc:ID schemeID="+ "DOSYANO Uzunluk:" + uzunluk13.ToString();
                                
                            }
                           
                            else if (i == 13)
                            {
                                txtcbcID14.Text = value;
                                int uzunluk16 = txtcbcID14.Text.Length;
                                label149.Text = "cbc:ID-14 Uzunluk:" + uzunluk16.ToString();
                                
                            }
                            
                            else if (i == 14)
                            {
                                txtcbcID15.Text = value;
                                int uzunluk19 = txtcbcID15.Text.Length;
                                label152.Text = "cbc:ID-15 Uzunluk:" + uzunluk19.ToString();
                                
                            }
                           
                            else if (i == 15)
                            {
                                txtcbcID16.Text = value;
                                int uzunluk1 = txtcbcID16.Text.Length;

                                
                            }
                           
                            else if (i == 16)
                            {
                                txtcbcID17.Text = value;

                                if (txtcbcID17.Text.Length>0)
                                {
                                    txtcbcID17.BackColor = Color.Green;
                                }

                                
                            }
                           
                            else if (i == 17)
                            {
                                txtcbcID18.Text = value;
                                int uzunluk1 = txtcbcID18.Text.Length;

                               
                            }
                           
                            else if (i == 18)
                            {
                                txtcbcID19.Text = value;
                                int uzunluk1 = txtcbcID19.Text.Length;

                                
                            }
                           
                            else if (i == 19)
                            {
                                txtcbcID20.Text = value;
                                int uzunluk1 = txtcbcID20.Text.Length;

                                
                            }
                           
                            else if (i == 20)
                            {
                                txtcbcID21.Text = value;
                                int uzunluk1 = txtcbcID21.Text.Length;

                               
                            }
                            
                            else if (i == 21)
                            {
                                txtcbcID22.Text = value;
                                int uzunluk1 = txtcbcID22.Text.Length;

                                
                            }
                           
                            else if (i == 22)
                            {
                                txtcbcID23.Text = value;
                                int uzunluk1 = txtcbcID23.Text.Length;

                                
                            }
                           
                            else if (i == 23)
                            {
                                txtcbcID24.Text = value;
                                int uzunluk1 = txtcbcID24.Text.Length;

                               
                            }
                           
                            else if (i == 24)
                            {
                                txtcbcID25.Text = value;
                                int uzunluk1 = txtcbcID25.Text.Length;

                                
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

                        if (i < 6)
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
                          
                            else if (i == 3)
                            {
                                txtRoom4.Text = value;
                                int uzunluk1 = txtRoom4.Text.Length;

                                
                            }
                           
                            else if (i == 4)
                            {
                                txtRoom5.Text = value;
                                int uzunluk1 = txtRoom5.Text.Length;

                                
                            }
                          
                            else if (i == 5)
                            {
                                txtRoom6.Text = value;
                                int uzunluk1 = txtRoom6.Text.Length;

                                
                            }
                           

                        }

                        i++;
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

                        if (i < 6)
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
                            
                            else if (i == 3)
                            {
                                txtStreetName4.Text = value;
                                int uzunluk1 = txtStreetName4.Text.Length;

                                
                            }
                          
                            else if (i == 4)
                            {
                                txtStreetName5.Text = value;
                                int uzunluk1 = txtStreetName5.Text.Length;

                               
                            }
                           
                            else if (i == 5)
                            {
                                txtStreetName6.Text = value;
                                int uzunluk1 = txtStreetName6.Text.Length;

                                
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

                        if (i < 6)
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
                            
                            else if (i == 3)
                            {
                                txtCitySubdivisionName4.Text = value;
                                int uzunluk1 = txtCitySubdivisionName4.Text.Length;

                                
                            }
                           
                            else if (i == 4)
                            {
                                txtCitySubdivisionName5.Text = value;
                                int uzunluk1 = txtCitySubdivisionName5.Text.Length;

                                
                            }
                           
                            else if (i == 5)
                            {
                                txtCitySubdivisionName6.Text = value;
                                int uzunluk1 = txtCitySubdivisionName6.Text.Length;

                                
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

                        if (i < 8)
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
                            
                            else if (i == 3)
                            {
                                txtCityName4.Text = value;
                                int uzunluk1 = txtCityName4.Text.Length;

                                
                            }
                            
                            else if (i == 4)
                            {
                                txtCityName5.Text = value;
                                int uzunluk1 = txtCityName5.Text.Length;

                                
                            }
                           
                            else if (i == 5)
                            {
                                txtCityName6.Text = value;
                                int uzunluk1 = txtCityName6.Text.Length;

                                
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

                        if (i < 6)
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
                             
                                if (txtPostalZone3.Text.Length > 0)
                                {
                                    txtPostalZone3.BackColor = Color.Green;
                                }

                            }
                           
                            else if (i == 3)
                            {
                                txtPostalZone4.Text = value;
                              
                                if (txtPostalZone4.Text.Length > 0)
                                {
                                    txtPostalZone4.BackColor = Color.Green;
                                }

                            }
                            
                            else if (i == 4)
                            {
                                txtPostalZone5.Text = value;
                                

                                if (txtPostalZone5.Text.Length > 0)
                                {
                                    txtPostalZone5.BackColor = Color.Green;
                                }
                            }
                           
                            else if (i == 5)
                            {
                                txtPostalZone6.Text = value;
                               

                                if (txtPostalZone6.Text.Length > 0)
                                {
                                    txtPostalZone6.BackColor = Color.Green;
                                }
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

                        if (i < 4)
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
                            
                            else if (i == 3)
                            {
                                txtRegion4.Text = value;
                                int uzunluk1 = txtRegion4.Text.Length;

                               
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

                        if (i < 17)
                        {
                            if (i == 0)
                            {
                                txtName1.Text = value;
                                int uzunluk1 = txtName1.Text.Length;

                               

                            }
                            
                            else if (i == 1)
                            {
                                txtName2.Text = value;
                                int uzunluk1 = txtName1.Text.Length;

                                
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
                           
                            else if (i == 11)
                            {
                                txtName12.Text = value;
                                int uzunluk1 = txtName12.Text.Length;

                               
                            }
                           
                            else if (i == 12)
                            {
                                txtName13.Text = value;
                                int uzunluk1 = txtName13.Text.Length;

                                
                            }
                            
                            else if (i == 13)
                            {
                                txtName14.Text = value;
                                int uzunluk1 = txtName14.Text.Length;

                               

                            }
                           
                            else if (i == 14)
                            {
                                txtName15.Text = value;
                                int uzunluk1 = txtName15.Text.Length;

                                
                            }
                            
                            else if (i == 15)
                            {
                                txtName16.Text = value;
                                int uzunluk1 = txtName16.Text.Length;

                                
                            }
                           
                            else if (i == 16)
                            {
                                txtName17.Text = value;
                                int uzunluk1 = txtName17.Text.Length;

                                
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

                        if (i < 3)
                        {
                            if (i == 0)
                            {
                                txtTelephone1.Text = value;
                                int uzunluk14 = txtTelephone1.Text.Length;
                               
                                

                               
                            }
                            
                            else if (i == 1)
                            {
                                txtTelephone2.Text = value;
                                int uzunluk17 = txtTelephone2.Text.Length;
                               
                                
                            }
                            
                            else if (i == 2)
                            {
                                txtTelephone3.Text = value;
                                int uzunluk20 = txtTelephone3.Text.Length;
                               
                               
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

                        if (i < 3)
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
                           
                            else if (i == 2)
                            {
                                txtElectronicMail3.Text = value;
                                int uzunluk1 = txtElectronicMail3.Text.Length;

                                
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

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtPriceAmount1.Text = value;
                                int uzunluk1 = txtPriceAmount1.Text.Length;

                                
                            }
                           

                            if (i == 1)
                            {
                                txtPriceAmount2.Text = value;
                                int uzunluk1 = txtPriceAmount2.Text.Length;

                                
                            }
                           


                            i++;
                        }
                    }
                   
                }

            }
        }
        private void OkuDespatchAdviceTypeCode()
        {
            if (reader39.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader39.Read())
                {
                    if (reader39.NodeType == XmlNodeType.Element && reader39.Name == "cbc:DespatchAdviceTypeCode")
                    {
                        string value = reader39.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtDespatchAdviceTypeCode.Text = value;
                                int uzunluk1 = txtDespatchAdviceTypeCode.Text.Length;

                              
                            }
                           


                            i++;
                        }
                    }
                   
                }

            }
        }
        private void OkuNote()
        {
            if (reader40.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader40.Read())
                {
                    if (reader40.NodeType == XmlNodeType.Element && reader40.Name == "cbc:Note")
                    {
                        string value = reader40.ReadElementContentAsString();

                        if (i < 5)
                        {
                            if (i == 0)
                            {
                                txtNote1.Text = value;
                                int uzunluk1 = txtNote1.Text.Length;

                               

                            }
                           
                            if (i == 1)
                            {
                                txtNote2.Text = value;
                                int uzunluk1 = txtNote2.Text.Length;

                               
                            }
                           
                            if (i == 2)
                            {
                                txtNote3.Text = value;
                                int uzunluk1 = txtNote3.Text.Length;

                                
                            }
                           
                            if (i == 3)
                            {
                                txtNote4.Text = value;
                                int uzunluk1 = txtNote4.Text.Length;

                               
                            }
                          


                            i++;
                        }
                    }
                   
                }

            }
        }
        private void OkuWebsiteURI()
        {
            if (reader41.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader41.Read())
                {
                    if (reader41.NodeType == XmlNodeType.Element && reader41.Name == "cbc:WebsiteURI")
                    {
                        string value = reader41.ReadElementContentAsString();

                        if (i < 4)
                        {
                            if (i == 0)
                            {
                                txtWebsiteURI1.Text = value;
                                int uzunluk1 = txtWebsiteURI1.Text.Length;

                               

                            }
                           
                            if (i == 1)
                            {
                                txtWebsiteURI2.Text = value;
                                int uzunluk1 = txtWebsiteURI2.Text.Length;

                               
                            }
                           

                            if (i == 2)
                            {
                                txtWebsiteURI3.Text = value;
                                int uzunluk1 = txtWebsiteURI3.Text.Length;

                               
                            }
                           

                        }


                        i++;
                    }
                   
                }
            }

        }
        private void OkuBuildingName()
        {
            if (reader36.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader36.Read())
                {
                    if (reader36.NodeType == XmlNodeType.Element && reader36.Name == "cbc:BuildingName")
                    {
                        string value = reader36.ReadElementContentAsString();

                        if (i < 7)
                        {
                            if (i == 0)
                            {
                                txtBuildingName1.Text = value;
                                int uzunluk1 = txtBuildingName1.Text.Length;

                               

                            }
                           
                            if (i == 1)
                            {
                                txtBuildingName2.Text = value;
                                int uzunluk1 = txtBuildingName2.Text.Length;

                               
                            }
                            
                            if (i == 2)
                            {
                                txtBuildingName3.Text = value;
                                int uzunluk1 = txtBuildingName3.Text.Length;

                               
                            }
                           
                            if (i == 3)
                            {
                                txtBuildingName4.Text = value;
                                int uzunluk1 = txtBuildingName4.Text.Length;

                                
                            }
                           
                            if (i == 4)
                            {
                                txtBuildingName5.Text = value;
                                int uzunluk1 = txtBuildingName5.Text.Length;

                               
                            }
                           
                            if (i == 5)
                            {
                                txtBuildingName6.Text = value;
                                int uzunluk1 = txtBuildingName6.Text.Length;

                               
                            }
                           


                        }


                        i++;
                    }
                   
                }
            }

        }
        private void OkuBuildingNumber()
        {
            if (reader37.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader37.Read())
                {
                    if (reader37.NodeType == XmlNodeType.Element && reader37.Name == "cbc:BuildingNumber")
                    {
                        string value = reader37.ReadElementContentAsString();

                        if (i < 7)
                        {
                            if (i == 0)
                            {
                                txtBuildingNumber1.Text = value;
                                int uzunluk1 = txtBuildingNumber1.Text.Length;

                               

                            }
                           
                            if (i == 1)
                            {
                                txtBuildingNumber2.Text = value;
                                int uzunluk1 = txtBuildingNumber2.Text.Length;

                               
                            }
                           
                            if (i == 2)
                            {
                                txtBuildingNumber3.Text = value;
                                int uzunluk1 = txtBuildingNumber3.Text.Length;

                                
                            }
                            
                            if (i == 3)
                            {
                                txtBuildingNumber4.Text = value;
                                int uzunluk1 = txtBuildingNumber4.Text.Length;

                                
                            }
                            
                            if (i == 4)
                            {
                                txtBuildingNumber5.Text = value;
                                int uzunluk1 = txtBuildingNumber5.Text.Length;

                               
                            }
                            
                            if (i == 5)
                            {
                                txtBuildingNumber6.Text = value;
                                int uzunluk1 = txtBuildingNumber6.Text.Length;

                               
                            }
                            


                        }


                        i++;
                    }
                  
                }
            }

        }
        private void OkuTelefax()
        {
            if (reader42.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader42.Read())
                {
                    if (reader42.NodeType == XmlNodeType.Element && reader42.Name == "cbc:Telefax")
                    {
                        string value = reader42.ReadElementContentAsString();

                        if (i < 4)
                        {
                            if (i == 0)
                            {
                                txtTelefax1.Text = value;
                              
                                


                            }
                           
                            if (i == 1)
                            {
                                txtTelefax2.Text = value;
                             

                            }
                           
                            if (i == 2)
                            {
                                txtTelefax3.Text = value;
                             

                            }
                           


                        }


                        i++;
                    }
                }
            }

        }
        private void OkuValueAmount()
        {
            if (reader14.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader14.Read())
                {
                    if (reader14.NodeType == XmlNodeType.Element && reader14.Name == "cbc:ValueAmount")
                    {
                        string value = reader14.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtValueAmount.Text = value;

                                int uzunluk1 = txtValueAmount.Text.Length;

                                
                            }
                            



                        }


                        i++;
                    }
                    
                }
            }

        }
        private void OkuLicensePlateID()
        {
            if (reader15.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader15.Read())
                {
                    if (reader15.NodeType == XmlNodeType.Element && reader15.Name == "cbc:LicensePlateID")
                    {
                        string value = reader15.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtLicensePlateID.Text = value;
                                int uzunluk1 = txtLicensePlateID.Text.Length;

                               

                            }
                          



                        }


                        i++;
                    }
                   
                }
            }

        }
        private void OkuActualDespatchDate()
        {
            if (reader16.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader16.Read())
                {
                    if (reader16.NodeType == XmlNodeType.Element && reader16.Name == "cbc:ActualDespatchDate")
                    {
                        string value = reader16.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtActualDespatchDate.Text = value;

                                int uzunluk1 = txtActualDespatchDate.Text.Length;

                                
                            }
                           



                        }


                        i++;
                    }
                    
                }
            }

        }
        private void OkuActualDespatchTime()
        {
            if (reader17.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader17.Read())
                {
                    if (reader17.NodeType == XmlNodeType.Element && reader17.Name == "cbc:ActualDespatchTime")
                    {
                        string value = reader17.ReadElementContentAsString();

                        if (i < 1)
                        {
                            if (i == 0)
                            {
                                txtActualDespatchTime.Text = value;

                                int uzunluk1 = txtActualDespatchTime.Text.Length;

                                
                            }
                           




                        }


                        i++;
                    }
                   
                }
            }

        }
        private void OkuDeliveredQuantity()
        {
            if (reader18.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader18.Read())
                {
                    if (reader18.NodeType == XmlNodeType.Element && reader18.Name == "cbc:DeliveredQuantity")
                    {
                        string value = reader18.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtDeliveredQuantity1.Text = value;
                                int uzunluk1 = txtDeliveredQuantity1.Text.Length;

                               

                            }
                           
                            if (i == 1)
                            { 
                                txtDeliveredQuantity2.Text = value;
                                int uzunluk1 = txtDeliveredQuantity2.Text.Length;

                               

                            }
                            



                        }


                        i++;
                    }
                   
                }
            }

        }
        private void OkuOutstandingQuantity()
        {
            if (reader19.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader19.Read())
                {
                    if (reader19.NodeType == XmlNodeType.Element && reader19.Name == "cbc:OutstandingQuantity")
                    {
                        string value = reader19.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtOutstandingQuantity1.Text = value;
                                int uzunluk1 = txtOutstandingQuantity1.Text.Length;

                               

                            }
                          
                            if (i == 1)
                            {
                                txtOutstandingQuantity2.Text = value;
                                int uzunluk1 = txtOutstandingQuantity2.Text.Length;

                               

                            }
                          



                        }
                    


                        i++;
                    }
                   
                }
            }

        }
        private void OkuOutstandingReason()
        {
            if (reader20.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader20.Read())
                {
                    if (reader20.NodeType == XmlNodeType.Element && reader20.Name == "cbc:OutstandingReason")
                    {
                        string value = reader20.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtOutstandingReason1.Text = value;
                                int uzunluk1 = txtOutstandingReason1.Text.Length;

                               

                            }
                           
                            if (i == 1)
                            {
                                txtOutstandingReason2.Text = value;
                                int uzunluk1 = txtOutstandingReason2.Text.Length;

                               

                            }
                           



                        }


                        i++;
                    }
                   
                    
                }
            }

        }
        private void OkuLineID()
        {
            if (reader21.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader21.Read())
                {
                    if (reader21.NodeType == XmlNodeType.Element && reader21.Name == "cbc:LineID")
                    {
                        string value = reader21.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtLineID1.Text = value;
                                int uzunluk1 = txtLineID1.Text.Length;

                                

                            }
                           
                            if (i == 1)
                            {
                                txtLineID2.Text = value;

                                int uzunluk1 = txtLineID2.Text.Length;

                            }
                          



                        }


                        i++;
                    }
                   
                }
            }

        }
        private void OkuInvoicedQuantity()
        {
            if (reader23.NodeType == XmlNodeType.Element)
            {
                int i = 0;

                while (reader23.Read())
                {
                    if (reader23.NodeType == XmlNodeType.Element && reader23.Name == "cbc:InvoicedQuantity")
                    {
                        string value = reader23.ReadElementContentAsString();

                        if (i < 2)
                        {
                            if (i == 0)
                            {
                                txtInvoicedQuantity1.Text = value;
                                int uzunluk1 = txtInvoicedQuantity1.Text.Length;

                              

                            }
                           
                            if (i == 1)
                            {
                                txtInvoicedQuantity2.Text = value;
                                int uzunluk1 = txtInvoicedQuantity2.Text.Length;

                              

                            }
                          



                        }


                        i++;
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
            }
            if (txtcbcCopyIndicator.Text == "")
            {
                txtcbcCopyIndicator.BackColor = Color.Red;
            }
            if (txtcbcUUID.Text == "")
            {
                txtcbcUUID.BackColor = Color.Red;
            }
            if (txtcbcIssueDate.Text == "")
            {
                txtcbcIssueDate.BackColor = Color.Red;
            }
            if (txtDespatchAdviceTypeCode.Text == "")
            {
                txtDespatchAdviceTypeCode.BackColor = Color.Red;
            }
            if (txtNote1.Text == "")
            {
                txtNote1.BackColor = Color.Red;
            }
            if (txtNote2.Text == "")
            {
                txtNote2.BackColor = Color.Red;
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
            }
            if (txtcbcID5.Text == "")
            {
                txtcbcID5.BackColor = Color.Red;
            }
            if (txtRoom1.Text == "")
            {
                txtRoom1.BackColor = Color.Red;
            }
            if (txtStreetName1.Text == "")
            {
                txtStreetName1.BackColor = Color.Red;
            }
            if (txtBuildingName1.Text == "")
            {
                txtBuildingName1.BackColor = Color.Red;
            }
            
            if (txtBuildingNumber1.Text == "")
            {
                txtBuildingNumber1.BackColor = Color.Red;
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
            if (txtWebsiteURI1.Text == "")
            {
                txtWebsiteURI1.BackColor = Color.Red;
            }
            if (txtcbcIdMersısno.Text == "")
            {
                txtcbcIdMersısno.BackColor = Color.Red;
            }
            if (txtcbcID7.Text == "")
            {
                txtcbcID7.BackColor = Color.Red;
            }
            if (txtcbcID8.Text == "")
            {
                txtcbcID8.BackColor = Color.Red;
            }
            if (txtcbcID9.Text == "")
            {
                txtcbcID9.BackColor = Color.Red;
            }
            if (txtcbcID10.Text == "")
            {
                txtcbcID10.BackColor = Color.Red;
            }
            if (txtcbcID11.Text == "")
            {
                txtcbcID11.BackColor = Color.Red;
            }
            if (txtcbcID12.Text == "")
            {
                txtcbcID12.BackColor = Color.Red;
            }
            if (txtcbcID13.Text == "")
            {
                txtcbcID13.BackColor = Color.Red;
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
            if (txtBuildingName2.Text == "")
            {
                txtBuildingName2.BackColor = Color.Red;
            }
            if (txtBuildingNumber2.Text == "")
            {
                txtBuildingNumber2.BackColor = Color.Red;
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
            if (txtName4.Text == "")
            {
                txtName4.BackColor = Color.Red;
            }
            if (txtTelephone1.Text == "")
            {
                txtTelephone1.BackColor = Color.Red;
            }
            if (txtTelefax1.Text == "")
            {
                txtTelefax1.BackColor = Color.Red;
            }
            if (txtElectronicMail1.Text == "")
            {
                txtElectronicMail1.BackColor = Color.Red;
            }
            if (txtWebsiteURI2.Text == "")
            {
                txtWebsiteURI2.BackColor = Color.Red;
            }
            if (txtcbcID14.Text == "")
            {
                txtcbcID14.BackColor = Color.Red;
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
            if (txtBuildingName3.Text == "")
            {
                txtBuildingName3.BackColor = Color.Red;
            }
            if (txtBuildingNumber3.Text == "")
            {
                txtBuildingNumber3.BackColor = Color.Red;
            }
            if (txtCitySubdivisionName3.Text == "")
            {
                txtCitySubdivisionName3.BackColor = Color.Red;
            }
            if (txtCityName3.Text == "")
            {
                txtCityName3.BackColor = Color.Red;
            }
            if (txtPostalZone3.Text == "")
            {
                txtPostalZone3.BackColor = Color.Red;
            }
            if (txtName6.Text == "")
            {
                txtName6.BackColor = Color.Red;
            }
            if (txtName7.Text == "")
            {
                txtName7.BackColor = Color.Red;
            }
            if (txtTelephone2.Text == "")
            {
                txtTelephone2.BackColor = Color.Red;
            }
            if (txtTelefax2.Text == "")
            {
                txtTelefax2.BackColor = Color.Red;
            }
            if (txtElectronicMail2.Text == "")
            {
                txtElectronicMail2.BackColor = Color.Red;
            }
            if (txtWebsiteURI3.Text == "")
            {
                txtWebsiteURI3.BackColor = Color.Red;
            }
            if (txtcbcID15.Text == "")
            {
                txtcbcID15.BackColor = Color.Red;
            }
            if (txtName8.Text == "")
            {
                txtName8.BackColor = Color.Red;
            }
            if (txtRoom4.Text == "")
            {
                txtRoom4.BackColor = Color.Red;
            }
            if (txtStreetName4.Text == "")
            {
                txtStreetName4.BackColor = Color.Red;
            }
            if (txtBuildingName4.Text == "")
            {
                txtBuildingName4.BackColor = Color.Red;
            }
            if (txtBuildingNumber4.Text == "")
            {
                txtBuildingNumber4.BackColor = Color.Red;
            }
            if (txtCitySubdivisionName4.Text == "")
            {
                txtCitySubdivisionName4.BackColor = Color.Red;
            }
            if (txtCityName4.Text == "")
            {
                txtCityName4.BackColor = Color.Red;
            }
            if (txtPostalZone4.Text == "")
            {
                txtPostalZone4.BackColor = Color.Red;
            }
            if (txtName9.Text == "")
            {
                txtName9.BackColor = Color.Red;
            }
            if (txtName10.Text == "")
            {
                txtName10.BackColor = Color.Red;
            }
            if (txtTelephone3.Text == "")
            {
                txtTelephone3.BackColor = Color.Red;
            }
            if (txtTelefax3.Text == "")
            {
                txtTelefax3.BackColor = Color.Red;
            }
            if (txtElectronicMail3.Text == "")
            {
                txtElectronicMail3.BackColor = Color.Red;
            }
            if (txtcbcID16.Text == "")
            {
                txtcbcID16.BackColor = Color.Red;
            }
            if (txtValueAmount.Text == "")
            {
                txtValueAmount.BackColor = Color.Red;
            }
            if (txtLicensePlateID.Text == "")
            {
                txtLicensePlateID.BackColor = Color.Red;
            }
            if (txtRoom5.Text == "")
            {
                txtRoom5.BackColor = Color.Red;
            }
            if (txtStreetName5.Text == "")
            {
                txtStreetName5.BackColor = Color.Red;
            }
            if (txtBuildingName5.Text == "")
            {
                txtBuildingName5.BackColor = Color.Red;
            }
            if (txtBuildingNumber5.Text == "")
            {
                txtBuildingNumber5.BackColor = Color.Red;
            }
            if (txtCitySubdivisionName5.Text == "")
            {
                txtCitySubdivisionName5.BackColor = Color.Red;
            }
            if (txtCityName5.Text == "")
            {
                txtCityName5.BackColor = Color.Red;
            }
            if (txtPostalZone5.Text == "")
            {
                txtPostalZone5.BackColor = Color.Red;
            }
            if (txtRegion3.Text == "")
            {
                txtRegion3.BackColor = Color.Red;
            }
            if (txtName11.Text == "")
            {
                txtName11.BackColor = Color.Red;
            }
            if (txtcbcID17.Text == "")
            {
                txtcbcID17.BackColor = Color.Red;
            }
            if (txtName12.Text == "")
            {
                txtName12.BackColor = Color.Red;
            }
            if (txtRoom6.Text == "")
            {
                txtRoom6.BackColor = Color.Red;
            }
            if (txtStreetName6.Text == "")
            {
                txtStreetName6.BackColor = Color.Red;
            }
            if (txtBuildingName6.Text == "")
            {
                txtBuildingName6.BackColor = Color.Red;
            }
            if (txtBuildingNumber6.Text == "")
            {
                txtBuildingNumber6.BackColor = Color.Red;
            }
            if (txtCitySubdivisionName6.Text == "")
            {
                txtCitySubdivisionName6.BackColor = Color.Red;
            }
            if (txtCityName6.Text == "")
            {
                txtCityName6.BackColor = Color.Red;
            }
            if (txtPostalZone6.Text == "")
            {
                txtPostalZone6.BackColor = Color.Red;
            }
            if (txtRegion4.Text == "")
            {
                txtRegion4.BackColor = Color.Red;
            }
            if (txtName13.Text == "")
            {
                txtName13.BackColor = Color.Red;
            }
            if (txtActualDespatchDate.Text == "")
            {
                txtActualDespatchDate.BackColor = Color.Red;
            }
            if (txtActualDespatchTime.Text == "")
            {
                txtActualDespatchTime.BackColor = Color.Red;
            }
            if (txtcbcID18.Text == "")
            {
                txtcbcID18.BackColor = Color.Red;
            }
            if (txtNote3.Text == "")
            {
                txtNote3.BackColor = Color.Red;
            }
            if (txtDeliveredQuantity1.Text == "")
            {
                txtDeliveredQuantity1.BackColor = Color.Red;
            }
            if (txtOutstandingQuantity1.Text == "")
            {
                txtOutstandingQuantity1.BackColor = Color.Red;
            }
            if (txtOutstandingReason1.Text == "")
            {
                txtOutstandingReason1.BackColor = Color.Red;
            }
            if (txtOutstandingReason1.Text == "")
            {
                txtOutstandingReason1.BackColor = Color.Red;
            }
            if (txtLineID1.Text == "")
            {
                txtLineID1.BackColor = Color.Red;
            }
            if (txtName14.Text == "")
            {
                txtName14.BackColor = Color.Red;
            }
            if (txtcbcID19.Text == "")
            {
                txtcbcID19.BackColor = Color.Red;
            }
            if (txtcbcID20.Text == "")
            {
                txtcbcID20.BackColor = Color.Red;
            }
            if (txtcbcID21.Text == "")
            {
                txtcbcID21.BackColor = Color.Red;
            }
            if (txtInvoicedQuantity1.Text == "")
            {
                txtInvoicedQuantity1.BackColor = Color.Red;
            }
            if (txtLineExtensionAmount1.Text == "")
            {
                txtLineExtensionAmount1.BackColor = Color.Red;
            }
            if (txtName15.Text == "")
            {
                txtName15.BackColor = Color.Red;
            }
            if (txtPriceAmount1.Text == "")
            {
                txtPriceAmount1.BackColor = Color.Red;
            }
            if (txtcbcID22.Text == "")
            {
                txtcbcID22.BackColor = Color.Red;
            }
            if (txtNote4.Text == "")
            {
                txtNote4.BackColor = Color.Red;
            }
            if (txtDeliveredQuantity2.Text == "")
            {
                txtDeliveredQuantity2.BackColor = Color.Red;
            }
            if (txtOutstandingQuantity2.Text == "")
            {
                txtOutstandingQuantity2.BackColor = Color.Red;
            }
            if (txtOutstandingReason2.Text == "")
            {
                txtOutstandingReason2.BackColor = Color.Red;
            }
            if (txtLineID2.Text == "")
            {
                txtLineID2.BackColor = Color.Red;
            }
            if (txtName16.Text == "")
            {
                txtName16.BackColor = Color.Red;
            }
            if (txtcbcID23.Text == "")
            {
                txtcbcID23.BackColor = Color.Red;
            }
            if (txtcbcID24.Text == "")
            {
                txtcbcID24.BackColor = Color.Red;
            }
            if (txtcbcID25.Text == "")
            {
                txtcbcID25.BackColor = Color.Red;
            }
            if (txtInvoicedQuantity2.Text == "")
            {
                txtInvoicedQuantity2.BackColor = Color.Red;
            }
            if (txtLineExtensionAmount2.Text == "")
            {
                txtLineExtensionAmount2.BackColor = Color.Red;
            }
            if (txtName17.Text == "")
            {
                txtName17.BackColor = Color.Red;
            }
            if (txtPriceAmount2.Text == "")
            {
                txtPriceAmount2.BackColor = Color.Red;
            }

           

        }


    }


}

