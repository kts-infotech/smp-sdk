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
    public partial class SmpGridDlg : Form
    {
        IGrid m_Grid;
        ISmpGridCtrl objISmpGridCtrl = new SmpGridCtrlClass();
        ISmpGrid objISmpGrid = new SmpGridClass();
        ISmpPluginTab objPluginTab = new SmpPluginTab();

        public static int DT_CENTER = 0x00000001;
        public static int DT_RIGHT = 0x00000002;

        public SmpGridDlg()
        {
           
            InitializeComponent();
        }
        public void CreateMatrixGrid()
        {
            m_Grid = new GridClass();

            try
            {
                m_Grid.NoOfRows = 15;
                m_Grid.NoOfColumns = 10;

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        private void button_AUTO_SIZE_Click(object sender, EventArgs e)
        {
            m_Grid = new GridClass();
           

            try
            {
                objISmpGridCtrl.DeleteAllItems();
                m_Grid.NoOfRows = 15;
                m_Grid.NoOfColumns = 10;
                m_Grid.set_CellText(3, 3, "KTS INFOTECH");
                objISmpGridCtrl.AutoSize();
                objPluginTab.SetCurrentView(0);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

            
        }

        private void button_SET_AUTO_SIZE_STYLE_Click(object sender, EventArgs e)
        {
            objISmpGridCtrl.DeleteAllItems();
            CreateMatrixGrid();
            m_Grid.set_CellText(3, 3, "PALA");
            objISmpGrid.SetAutoSizeStyle(DT_CENTER);
            objPluginTab.SetCurrentView(0);
        }

        private void button_SET_FOCUS_CELL_Click(object sender, EventArgs e)
        {
            objISmpGridCtrl.DeleteAllItems();
            CreateMatrixGrid();          
            objISmpGrid.SetFocusCell(2,2);
            objPluginTab.SetCurrentView(0);
        }

        
    }
}