using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesMatePlusLib;
using System.IO;
using System.Reflection;

namespace CSharpSDKTest
{

    public partial class SmpGridCtrlDlg : Form
    {
        public static int DT_CENTER=0x00000001;
        public static int DT_RIGHT = 0x00000002;
        public static int  DT_WORDBREAK=0x00000010;
        public static int  DT_LEFT =0x00000000;
        public static int DT_NOCLIP = 0x00000100;
        public static int DT_TOP=0x00000000;

        IGrid m_Grid;
        ISmpGridCtrl objISmpGrid = new SmpGridCtrlClass();
        ISmpPluginTab objPluginTab = new SmpPluginTab();
        public string strImagePath="";

        private void SmpGridCtrlDlg_Load(object sender, EventArgs e)
        {
            comboBoxSelectColumn.SelectedIndex = 0;
            comboBoxSelectRow.SelectedIndex = 0;
            comboBoxSetCellTextWrapRow.SelectedIndex = 0;
            comboBoxSetCellTextWrapColumn.SelectedIndex = 0;
            comboBoxSetCellTextAlignmentRow.SelectedIndex = 0;
            comboBoxSetCellTextAlignmentColumn.SelectedIndex = 0;
            comboBoxSetCellImageExRow.SelectedIndex = 0;
            comboBoxSetCellImageExColumn.SelectedIndex = 0;
            comboBoxSetCellTextRow.SelectedIndex = 0;
            comboBoxSetCellTextColumn.SelectedIndex = 0;
            comboBoxSetCellImageFromFileRow.SelectedIndex = 0;
            comboBoxSetCellImageFromFileColumn.SelectedIndex = 0;

        }

        public SmpGridCtrlDlg()
        {
            InitializeComponent();
        }

        public void CreateMatrixGrid()
        {
            m_Grid = new GridClass();

            try
            {
                m_Grid.NoOfRows=15;
                m_Grid.NoOfColumns=10;
                
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void SetBusinessLogoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objISmpGrid.DeleteAllItems();
                int NoofRows = int.Parse(comboBoxSelectRow.SelectedItem.ToString());
                int NoofColumns = int.Parse(comboBoxSelectColumn.SelectedItem.ToString());
                
                CreateMatrixGrid();
                objISmpGrid.SetBusinessLogo(NoofRows, NoofColumns, 150, 45);
                m_Grid.set_RowHeight(NoofRows, 50);
                m_Grid.set_ColumnWidth(NoofColumns, 160);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
                     
           
        }

        private void SetCellTextWrapBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objISmpGrid.DeleteAllItems();
                int NoofRows = int.Parse(comboBoxSetCellTextWrapRow.SelectedItem.ToString());
                int NoofColumns = int.Parse(comboBoxSetCellTextWrapColumn.SelectedItem.ToString());

                CreateMatrixGrid();
                objISmpGrid.SetCellTextWrap(NoofRows, NoofColumns, DT_RIGHT);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SetDefaultColumnWidthBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objISmpGrid.DeleteAllItems();
                int ColumnWidth = int.Parse(textBoxSetDefaultColumnWidth.Text);
                             
                CreateMatrixGrid();
                objISmpGrid.SetDefaultColumnWidth(ColumnWidth);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SetDefaultRowHeightBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objISmpGrid.DeleteAllItems();
                int RowHeight = int.Parse(textBoxSetDefaultRowHeight.Text);

                CreateMatrixGrid();
                objISmpGrid.SetDefaultRowHeight(RowHeight);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SetAlignmentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objISmpGrid.DeleteAllItems();
                int NoofRows = int.Parse(comboBoxSetCellTextAlignmentRow.SelectedItem.ToString());
                int NoofColumns = int.Parse(comboBoxSetCellTextAlignmentColumn.SelectedItem.ToString());

                CreateMatrixGrid();             
                objISmpGrid.SetCellTextAlignment(NoofRows, NoofColumns, DT_CENTER);
                m_Grid.set_RowHeight(NoofRows, 50);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SetCellImageExBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objISmpGrid.DeleteAllItems();
                int NoofRows = int.Parse(comboBoxSetCellImageExRow.SelectedItem.ToString());
                int NoofColumns = int.Parse(comboBoxSetCellImageExColumn.SelectedItem.ToString());

                CreateMatrixGrid();
                Assembly thisAssembly = Assembly.GetExecutingAssembly();
                Stream rgbBmp = thisAssembly.GetManifestResourceStream("Bitmap1.bmp");
                Bitmap bmp = new Bitmap(rgbBmp);
                
                IntPtr bitMapHandle = bmp.GetHbitmap();

                objISmpGrid.SetCellImageEx(NoofRows, NoofColumns, (int)bitMapHandle, (int)System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly().GetModule("CSharpSDKTest.dll")), 48, 48);
                m_Grid.set_RowHeight(NoofRows, 100);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SetCellTextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objISmpGrid.DeleteAllItems();
                int NoofRows = int.Parse(comboBoxSetCellTextRow.SelectedItem.ToString());
                int NoofColumns = int.Parse(comboBoxSetCellTextColumn.SelectedItem.ToString());
                string strCellText = textBoxSetCellText.Text.ToString(); 
                CreateMatrixGrid();

                objISmpGrid.SetCellText(NoofRows, NoofColumns, strCellText, DT_CENTER | DT_WORDBREAK);
                m_Grid.set_RowHeight(NoofRows, 40);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SetWordWrapModeBtn_Click(object sender, EventArgs e)
        {
            CreateMatrixGrid();            
            objISmpGrid.SetWordWrapMode(DT_WORDBREAK);
            objPluginTab.SetCurrentView(0);
        }

        private void SetGridDisplayReadOnlyBtn_Click(object sender, EventArgs e)
        {
            CreateMatrixGrid();
            objISmpGrid.SetGridDisplayReadOnly(1);
            objPluginTab.SetCurrentView(0);

        }

        private void SetCellImageFromFileBrowseBtn_Click(object sender, EventArgs e)
        {
            strImagePath = "";
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // image file path  
                strImagePath = open.FileName;
            }  
        }

        private void SetCellImageFromFileBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                objISmpGrid.DeleteAllItems();
                int NoofRows = int.Parse(comboBoxSetCellImageFromFileRow.SelectedItem.ToString());
                int NoofColumns = int.Parse(comboBoxSetCellImageFromFileColumn.SelectedItem.ToString());

                if (strImagePath == "")
                {
                    MessageBox.Show("Please select an image");
                    return;
                }
                CreateMatrixGrid();
               
                                                
                objISmpGrid.SetCellImage(NoofRows, NoofColumns, strImagePath, 50, 30);
                m_Grid.set_RowHeight(NoofRows, 70);
                m_Grid.set_ColumnWidth(NoofColumns,100);
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteAllImagesBtn_Click(object sender, EventArgs e)
        { 
         
            //objISmpGrid.DeleteAllImages();
            objPluginTab.SetCurrentView(0);
        }

        private void DeleteAllItemsBtn_Click(object sender, EventArgs e)
        {
            objISmpGrid.DeleteAllItems();
            objPluginTab.SetCurrentView(0);
        }

        private void RefreshControlBtn_Click(object sender, EventArgs e)
        {
            objISmpGrid.RefreshCtrl();
            objPluginTab.SetCurrentView(0);
        }

        private void AutoSizeBtn_Click(object sender, EventArgs e)
        {
            m_Grid = new GridClass();
            objISmpGrid.DeleteAllItems();
            try
            {
                m_Grid.NoOfRows = 15;
                m_Grid.NoOfColumns = 10;
                m_Grid.set_CellText(3,3,"KTS INFOTECH");
                objISmpGrid.AutoSize();
                objPluginTab.SetCurrentView(0);

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

            
        }

        private void CreateBasicReportBtn_Click(object sender, EventArgs e)
        {
            m_Grid = new GridClass();
            objISmpGrid.DeleteAllItems();
            m_Grid.HorizondalGridLine = 3;
            string strShopName, strShopAddress, strShopCity, strShopPhone, strShopGSTIN,strSupplyStateName; 
            float fHandlingCharges = 0;          
            strShopName = "KTS INFOTECH";
            strShopAddress = "Pala";
            strShopCity = "Kottayam";
            strShopPhone = "123456789";
            strShopGSTIN = "32GST1233HF";

            int HeaderRows = 12;
            int ContentRows = 0;
            int FooterRows = 12;

            int TotalRows = HeaderRows + ContentRows + FooterRows;
            int MaxNoOfCoumns = 10;

            int iHeaderRowIndex = 0, strSupplyStateID;
            m_Grid.NoOfRows = HeaderRows + ContentRows + FooterRows;
            m_Grid.NoOfColumns=MaxNoOfCoumns;
            //Put the column width
            for (int i = 0; i < MaxNoOfCoumns; i++)
            {
                m_Grid.set_ColumnWidth(i, 25);
            }

            m_Grid.ReadOnly = 0;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_RowHeight(iHeaderRowIndex, 2);           
            iHeaderRowIndex++;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_CellFontSize(iHeaderRowIndex, 0, 25);

            m_Grid.set_RowHeight(iHeaderRowIndex, 35);

            objISmpGrid.SetCellText(iHeaderRowIndex, 0, strShopName, DT_CENTER | DT_WORDBREAK);
            iHeaderRowIndex++;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_RowHeight(iHeaderRowIndex, 0);
            iHeaderRowIndex++;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_CellFontSize(iHeaderRowIndex, 0, 15);
            objISmpGrid.SetCellText(iHeaderRowIndex, 0, "PRINT TYPE", DT_CENTER | DT_WORDBREAK);
            iHeaderRowIndex++;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_RowHeight(iHeaderRowIndex, 0);
            iHeaderRowIndex++;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_RowHeight(iHeaderRowIndex, 30);

            objISmpGrid.SetCellText(iHeaderRowIndex, 0, (strShopAddress + strShopCity + ", Phone: " + strShopPhone), DT_CENTER | DT_WORDBREAK);

            iHeaderRowIndex++;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_CellFontSize(iHeaderRowIndex, 0, 15);
            objISmpGrid.SetCellText(iHeaderRowIndex, 0, ("GSTIN: " + strShopGSTIN), DT_CENTER | DT_WORDBREAK);
            iHeaderRowIndex++;

            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_CellFontSize(iHeaderRowIndex, 0, 25);
            m_Grid.set_RowHeight(iHeaderRowIndex, 27);
            objISmpGrid.SetCellText(iHeaderRowIndex, 0, "Tax Invoice", DT_CENTER | DT_WORDBREAK);
            iHeaderRowIndex++;


            //Gap
            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_RowHeight(iHeaderRowIndex, 1);
            iHeaderRowIndex++;
            //End Gap

            //Header Text first row
            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 4);
            m_Grid.set_CellText(iHeaderRowIndex, 0, "Invoice No: 10");
            m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex, 9);
            objISmpGrid.SetCellText(iHeaderRowIndex, 4, "Date: 05/10/2017", DT_RIGHT | DT_WORDBREAK);
            iHeaderRowIndex++;



            strSupplyStateID = 32;
            strSupplyStateName = "Kerala";

            //Header Text second row
            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 4);
            m_Grid.set_CellText(iHeaderRowIndex, 0, ("Billed To: Rajeev"));

            m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex, 9);
            objISmpGrid.SetCellText(iHeaderRowIndex, 4, ("State: " + strSupplyStateName), DT_RIGHT | DT_WORDBREAK);
            iHeaderRowIndex++;

            //Header Text third row
            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 4);
            m_Grid.set_CellText(iHeaderRowIndex, 0, ("GSTIN: 07AIFPR5898G2ZL"));

            m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex, 9);
            objISmpGrid.SetCellText(iHeaderRowIndex, 4, ("State Code: " + strSupplyStateID), DT_RIGHT | DT_WORDBREAK);
            iHeaderRowIndex++;

            //GAP
            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1);
            m_Grid.set_RowHeight(iHeaderRowIndex, 1);
            iHeaderRowIndex++;
            //End GAP
            //Now set the Item Headers
            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex + 1, 2);
            m_Grid.set_ColumnWidth(0, 80);
            objISmpGrid.SetCellText(iHeaderRowIndex, 0, "Item Name", DT_CENTER | DT_WORDBREAK);

            m_Grid.MergeCells(iHeaderRowIndex, 3, iHeaderRowIndex + 1, 3);
            m_Grid.set_ColumnWidth(3, 30);
            objISmpGrid.SetCellText(iHeaderRowIndex, 3, "Qty", DT_CENTER | DT_WORDBREAK);

            m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex + 1, 5);
            m_Grid.set_ColumnWidth(4, 40);
            objISmpGrid.SetCellText(iHeaderRowIndex, 4, "Rate", DT_CENTER | DT_WORDBREAK);


            m_Grid.MergeCells(iHeaderRowIndex, 6, iHeaderRowIndex + 1, 6);
            m_Grid.set_ColumnWidth(6, 40);
            objISmpGrid.SetCellText(iHeaderRowIndex, 6, "Tax %", DT_CENTER | DT_WORDBREAK);

            m_Grid.MergeCells(iHeaderRowIndex, 7, iHeaderRowIndex + 1, 9);
            m_Grid.set_ColumnWidth(7, 20);
            objISmpGrid.SetCellText(iHeaderRowIndex, 7, "Taxable Amount", DT_CENTER | DT_WORDBREAK);
            iHeaderRowIndex++;
            
            float fTotal;
            
            float fSubTotal;
            float fSGSTTotalTaxAmt;
            float fCGSTTotalTaxAmt;
            
            int iContentRowIndex = iHeaderRowIndex + 1;

            m_Grid.NoOfRows = (HeaderRows + 5 + FooterRows);
            m_Grid.NoOfColumns = MaxNoOfCoumns;

            int iIndex = 0;

            int iRowHeight = 45;
            m_Grid.set_RowHeight(iContentRowIndex, iRowHeight);

            m_Grid.MergeCells(iContentRowIndex, 0, iContentRowIndex, 2);
            objISmpGrid.SetCellText(iContentRowIndex, 0, "Salesmate +", DT_LEFT | DT_WORDBREAK);

            m_Grid.set_RowHeight(iContentRowIndex, iRowHeight);
            objISmpGrid.SetCellText(iContentRowIndex, 3, "1", DT_LEFT | DT_WORDBREAK);

            m_Grid.MergeCells(iContentRowIndex, 4, iContentRowIndex, 5);
            m_Grid.set_RowHeight(iContentRowIndex, iRowHeight);
            objISmpGrid.SetCellText(iContentRowIndex, 4, "105", DT_RIGHT | DT_WORDBREAK);


            m_Grid.set_RowHeight(iContentRowIndex, iRowHeight);
            objISmpGrid.SetCellText(iContentRowIndex, 6, "28", DT_RIGHT | DT_WORDBREAK);

            m_Grid.MergeCells(iContentRowIndex, 7, iContentRowIndex, 9);
            m_Grid.set_RowHeight(iContentRowIndex, iRowHeight);
            objISmpGrid.SetCellText(iContentRowIndex, 7, "105", DT_RIGHT | DT_WORDBREAK);

           
            fSGSTTotalTaxAmt = 405;
            fCGSTTotalTaxAmt = 405;
            fSubTotal = 10620;
            iContentRowIndex++;
            iIndex++;
            int iFooterIndex = 0;
            float fDiscount = 0;
            float fTotalCessAmount = 0;

            if (fDiscount == 0)
            {
                iFooterIndex++;
            }

            if (fHandlingCharges <= 0)
            {
                iFooterIndex++;
            }

            if (true)
            {
                iFooterIndex++;
                if (fTotalCessAmount <= 0)
                {
                    iFooterIndex++;
                }

                m_Grid.NoOfRows = (iContentRowIndex + FooterRows - iFooterIndex);
                fTotal = fSubTotal + fSGSTTotalTaxAmt + fCGSTTotalTaxAmt + fTotalCessAmount + fHandlingCharges - (fDiscount);

            }
            
            m_Grid.NoOfColumns = (MaxNoOfCoumns);

            iIndex=0;
            int iFooterStartIndex = iContentRowIndex;
            //Now the Amount Section
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6);
            m_Grid.set_CellText(iFooterStartIndex + iIndex, 3, "Sub Total");

            m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9);
            objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 7, "105.00", DT_RIGHT | DT_WORDBREAK);
            iIndex++;

            //CGST
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6);
            m_Grid.set_CellText(iFooterStartIndex + iIndex, 3, "CGST");
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9);

             objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 7,"14.70", DT_RIGHT | DT_WORDBREAK);
            iIndex++;

            //SGST
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6);
            m_Grid.set_CellText(iFooterStartIndex + iIndex, 3, "SGST");
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9);
            objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 7, "14.70", DT_RIGHT | DT_WORDBREAK);
            iIndex++;


            //CESS
            if (fTotalCessAmount > 0)
            {
                m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6);
                m_Grid.set_CellText(iFooterStartIndex + iIndex, 3, "Cess");
                m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9);



                objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 7, "300", DT_RIGHT | DT_WORDBREAK);
                iIndex++;
            }

            //Handling Charges

            m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6);
            m_Grid.set_CellText(iFooterStartIndex + iIndex, 3, "Handling Charges");
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9);
            objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 7, "0.00", DT_RIGHT | DT_WORDBREAK);
            iIndex++;


            //Discount
            //Total Tax Amount after Tax
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6);
            m_Grid.set_CellText(iFooterStartIndex + iIndex, 3, "Total Invoice");
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9);
            objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 7, "134.40", DT_RIGHT | DT_WORDBREAK);
            iIndex++;

            m_Grid.MergeCells(16, 0, 20, 2);

            m_Grid.MergeCells(iFooterStartIndex + iIndex, 0, iFooterStartIndex + iIndex, MaxNoOfCoumns - 1);
            m_Grid.set_CellFontSize(iFooterStartIndex + iIndex, 0, 25);
            m_Grid.set_RowHeight(iFooterStartIndex + iIndex, 27);
            objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 0, "BILL AMOUNT: 134.40/-", DT_CENTER | DT_WORDBREAK);
            iIndex++;


            string strOperatorName = "KTS InfoTech";
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 0, iFooterStartIndex + iIndex, MaxNoOfCoumns - 1);
            m_Grid.set_CellFontSize(iFooterStartIndex + iIndex, 0, 13);
            m_Grid.set_RowHeight(iFooterStartIndex + iIndex, 20);
            objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 0, ("Cashier Name: " + strOperatorName), DT_CENTER | DT_WORDBREAK);
            iIndex++;


            m_Grid.set_RowHeight(iFooterStartIndex + iIndex, 35);

            m_Grid.MergeCells(iFooterStartIndex + iIndex , 0, iFooterStartIndex + iIndex , MaxNoOfCoumns - 1);
            objISmpGrid.SetCellText(iFooterStartIndex + iIndex, 0, "Thank You Visit Again", DT_CENTER | DT_WORDBREAK);
            iIndex++;

            objPluginTab.SetCurrentView(0);

        }
        private void CreateDetailReportBtn_Click(object sender, EventArgs e)
        {
            
        CreateMatrixGrid();            	
	    m_Grid = new GridClass();
        objISmpGrid.DeleteAllItems();
        m_Grid.HorizondalGridLine = 3;
	
	    int HeaderRows=17;
	    int ContentRows=10;
	    int FooterRows=20;
	    int iHeaderRowIndex=0;
	    int TotalRows=HeaderRows+ContentRows+FooterRows;
	    int MaxNoOfCoumns=15;

	    string strShopName,strShopAddress,strShopCity,strShopPhone,strCustomerGSTIN="",strCustomerName,strCustomerAddress;
	   
	    m_Grid.NoOfRows=(HeaderRows+ContentRows+FooterRows);

	    m_Grid.NoOfColumns =(MaxNoOfCoumns);
    	
	    //Put the folumn width
	    for(int i=0;i<MaxNoOfCoumns;i++)
	    {
		    m_Grid.set_ColumnWidth(i,60);
	    }

	    strShopName="KTS INFOTECH";
	    strShopAddress="Pala";
	    strShopCity="Kottayam";
	    strShopPhone="123456789";    
	    string strShopStateName,strShopStateID;
	    strShopStateID="32";
	    strShopStateName="Kerala";

	    //Get shipping datails
	    string strReverseCharge="No",strVehicleNo="";
	    string strSupplyStateID,strSupplyStateName;
	    strSupplyStateID="32";
	    strSupplyStateName="Kerala";
	    string strFirstName,strLastName; 
		strFirstName ="KTS";
		strLastName ="Infotech";	
		strCustomerAddress ="Pala";	
	    strCustomerName=strFirstName+" "+strLastName;

	    //Put all report data Read Only
	    objISmpGrid.SetGridDisplayReadOnly(0);


		m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		m_Grid.set_CellFontSize(iHeaderRowIndex,0,40);
		m_Grid.set_RowHeight(iHeaderRowIndex,44);
		objISmpGrid.SetCellText(iHeaderRowIndex,0,strShopName,DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		m_Grid.set_RowHeight(iHeaderRowIndex,0);
		iHeaderRowIndex++;

	
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellFontSize(iHeaderRowIndex,0,25);
	    m_Grid.set_RowHeight(iHeaderRowIndex,27);
	    objISmpGrid.SetCellText(iHeaderRowIndex,0,(strShopAddress+", "+strShopCity+", Mobile: "+strShopPhone),DT_CENTER|DT_WORDBREAK);
	    iHeaderRowIndex++;
	

		m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		m_Grid.set_CellFontSize(iHeaderRowIndex,0,21);
		
		objISmpGrid.SetCellText(iHeaderRowIndex,0,"Header Text",DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		m_Grid.set_RowHeight(iHeaderRowIndex,0);
		iHeaderRowIndex++;


	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellFontSize(iHeaderRowIndex,0,25);
	    m_Grid.set_RowHeight(iHeaderRowIndex,27);
	    objISmpGrid.SetCellText(iHeaderRowIndex,0,"GSTIN : 32fghb2544",DT_CENTER|DT_WORDBREAK);
	    iHeaderRowIndex++;

    //Now Merge header Rows/cells
    String strSalesDate = "13/05/2018";
    try
    {

		m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,1);
		m_Grid.MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,11);
		m_Grid.MergeCells(iHeaderRowIndex,12,iHeaderRowIndex+1,MaxNoOfCoumns-1);

		//Put The logo
		objISmpGrid.SetBusinessLogo(iHeaderRowIndex,0,150,45);
		m_Grid.set_RowHeight(iHeaderRowIndex,27);
		//Set the Invoice Text
		m_Grid.set_CellFontSize(iHeaderRowIndex,2,38);
		
		objISmpGrid.SetCellText(iHeaderRowIndex,2,"",DT_CENTER|DT_WORDBREAK);
		m_Grid.set_CellText(iHeaderRowIndex,13,"Duplicate");
		m_Grid.set_CellFontSize(iHeaderRowIndex,12,25);
		m_Grid.set_CellText(iHeaderRowIndex,12,"");

	  }
      catch(Exception)
      {
         //
      }

	    iHeaderRowIndex+=2;
	    //Gap
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_RowHeight(iHeaderRowIndex,1);
	    iHeaderRowIndex++;
	    //End Gap
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,1);
	    m_Grid.set_CellText(iHeaderRowIndex,0,("Reverse Charge : "+strReverseCharge));
        m_Grid.MergeCells(iHeaderRowIndex,2,iHeaderRowIndex,5);
	    m_Grid.set_CellText(iHeaderRowIndex,2,"Invoice No : 10 ");

	    m_Grid.MergeCells(iHeaderRowIndex,6,iHeaderRowIndex,8);
	    m_Grid.set_CellText(iHeaderRowIndex,6,("Invoice Date : "+strSalesDate));
    	

	    m_Grid.MergeCells(iHeaderRowIndex,9,iHeaderRowIndex,11);
	    m_Grid.set_CellText(iHeaderRowIndex,9,("State : "+strShopStateName));
	
	    m_Grid.MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellText(iHeaderRowIndex,12,("State Code : "+strShopStateID));
	    iHeaderRowIndex++;

	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,1);
	    m_Grid.set_CellText(iHeaderRowIndex,0,"Transporation Mode : cash");
	    m_Grid.MergeCells(iHeaderRowIndex,2,iHeaderRowIndex,5);
	    m_Grid.set_CellText(iHeaderRowIndex,2,("Vehicle No : "+strVehicleNo));
	    m_Grid.MergeCells(iHeaderRowIndex,6,iHeaderRowIndex,8);
	    m_Grid.set_CellText(iHeaderRowIndex,6,("Date Of Supply : "+strSalesDate));

	    m_Grid.MergeCells(iHeaderRowIndex,9,iHeaderRowIndex,11);
	    m_Grid.set_CellText(iHeaderRowIndex,9,("Place Of supply : "+strSupplyStateName));
    	
	    m_Grid.MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellText(iHeaderRowIndex,12,("State Code : "+strSupplyStateID));
	    iHeaderRowIndex++;
	
	    //Gao
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_RowHeight(iHeaderRowIndex,1);
	    iHeaderRowIndex++;
	    /////////////////////////////
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	    m_Grid.set_CellFontSize(iHeaderRowIndex,0,25);
	    m_Grid.set_RowHeight(iHeaderRowIndex,25);
	    m_Grid.set_CellText(iHeaderRowIndex,0,"Details Of The Receiver | Billed To");

	    m_Grid.MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellFontSize(iHeaderRowIndex,8,25);
	    m_Grid.set_CellText(iHeaderRowIndex,8,"Details Of The Consignee | Shipped To");
	    iHeaderRowIndex++;
    	

	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	    m_Grid.set_CellText(iHeaderRowIndex,0,("Name        : "+strCustomerName));

	    m_Grid.MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellText(iHeaderRowIndex,8,("Name        : "+strCustomerName));
	    iHeaderRowIndex++;

	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	    m_Grid.set_CellText(iHeaderRowIndex,0,("Address    : "+strCustomerAddress));

	    m_Grid.MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellText(iHeaderRowIndex,8,("Address    : "+strCustomerAddress));
	    iHeaderRowIndex++;

	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,2);
	    m_Grid.set_CellText(iHeaderRowIndex,0,("GSTIN : "+strCustomerGSTIN));

	    m_Grid.MergeCells(iHeaderRowIndex,3,iHeaderRowIndex,4);
	    m_Grid.set_CellText(iHeaderRowIndex,3,("State : "+strSupplyStateName));
	    m_Grid.MergeCells(iHeaderRowIndex,5,iHeaderRowIndex,7);
	    m_Grid.set_CellText(iHeaderRowIndex,5,("State Code : "+strSupplyStateID));

	    m_Grid.MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,10);
	    m_Grid.set_CellText(iHeaderRowIndex,8,("GSTIN : "+strCustomerGSTIN));

	    m_Grid.MergeCells(iHeaderRowIndex,11,iHeaderRowIndex,12);
	    m_Grid.set_CellText(iHeaderRowIndex,11,("State : "+strSupplyStateName));
	    m_Grid.MergeCells(iHeaderRowIndex,13,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_CellText(iHeaderRowIndex,13,("State Code : "+strSupplyStateID));
	    iHeaderRowIndex++;

	    bool bHSNCodeAvailable = false;
	    bHSNCodeAvailable=true;

	    //GAP
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_RowHeight(iHeaderRowIndex,10);
	    ///m_Grid.set_CellColour (iHeaderRowIndex,0,(long)RGB(0,0,0));
	    iHeaderRowIndex++;
	    //End GAP
	    //Now set the Item Headers
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,0);
	    m_Grid.set_ColumnWidth(0,45);
	    m_Grid.set_CellText(iHeaderRowIndex,0,"Sr.No.");
    	
	    m_Grid.MergeCells(iHeaderRowIndex,1,iHeaderRowIndex+1,1);
	    m_Grid.set_ColumnWidth(1,150);
        m_Grid.set_CellText(iHeaderRowIndex, 1, "Name of Product / Service");

	    if(bHSNCodeAvailable)
	    {
		    m_Grid.MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,2);
		    m_Grid.set_CellText(iHeaderRowIndex,2,"HSN");
	    }
	    else
	    {
		    m_Grid.MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,2);
		    m_Grid.set_CellText(iHeaderRowIndex,2,"Item ID");
	    }
	
	    m_Grid.MergeCells(iHeaderRowIndex,3,iHeaderRowIndex+1,3);
	    m_Grid.set_ColumnWidth(3,40);
	    m_Grid.set_CellText(iHeaderRowIndex,3,"Qty");

	    m_Grid.MergeCells(iHeaderRowIndex,4,iHeaderRowIndex+1,4);
	    m_Grid.set_ColumnWidth(4,70);
	    m_Grid.set_CellText(iHeaderRowIndex,4,"Rate");

	    m_Grid.MergeCells(iHeaderRowIndex,5,iHeaderRowIndex+1,5);
	    m_Grid.set_ColumnWidth(5,75);
	    m_Grid.set_CellText(iHeaderRowIndex,5,"Amount");
    	
	    m_Grid.MergeCells(iHeaderRowIndex,6,iHeaderRowIndex+1,6);
	    m_Grid.set_CellText(iHeaderRowIndex,6,"Discount");

	    m_Grid.MergeCells(iHeaderRowIndex,7,iHeaderRowIndex+1,7);
	    m_Grid.set_ColumnWidth(7,80);
	    m_Grid.set_CellText(iHeaderRowIndex,7,"Taxable Value");
	    //CGST
	    m_Grid.MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,9);
	    objISmpGrid.SetCellTextAlignment(14,8,DT_CENTER);
	    m_Grid.set_CellText(iHeaderRowIndex,8,"SGST");
	    m_Grid.set_CellText(iHeaderRowIndex+1,8,"Rate");
	    m_Grid.set_CellText(iHeaderRowIndex+1,9,"Amount");

	    ///SGST
	    m_Grid.MergeCells(iHeaderRowIndex,10,iHeaderRowIndex,11);
	    objISmpGrid.SetCellTextAlignment(iHeaderRowIndex,10,DT_CENTER);
	    m_Grid.set_CellText(iHeaderRowIndex,10,"CGST");
	    m_Grid.set_CellText(iHeaderRowIndex+1,10,"Rate");
	    m_Grid.set_CellText(iHeaderRowIndex+1,11,"Amount");

	    //IGST
	    m_Grid.MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,13);
	    objISmpGrid.SetCellTextAlignment(iHeaderRowIndex,12,DT_CENTER);
	    m_Grid.set_CellText(iHeaderRowIndex,12,"IGST");
	    m_Grid.set_CellText(iHeaderRowIndex+1,12,"Rate");
	    m_Grid.set_CellText(iHeaderRowIndex+1,13,"Amount");

	    //Total
	    m_Grid.MergeCells(iHeaderRowIndex,14,iHeaderRowIndex+1,14);
	    m_Grid.set_ColumnWidth(14,85);
	    m_Grid.set_CellText(iHeaderRowIndex,14,"Total");
	    iHeaderRowIndex+=2;
	    //Gap
	    m_Grid.MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	    m_Grid.set_RowHeight(iHeaderRowIndex,1);

	    try
        {
            int iTempRow;
            int iFooterStartIndex = 0;
            iTempRow = HeaderRows + 1;
            
            objISmpGrid.SetCellText(20, 0, "1", DT_LEFT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 1, "Salemate +", DT_LEFT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 2, "1234", DT_LEFT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 3, "2", DT_LEFT | DT_NOCLIP | DT_WORDBREAK);

            objISmpGrid.SetCellText(20, 4, "2500", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 5, "5000", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);

            objISmpGrid.SetCellText(20, 6, "500", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 7, "4500", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 8, "9", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 9, "405", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 10, "9", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 11, "405", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(20, 14, "5310", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(1, 7, "23", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(2, 3, "2", DT_LEFT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(2, 4, "25", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(2, 5, "25", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(2, 6, "2", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            objISmpGrid.SetCellText(2, 7, "23", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            //Calculate SGST,CGST,IGST rate and amount
           
            iFooterStartIndex = 25;
            m_Grid.MergeCells(iFooterStartIndex, 0, iFooterStartIndex, MaxNoOfCoumns - 1);
            m_Grid.set_RowHeight(iFooterStartIndex, 1);

            iFooterStartIndex = iFooterStartIndex + 1;
            m_Grid.MergeCells(iFooterStartIndex, 0, iFooterStartIndex, 8);
            m_Grid.set_CellText(iFooterStartIndex, 0, "Total Invoice Amount in Words:");
           
            m_Grid.MergeCells(iFooterStartIndex + 1, 0, iFooterStartIndex + 6, 8);
            m_Grid.set_CellFontSize(iFooterStartIndex + 1, 0, 30);
            objISmpGrid.SetCellText(iFooterStartIndex + 1, 0, "Ten thousand six Hundred and twenty only", DT_WORDBREAK);

            //Now the Amount Section
            m_Grid.MergeCells(iFooterStartIndex, 9, iFooterStartIndex, 12);
            m_Grid.set_CellText(iFooterStartIndex, 9, "Total Amount Before Tax");
            m_Grid.MergeCells(iFooterStartIndex, 13, iFooterStartIndex, 14);
            objISmpGrid.SetCellText(iFooterStartIndex, 13, "4500", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);

            //CGST
            m_Grid.MergeCells(iFooterStartIndex + 1, 9, iFooterStartIndex + 1, 12);
            m_Grid.set_CellText(iFooterStartIndex + 1, 9, "Add : CGST");
            m_Grid.MergeCells(iFooterStartIndex + 1, 13, iFooterStartIndex + 1, 14);
            objISmpGrid.SetCellText(iFooterStartIndex + 1, 13, "405", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            //SGST
            m_Grid.MergeCells(iFooterStartIndex + 2, 9, iFooterStartIndex + 2, 12);
            m_Grid.set_CellText(iFooterStartIndex + 2, 9, "Add : SGST");
            m_Grid.MergeCells(iFooterStartIndex + 2, 13, iFooterStartIndex + 2, 14);
            objISmpGrid.SetCellText(iFooterStartIndex + 2, 13, "405", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            //IGST
            m_Grid.MergeCells(iFooterStartIndex + 3, 9, iFooterStartIndex + 3, 12);
            m_Grid.set_CellText(iFooterStartIndex + 3, 9, "Add : IGST");
            m_Grid.MergeCells(iFooterStartIndex + 3, 13, iFooterStartIndex + 3, 14);
            objISmpGrid.SetCellText(iFooterStartIndex + 3, 13, "0", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);

            //CESS amount GST
            m_Grid.MergeCells(iFooterStartIndex + 4, 9, iFooterStartIndex + 4, 12);
            m_Grid.set_CellText(iFooterStartIndex + 4, 9, "CESS (+)");
            m_Grid.MergeCells(iFooterStartIndex + 4, 13, iFooterStartIndex + 4, 14);

            objISmpGrid.SetCellText(iFooterStartIndex + 4, 13, "0", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);

            //Discount amount 
            m_Grid.MergeCells(iFooterStartIndex + 5, 9, iFooterStartIndex + 5, 12);
            m_Grid.set_CellText(iFooterStartIndex + 5, 9, "Handling/Transportation  Charges (+) ");
            m_Grid.MergeCells(iFooterStartIndex + 5, 13, iFooterStartIndex + 5, 14);
            objISmpGrid.SetCellText(iFooterStartIndex + 5, 13, "0", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);

            //Handling/Transportation  Charges:
            //	strSalesDiscAmount.Format(_T("%0.2f"),fTotalDiskAmt);
            m_Grid.MergeCells(iFooterStartIndex + 6, 9, iFooterStartIndex + 6, 12);
            m_Grid.set_CellText(iFooterStartIndex + 6, 9, "Total Discount (-) ");
            m_Grid.MergeCells(iFooterStartIndex + 6, 13, iFooterStartIndex + 6, 14);
            objISmpGrid.SetCellText(iFooterStartIndex + 6, 13, "1000", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);

            //Total Tax Amount after Tax
            m_Grid.MergeCells(iFooterStartIndex + 7, 9, iFooterStartIndex + 7, 12);
            m_Grid.set_CellFontSize(iFooterStartIndex + 7, 9, 25);
            m_Grid.set_CellFontSize(iFooterStartIndex + 7, 13, 25);
            m_Grid.set_RowHeight(iFooterStartIndex + 7, 30);
            m_Grid.set_CellText(iFooterStartIndex + 7, 9, "Grant Total");
            m_Grid.MergeCells(iFooterStartIndex + 7, 13, iFooterStartIndex + 7, 14);
            objISmpGrid.SetCellText(iFooterStartIndex + 7, 13, "10620", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);

            //Payment Type
            m_Grid.MergeCells(iFooterStartIndex + 7, 0, iFooterStartIndex + 7, 2);
            m_Grid.set_CellText(iFooterStartIndex + 7, 0, "Payment Type");
            m_Grid.MergeCells(iFooterStartIndex + 7, 3, iFooterStartIndex + 7, 6);
            m_Grid.set_CellText(iFooterStartIndex + 7, 3, "Cash");

            //Add Bank details
            m_Grid.MergeCells(iFooterStartIndex + 8, 0, iFooterStartIndex + 8, 6);
            m_Grid.set_CellText(iFooterStartIndex + 8, 0, "Bank details");
            //Bank Account Number
            m_Grid.MergeCells(iFooterStartIndex + 9, 0, iFooterStartIndex + 9, 2);
            m_Grid.set_CellText(iFooterStartIndex + 9, 0, "Bank Account Number");
            m_Grid.MergeCells(iFooterStartIndex + 9, 3, iFooterStartIndex + 9, 6);
            m_Grid.set_CellText(iFooterStartIndex + 9, 3, "67012548223");
            //Bank Branch IfSC
            m_Grid.MergeCells(iFooterStartIndex + 10, 0, iFooterStartIndex + 10, 2);
            m_Grid.set_CellText(iFooterStartIndex + 10, 0, "Bank Branch IFSC");
            m_Grid.MergeCells(iFooterStartIndex + 10, 3, iFooterStartIndex + 10, 6);
            m_Grid.set_CellText(iFooterStartIndex + 10, 3, "SBIN0700001");
            //Terms and Conditions

            m_Grid.MergeCells(iFooterStartIndex + 11, 0, iFooterStartIndex + 14, 6);
            objISmpGrid.SetCellText(iFooterStartIndex + 11, 0, "Terms and Conditions:\n     ", DT_TOP | DT_LEFT | DT_NOCLIP | DT_WORDBREAK);

     
            m_Grid.MergeCells(iFooterStartIndex + 7, 7, iFooterStartIndex + 14, 8);
            m_Grid.set_CellText(iFooterStartIndex + 7, 7, "Office Seal");
            
            m_Grid.MergeCells(iFooterStartIndex + 8, 9, iFooterStartIndex + 8, MaxNoOfCoumns - 1);
            m_Grid.set_CellText(iFooterStartIndex + 8, 9, "GST Payable On Reverse Charge ");
            m_Grid.MergeCells(iFooterStartIndex + 8, 13, iFooterStartIndex + 8, MaxNoOfCoumns - 1);
            if (strReverseCharge == "Yes")
            {
                //fGrantTotal=fGrantTotal-fTotalGST-fTotalCess;
                //strGrantTotal.Format(_T("%0.2f"),fGrantTotal);
                objISmpGrid.SetCellText(iFooterStartIndex + 1, 0, " strDigiWords", DT_WORDBREAK);

                objISmpGrid.SetCellText(iFooterStartIndex + 7, 13, "9000", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
                objISmpGrid.SetCellText(iFooterStartIndex + 8, 13, "1620", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
            }
            else
            {
                m_Grid.set_CellText(iFooterStartIndex + 8, 13, "N/A");
            }
                //Certified
                m_Grid.MergeCells(iFooterStartIndex + 9, 9, iFooterStartIndex + 9, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 9, 9, "Certified that the particulars given above are true and correct.");

                m_Grid.MergeCells(iFooterStartIndex + 10, 9, iFooterStartIndex + 10, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 10, 9, ("For, " + strShopName));

                m_Grid.MergeCells(iFooterStartIndex + 11, 9, iFooterStartIndex + 13, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 11, 9, "Authorized Signatory :");

                //Display Operator Name

                m_Grid.MergeCells(iFooterStartIndex + 14, 9, iFooterStartIndex + 14, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 14, 9, "Operator Name ");
                m_Grid.MergeCells(iFooterStartIndex + 14, 13, iFooterStartIndex + 14, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 14, 13, "KTS InfoTech");

                //Break
                m_Grid.MergeCells(iFooterStartIndex + 8, 9, iFooterStartIndex + 8, MaxNoOfCoumns - 1);

                //Reverse Charge
                m_Grid.MergeCells(iFooterStartIndex + 9, 9, iFooterStartIndex + 9, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 9, 9, "GST Payable On Reverse Charge ");
                m_Grid.MergeCells(iFooterStartIndex + 9, 13, iFooterStartIndex + 9, MaxNoOfCoumns - 1);
                if (strReverseCharge == "Yes")
                {
                    objISmpGrid.SetCellText(iFooterStartIndex + 1, 0, "Five THousand", DT_WORDBREAK);
                    objISmpGrid.SetCellText(iFooterStartIndex + 7, 13, "9000", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
                    objISmpGrid.SetCellText(iFooterStartIndex + 9, 13, "1620", DT_RIGHT | DT_NOCLIP | DT_WORDBREAK);
                }
                else
                {
                    m_Grid.set_CellText(iFooterStartIndex + 9, 13, "N/A");
                }

                //Certified
                m_Grid.MergeCells(iFooterStartIndex + 10, 9, iFooterStartIndex + 10, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 10, 9, "Certified that the particulars given above are true and correct.");

                m_Grid.MergeCells(iFooterStartIndex + 11, 9, iFooterStartIndex + 11, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 11, 9, (("For, ") + strShopName));

                m_Grid.MergeCells(iFooterStartIndex + 12, 9, iFooterStartIndex + 14, MaxNoOfCoumns - 1);
                m_Grid.set_CellText(iFooterStartIndex + 12, 9, "Authorized Signatory :");
                
                m_Grid.MergeCells(iFooterStartIndex + 15, 0, iFooterStartIndex + 15, 6);

                m_Grid.MergeCells(iFooterStartIndex + 15, 7, iFooterStartIndex + 15, MaxNoOfCoumns - 1);

                m_Grid.MergeCells(TotalRows - 5, 0, TotalRows - 2, MaxNoOfCoumns - 1);
                objISmpGrid.SetCellText(TotalRows - 5, 0, "Thank You Visit Again", DT_CENTER | DT_NOCLIP | DT_WORDBREAK);
                objPluginTab.SetCurrentView(0);

        }
      
       catch (Exception ex)
       {
          MessageBox.Show(ex.Message.ToString());
                  		
 	   }
	       
           
     }
      

   }
}