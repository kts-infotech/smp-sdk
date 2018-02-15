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
    public partial class IGridDlg : Form
    {
        IGrid m_Grid;
        string strRow, strRowHieght, strNoOfRow, strNoOfFRow, strCol, strColWidth, strNoOfCol, strNoOfFCol;
        string strFontSize, strFont, strFontType, strCellColor, strTxtColor, strHGrid, strVGrid, strCellTxt;
        int iReadOnly;

        public IGridDlg()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetComboValues()
        {
            for (int i = 0; i < 50; i++)
            {
                RowCombo.Items.Add(i);
                URowCombo.Items.Add(i);
                NoOfRowCombo.Items.Add(i);
                NoOfFRowCombo.Items.Add(i);
                RowHieghtCombo.Items.Add(i);
                ColumnCombo.Items.Add(i);
                ColumnWidthCombo.Items.Add(i);
                UColumnCombo.Items.Add(i);
                NoOfColumnCombo.Items.Add(i);
                NoOfFColumnCombo.Items.Add(i);
                FontSizeCombo.Items.Add(i);
            }

            FontCombo.Items.Add("Times New Roman");
            FontCombo.Items.Add("Comic Sans MS");
            FontCombo.Items.Add("Verdana");
            FontCombo.Items.Add("Book Antiqua");
            FontCombo.Items.Add("Impact");

            CellColorCombo.Items.Add("RED");
            CellColorCombo.Items.Add("BLUE");
            CellColorCombo.Items.Add("GREEN");

            CellTxtColorCombo.Items.Add("RED");
            CellTxtColorCombo.Items.Add("BLUE");
            CellTxtColorCombo.Items.Add("GREEN");

            FontTypeCombo.Items.Add("Capital");
            FontTypeCombo.Items.Add("Small");

            HGridCombo.Items.Add("TRUE");
            HGridCombo.Items.Add("FALSE");

            VGridCombo.Items.Add("TRUE");
            VGridCombo.Items.Add("FALSE");
        }

        private void IGridDlg_Load(object sender, EventArgs e)
        {
            SetComboValues();
        }

        private void FontChckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FontChckBox.Checked == true)
            {
                FontCombo.Enabled = true;
            }
            else
            {
                FontCombo.Enabled = false;
            }
        }

        private void FontSizeChckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FontSizeChckBox.Checked == true)
            {
                FontSizeCombo.Enabled = true;
            }
            else
            {
                FontSizeCombo.Enabled = false;
            }
        }

        private void FontTypChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FontTypChkBox.Checked == true)
            {
                FontTypeCombo.Enabled = true;
            }
            else
            {
                FontTypeCombo.Enabled = false;
            }
        }

        private void CellColorChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CellColorChkBox.Checked == true)
            {
                CellTxtColorCombo.Enabled = true;
            }
            else
            {
                CellTxtColorCombo.Enabled = false;
            }
        }

        private void UpdateRowChckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateRowChckBox.Checked == true)
            {
                URowCombo.Enabled = true;
            }
            else
            {
                URowCombo.Enabled = false;
            }
        }

        private void UpdateColumnChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateColumnChkBox.Checked == true)
            {
                UColumnCombo.Enabled = true;
            }
            else
            {
                UColumnCombo.Enabled = false;
            }
        }

        private void InserBtn_Click(object sender, EventArgs e)
        {
            
           // IGrid m_Grid;
            m_Grid = new GridClass();

            try
            {
                int icolumn = Convert.ToInt32(UColumnCombo.Text);
                int irow = Convert.ToInt32(URowCombo.Text);

                m_Grid.InsertColumn(icolumn);
                m_Grid.InsertRow(irow);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            m_Grid = new GridClass();

            try
            {
                int irow = Convert.ToInt32(URowCombo.Text);
                int icolumn = Convert.ToInt32(UColumnCombo.Text);

                m_Grid.DeleteColumn(icolumn);
                m_Grid.DeleteRow(irow);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void GetValues()
        {
            strRow = RowCombo.Text;
            strRowHieght = RowHieghtCombo.Text;
            strNoOfRow = NoOfRowCombo.Text;
            strNoOfFRow = NoOfFRowCombo.Text;
            strCol = ColumnCombo.Text;
            strColWidth = ColumnWidthCombo.Text;
            strNoOfCol = NoOfColumnCombo.Text;
            strNoOfFCol = NoOfFColumnCombo.Text;
            strFont = FontCombo.Text;
            strFontSize = FontSizeCombo.Text;
            strFontType = FontTypeCombo.Text;
            strCellColor = CellColorCombo.Text;
            strCellTxt = CellTextTxt.Text;
            strTxtColor = CellTxtColorCombo.Text;
            strHGrid = HGridCombo.Text;
            strVGrid = VGridCombo.Text;
            if (ReadOnlyChckBox.Checked == true)
            {
                iReadOnly = 1;
            }
            else if (ReadOnlyChckBox.Checked == false)
            {
                iReadOnly = 0;
            }

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            //IGrid m_Grid;
            m_Grid = new GridClass();

            IReports m_Reports;
            m_Reports = new ReportsClass();

            try
            {
                GetValues();
                m_Grid.ResetGrid();

                m_Grid.ReadOnly = iReadOnly;
                m_Grid.NoOfRows = Convert.ToInt32(strNoOfRow);
                m_Grid.NoOfColumns = Convert.ToInt32(strNoOfCol);
                m_Grid.NoOfFixedRows = Convert.ToInt32(strNoOfFRow);
                m_Grid.NoOfFixedColumns = Convert.ToInt32(strNoOfFCol);
                m_Grid.set_RowHeight(Convert.ToInt32(strRow), Convert.ToInt32(strRowHieght));
                m_Grid.set_ColumnWidth(Convert.ToInt32(strCol), Convert.ToInt32(strColWidth));
                if (strCellColor == "RED")
                {
                    m_Grid.set_CellColour(Convert.ToInt32(strRow), Convert.ToInt32(strCol), Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(255, 0, 0))));
                }
                else if (strCellColor == "BLUE")
                {
                    m_Grid.set_CellColour(Convert.ToInt32(strRow), Convert.ToInt32(strCol), Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(0, 0, 255))));
                }
                else
                {
                    m_Grid.set_CellColour(Convert.ToInt32(strRow), Convert.ToInt32(strCol), Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(0, 255, 0))));
                }
                m_Grid.UnmergeCells(Convert.ToInt32(strRow), Convert.ToInt32(strCol), Convert.ToInt32(strRow) + 1, Convert.ToInt32(strCol) + 1);
                m_Grid.MergeCells(Convert.ToInt32(strRow), Convert.ToInt32(strCol), Convert.ToInt32(strRow) + 1, Convert.ToInt32(strCol) + 1);
                
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void IGridDlg_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_Grid = null;
            this.Close();
        }



    }
}