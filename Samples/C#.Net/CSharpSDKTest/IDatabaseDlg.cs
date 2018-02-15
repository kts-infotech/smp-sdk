using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesMatePlusLib;
using System.Data.SqlClient;

namespace CSharpSDKTest
{

    public partial class IDatabaseDlg : Form
    {

        public IDatabaseDlg()
        {
            InitializeComponent();
        }


        private void Adbtn_Click(object sender, EventArgs e)
        {
            if (FldNmeTxt.Text == "")
            {
                MessageBox.Show("Enter the Field Name");
            }
            else
            {
                FLdNmeListBox.Items.Add(FldNmeTxt.Text);

                FldNmeTxt.Clear();
            }
        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Exebtn_Click(object sender, EventArgs e)
        {
            try
            {
                IDatabase m_Database;
                m_Database = new DatabaseClass();
                
                string sCommand = string.Empty;

                if (MSaccesbtn.Checked == true)
                {
                    int iMsAcess;
                    iMsAcess= m_Database.IsMSAccess;
                }
               
                if (opertncmbobox.Text == "SELECT")
                {
                    object objconnection = m_Database.ConnectionInterface;
                    string strDataBase = Tabletxt.Text;
                    DataSet ds = new DataSet();

                    for (int icount = 0; icount < FLdNmeListBox.Items.Count; icount++)
                    {
                        sCommand = "SELECT ";
                        string strFldName = FLdNmeListBox.Items[icount].ToString();

                        sCommand += " " + strFldName + " ";

                        sCommand += " FROM " + strDataBase;
                        object outRecordset = new object();
                        m_Database.ExecuteQueryEx(sCommand, ref outRecordset);
                        ADODB.Recordset objRec = (ADODB.Recordset)outRecordset;
                        System.Data.OleDb.OleDbDataAdapter da =new System.Data.OleDb.OleDbDataAdapter();
                        da.Fill(ds, objRec, strFldName);
                        RsltGrid.DataSource = ds.DefaultViewManager;
                        sCommand = string.Empty;

                     }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
           
        }

        private void IDatabaseDlg_Load(object sender, EventArgs e)
        {

            IDatabase m_Database;
            m_Database = new DatabaseClass();
            DBPathlist.Items.Add(m_Database.DBPath);
        }

        private void MSaccesbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (MSaccesbtn.Checked == true)
            {
                Sqlbtn.Checked = false;
            }
        }

        private void Sqlbtn_CheckedChanged(object sender, EventArgs e)
        {
            if(Sqlbtn.Checked==true)
            {
                MSaccesbtn.Checked=false;
            }

        }
    }

}