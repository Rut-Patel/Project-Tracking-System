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
        /// This event Handler takes place when user clicks the item in list-box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectList_SelectionChanged(object sender, MouseButtonEventArgs e)
        {
            frmProjectInfo info = new frmProjectInfo(ProjectList);

            string outputName = ProjectList[lstProjectList.SelectedIndex].ProjectName;
            string outBudget = ProjectList[lstProjectList.SelectedIndex].Budget.ToString();
            string outputStatus = ProjectList[lstProjectList.SelectedIndex].Status;


            info.txtOutName.Text = outputName;
            info.txtOutBudget.Text = outBudget;
            string outSpent = ProjectList[lstProjectList.SelectedIndex].AmountSpent.ToString();
            info.txtOutSpent.Text = outSpent;
            string outHour = ProjectList[lstProjectList.SelectedIndex].HoursRemaining.ToString();
            info.txtOutTimeLeft.Text = outHour;
            info.cmbOutStatus.Text = outputStatus;

            info.ShowDialog();

            ProjectList[lstProjectList.SelectedIndex].ProjectName = info.OutName;
            ProjectList[lstProjectList.SelectedIndex].Budget = Convert.ToInt32(info.budget);
            ProjectList[lstProjectList.SelectedIndex].AmountSpent = Convert.ToInt32(info.spent);
            ProjectList[lstProjectList.SelectedIndex].HoursRemaining = Convert.ToInt32(info.hour);
            ProjectList[lstProjectList.SelectedIndex].Status = info.status;

        }
    }
}
