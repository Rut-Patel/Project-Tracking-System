/************************************
 * Name:- Rut Patel
 * NET DEVELOPMENT-II
 * Lab-1
 * 
**********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Program> ProjectList = new List<Program>();
        public MainWindow()
        {
            InitializeComponent();
                   
         }
        /// <summary>
        /// This event handlers take place takes place when the user clicks Create button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            //Declarations.
            string inputName = txtName.Text;
            int inputBudget;
            int inputSpent;
            int inputTime;
            string inputStatus = cmbStatus.Text;
            //Validating values
            if (inputName.Length > 0)
            {
                if (int.TryParse(txtBudget.Text, out inputBudget))
                {
                    if (int.TryParse(txtSpent.Text, out inputSpent))
                    {
                       
                        if (int.TryParse(txtTimeLeft.Text, out inputTime))
                        {
                                //Adding the data to the list.
                                Program project = new Program(txtName.Text, inputBudget, inputSpent, inputTime, inputStatus);
                                ProjectList.Add(project);
                                lstProjectList.Items.Add(project.ProjectName);
                                resetFields(); //After Creating project reseting the fields.
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid Hours Value");
                            txtTimeLeft.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Spent Value");
                        txtSpent.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid Budget Value");
                    txtBudget.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter Project Name");
                txtName.Focus();
            }
            

        }
        /// <summary>
        /// Function that resets the elements of the form.
        /// </summary>
        public void resetFields()
        {
            txtBudget.Text = "";
            txtName.Text = "";
            txtSpent.Text = "";
            txtTimeLeft.Text = "";
            cmbStatus.SelectedIndex = 0;
        }
       /// <summary>
       /// This event takes place when user click the list view.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void ProjectList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            frmProjectInfo info = new frmProjectInfo();
           
            string outputName = info.txtOutName.Text;
            int outputBudget;
            int outputSpent;
            int outputTime;
            string outputStatus = info.cmbOutStatus.Text;


            outputName = ProjectList[lstProjectList.SelectedIndex].ProjectName;
            outputBudget = ProjectList[lstProjectList.SelectedIndex].Budget;
            outputSpent = ProjectList[lstProjectList.SelectedIndex].AmountSpent;
            outputTime = ProjectList[lstProjectList.SelectedIndex].HoursRemaining;
            outputStatus = ProjectList[lstProjectList.SelectedIndex].Status;

            info.Show();

        }

      
        
    }
}
