using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesMatePlusLib;

namespace CSharpSDKTest
{
    public partial class ISmpReportItemAttributesDlg : Form
    {
        ListViewItem item1;
        ColumnHeader ColContentName, ColContent, ColRow, ColMRow, ColColumn, ColMColumn, ColAlignment, ColFontSize;
        string strHeader, strHRow, strHMRow, strHCol, strHMCol, strHAlignment, strHFont, strHFontColor, strHFontSize;
        string strFooter, strFRow, strFMRow, strFCol, strFMCol, strFAlignment, strFFont, strFFontColor, strFFontSize;
     
        public ISmpReportItemAttributesDlg()
        {
            InitializeComponent();
        }

        private void ClsBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GetAttributes()
        {
            strHeader = HeaderTxt.Text;
            strHRow = HRowCombo.Text;
            strHMRow = HMRowCombo.Text;
            strHCol = HColCombo.Text;
            strHMCol = HMColCombo.Text;
            strHAlignment = HAlignmentCombo.Text;
            strHFont = HFontCombo.Text;
            strHFontColor = HFontColorCombo.Text;
            strHFontSize = HFontSizeCombo.Text;
            strFooter = Footertxt.Text;
            strFRow = FRowCombo.Text;
            strFCol = FColCombo.Text;
            strFMRow = FMRowCombo.Text;
            strFMCol = FMColCombo.Text;
            strFAlignment = FAlignmentCombo.Text;
            strFFont = FFontCombo.Text;
            strFFontColor = FFontColorCombo.Text;
            strFFontSize = FFontSizeCombo.Text;
        }

        private void InitialiseCombo()
        {
            for (int count = 0; count < 50; count++)
            {
                HRowCombo.Items.Add(count);
                HColCombo.Items.Add(count);
                HMRowCombo.Items.Add(count);
                HMColCombo.Items.Add(count);
                HFontSizeCombo.Items.Add(count);
                FRowCombo.Items.Add(count);
                FColCombo.Items.Add(count);
                FMColCombo.Items.Add(count);
                FMRowCombo.Items.Add(count);
                FFontSizeCombo.Items.Add(count);
                CRowCombo.Items.Add(count);
                CColCombo.Items.Add(count);
                CMRowCombo.Items.Add(count);
                CMColCombo.Items.Add(count);
                CFontSizeCombo.Items.Add(count);
            }
            HFontCombo.Items.Add("Times New Roman");
            HFontCombo.Items.Add("Comic Sans MS");
            HFontCombo.Items.Add("Verdana");
            HFontCombo.Items.Add("Book Antiqua");
            HFontCombo.Items.Add("Impact");

            FFontCombo.Items.Add("Times New Roman");
            FFontCombo.Items.Add("Comic Sans MS");
            FFontCombo.Items.Add("Verdana");
            FFontCombo.Items.Add("Book Antiqua");
            FFontCombo.Items.Add("Impact");

            HFontColorCombo.Items.Add("RED");
            HFontColorCombo.Items.Add("BLUE");
            HFontColorCombo.Items.Add("GREEN");

            FFontColorCombo.Items.Add("RED");
            FFontColorCombo.Items.Add("BLUE");
            FFontColorCombo.Items.Add("GREEN");

            HAlignmentCombo.Items.Add("RIGHT");
            HAlignmentCombo.Items.Add("LEFT");
            HAlignmentCombo.Items.Add("CENTER");

            FAlignmentCombo.Items.Add("RIGHT");
            FAlignmentCombo.Items.Add("LEFT");
            FAlignmentCombo.Items.Add("CENTER");

            CAlignmentCombo.Items.Add("RIGHT");
            CAlignmentCombo.Items.Add("LEFT");
            CAlignmentCombo.Items.Add("CENTER");
        }

        private void InitialiseList()
        {
            RsltList.View = View.Details;
            ColContentName = RsltList.Columns.Add("Content Name", 100, HorizontalAlignment.Left);
            ColContent = RsltList.Columns.Add("Content", 100, HorizontalAlignment.Left);
            ColRow = RsltList.Columns.Add("Row", 100, HorizontalAlignment.Left);
            ColColumn = RsltList.Columns.Add("Column", 100, HorizontalAlignment.Left);
            ColMRow = RsltList.Columns.Add("Maximum Row", 100, HorizontalAlignment.Left);
            ColMColumn = RsltList.Columns.Add("Maximum Column", 100, HorizontalAlignment.Left);
            ColAlignment = RsltList.Columns.Add("Alignment", 100, HorizontalAlignment.Left);
            ColFontSize = RsltList.Columns.Add("Font Size", 100, HorizontalAlignment.Left);
        }

        private void ISmpReportItemAttributesDlg_Load(object sender, EventArgs e)
        {
            InitialiseCombo();
            InitialiseList();
        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            item1 = new ListViewItem(ContentNmeTxt.Text);
            item1.SubItems.Add(ContentTxt.Text);
            item1.SubItems.Add(CRowCombo.Text);
            item1.SubItems.Add(CColCombo.Text);
            item1.SubItems.Add(CMRowCombo.Text);
            item1.SubItems.Add(CMColCombo.Text);
            item1.SubItems.Add(CAlignmentCombo.Text);
            item1.SubItems.Add(CFontSizeCombo.Text);
            RsltList.Items.AddRange(new ListViewItem[] {item1});
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            ContentNmeTxt.Text = "";
            ContentTxt.Text = "";
            CRowCombo.Text = "";
            CColCombo.Text = "";
            CMRowCombo.Text = "";
            CMColCombo.Text = "";
            CAlignmentCombo.Text = "";
            CFontSizeCombo.Text = "";
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < RsltList.Items.Count; i++)
            {
                if (RsltList.Items[i].Selected)
                {
                    RsltList.Items[i].Remove();
                    i--;
                }
            }
        }



        private void ShwBtn_Click(object sender, EventArgs e)
        {
            GetAttributes();
            
            string strHeaderFont = "Monotype Corsiva";
            string strFooterFont = "Verdana";
            string strContentName, strContent, strCRow, strCMRow, strCCol, strCMCol, strCAligment;
       
            IISmpGenericReport m_ISmpGenericReport;
            m_ISmpGenericReport = new ISmpGenericReportClass();

            ISmpReportItemAttributes m_SmpReportItemAttributes_Body;
            m_SmpReportItemAttributes_Body = new SmpReportItemAttributesClass();

            ISmpReportItemAttributes m_SmpReportItemAttributes_Header;
            m_SmpReportItemAttributes_Header = new SmpReportItemAttributesClass();

            ISmpReportItemAttributes m_SmpReportItemAttributes_Footer;
            m_SmpReportItemAttributes_Footer = new SmpReportItemAttributesClass();

            IItem m_Item_Header;
            m_Item_Header = new ItemClass();

            Item m_ItemHeader;
            m_ItemHeader = new Item();

            Item m_ItemFooter;
            m_ItemFooter = new Item();
            
            IItem m_Item_Footer;
            m_Item_Footer = new ItemClass();

            try
            {
                m_Item_Header.Content = strHeader;
                m_Item_Header.ContentType = 0;
                m_Item_Header.Col = Convert.ToInt32(strHCol);
                m_Item_Header.HAlign = Convert.ToInt32(StringAlignment.Center);
                m_Item_Header.MaxCol = Convert.ToInt32(strHMCol);
                m_Item_Header.MaxRow = Convert.ToInt32(strHMRow);
                m_Item_Header.Row = Convert.ToInt32(strHRow);

                m_Item_Footer.Col = Convert.ToInt32(strFCol);
                m_Item_Footer.Content = strFooter;
                m_Item_Footer.ContentType = 0;
                m_Item_Footer.HAlign = Convert.ToInt32(StringAlignment.Center);
                m_Item_Footer.MaxCol = Convert.ToInt32(strFMCol);
                m_Item_Footer.MaxRow = Convert.ToInt32(strFMRow);
                m_Item_Footer.Row = Convert.ToInt32(strFRow);

                //Header Properties

                if (strHFontColor == "RED")
                {
                    m_SmpReportItemAttributes_Header.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(255, 0, 0)));

                }
                else if (strHFontColor == "BLUE")
                {
                    m_SmpReportItemAttributes_Header.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 0, 255)));
                }
                else
                {
                    m_SmpReportItemAttributes_Header.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 255, 0)));
                }
                if (HBoldCheckBox.Checked == true)
                {
                    m_SmpReportItemAttributes_Header.HeadingBold = 1;
                }
                m_SmpReportItemAttributes_Header.HeadingFont = strHeaderFont;
                m_SmpReportItemAttributes_Header.HeadingFontSize = Convert.ToInt32(strHFontSize);
                m_SmpReportItemAttributes_Header.ItemCount = 5;
                m_SmpReportItemAttributes_Header.set_Item(0, m_ItemHeader);

                //Body Properties
                if (CBoldCheckBox.Checked == true)
                {
                    m_SmpReportItemAttributes_Body.NormalBold = 1;
                }
                m_SmpReportItemAttributes_Body.NormalFontSize = 20;
                if (CItalicsCombo.Checked == true)
                {
                    m_SmpReportItemAttributes_Body.NormalItalic = 1;
                }
                if (CShowheadingCheckBox.Checked == true)
                {
                    m_SmpReportItemAttributes_Body.ShowHeading = 1;
                }

                //Footer Properties
                if (strFFontColor == "RED")
                {
                    m_SmpReportItemAttributes_Footer.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(255, 0, 0)));
                }
                else if (strFFontColor == "BLUE")
                {
                    m_SmpReportItemAttributes_Footer.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 0, 255)));
                }
                else
                {
                    m_SmpReportItemAttributes_Footer.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 255, 0)));
                }
                if (FBoldCheckBox.Checked == true)
                {
                    m_SmpReportItemAttributes_Footer.FooterBold = 1;
                }
                m_SmpReportItemAttributes_Footer.FooterFont = strFooterFont;
                m_SmpReportItemAttributes_Footer.FooterFontSize = Convert.ToInt32(strFFontSize);
                m_SmpReportItemAttributes_Footer.ItemCount = 5;
                m_SmpReportItemAttributes_Footer.set_Item(0, m_ItemFooter);

                m_ISmpGenericReport.HeaderProperties = (SmpReportItemAttributes)m_SmpReportItemAttributes_Header;
                m_ISmpGenericReport.BodyProperties = (SmpReportItemAttributes)m_SmpReportItemAttributes_Body;
                m_ISmpGenericReport.FooterProperties = (SmpReportItemAttributes)m_SmpReportItemAttributes_Footer;

                m_ISmpGenericReport.AddReportHeading(m_Item_Header.Row, m_Item_Header.Col, m_Item_Header.MaxRow, m_Item_Header.MaxCol, m_Item_Header.Content, m_Item_Header.HAlign, m_Item_Header.ContentType);

                for (int icount = 0; icount < RsltList.Items.Count; icount++)
                {
                    RsltList.Items[icount].Selected = true;
                    if (RsltList.Items[icount].Selected == true)
                    {
                        strContentName = RsltList.Items[icount].SubItems[0].Text;
                        strContent = RsltList.Items[icount].SubItems[1].Text;
                        strCRow = RsltList.Items[icount].SubItems[2].Text;
                        strCCol = RsltList.Items[icount].SubItems[3].Text;
                        strCMRow = RsltList.Items[icount].SubItems[4].Text;
                        strCMCol = RsltList.Items[icount].SubItems[5].Text;
                        strCAligment = RsltList.Items[icount].SubItems[6].Text;

                        m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol), strContentName, Right, 1);
                        m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol) + 1, strContent, Right, 1);
                    }
                }

                m_ISmpGenericReport.AddFooterContents(m_Item_Footer.Row, m_Item_Footer.Col, m_Item_Footer.MaxRow, m_Item_Footer.MaxCol, m_Item_Footer.Content, m_Item_Footer.HAlign, m_Item_Footer.ContentType);

                m_ISmpGenericReport.FillReport();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }
    }
}