using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for frmProjectInfo.xaml
    /// </summary>
    public partial class frmProjectInfo : Window
    {
        public frmProjectInfo(List<Program> projectList)
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAlter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your Inforamtion has been Updated...");
            this.Close();
        }

        public string OutName
        {
            get { return txtOutName.Text; }
        }

        public string budget
        {
            get { return txtOutBudget.Text; }
        }

        public string spent
        {
            get { return txtOutSpent.Text; }
        }

        public string hour
        {
            get { return txtOutTimeLeft.Text; }
        }
        public string status
        {
            get { return cmbOutStatus.Text; }
        }

    }
}
