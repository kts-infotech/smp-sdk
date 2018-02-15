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
    public partial class ISmpFileMenuOperationsDlg : Form
    {
        public ISmpFileMenuOperationsDlg()
        {
            InitializeComponent();
        }

        private void BackupDatabtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokeBackupDataDlg();
        }

        private void ChangePasswordbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokeChangePasswordDlg();
        }

        private void ExportReportbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokeExportReportDlg();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokeLoginDlg();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokeLogout();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokeExit();

            Application.Exit();
        }

        
        private void Printbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokePrintDlg();
        }

        private void PrintOldReceiptbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokePrintOldReceiptDlg();
        }

        private void PrintPreviewbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokePrintPreviewDlg();
        }

        private void PrintSetupbtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokePrintSetupDlg();
        }

        private void RestoreDatabtn_Click(object sender, EventArgs e)
        {
            ISmpFileMenuOperations m_SmpFileMenuOperations;

            m_SmpFileMenuOperations = new SmpFileMenuOperationsClass();

            m_SmpFileMenuOperations.InvokeRestoreDataDlg();
        }
    }
}