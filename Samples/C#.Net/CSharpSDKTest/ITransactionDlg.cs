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
    public partial class ITransactionDlg : Form
    {
        public ITransactionDlg()
        {
            InitializeComponent();
        }

        private void AddMiscExpenseBtn_Click(object sender, EventArgs e)
        {
            ITransactions m_Transactions;

            m_Transactions = new TransactionsClass();

            m_Transactions.InvokeAddMiscExpenseDlg();
        }

        private void AddMiscIncomebtn_Click(object sender, EventArgs e)
        {
            ITransactions m_Transactions;

            m_Transactions = new TransactionsClass();

            m_Transactions.InvokeAddMiscIncomeDlg();
        }

        private void EditMiscExpensebtn_Click(object sender, EventArgs e)
        {
            ITransactions m_Transactions;

            m_Transactions = new TransactionsClass();

            m_Transactions.InvokeEditMiscExpenseDlg();
        }

        private void EditMiscIncomebtn_Click(object sender, EventArgs e)
        {
            ITransactions m_Transactions;

            m_Transactions = new TransactionsClass();

            m_Transactions.InvokeEditMiscIncomeDlg();
        }

        private void EditTransactionbtn_Click(object sender, EventArgs e)
        {
            ITransactions m_Transactions;

            m_Transactions = new TransactionsClass();

            m_Transactions.InvokeEditTransactionDlg();
        }

        private void CancelTransactionbtn_Click(object sender, EventArgs e)
        {
            ITransactions m_Transactions;

            m_Transactions = new TransactionsClass();

            m_Transactions.InvokeCancelTransactionDlg();
        }

        private void AddTransactionbtn_Click(object sender, EventArgs e)
        {
            ITransactions m_Transactions;

            m_Transactions = new TransactionsClass();

            m_Transactions.InvokeAddTransactionDlg();
        }
    }
}