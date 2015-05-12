using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentYearlyCostCalculatorApp
{
    public partial class YearlyCostCalculatorUI : Form
    {
        public YearlyCostCalculatorUI()
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                classesComboBox.Items.Add("Class "+i); 
            }
            
        }

        List<double> admissionFeeList = new List<double>()
        {
            10000,
            10000,
            10000,
            10000,
            10000,
            12000,
            12000,
            12000,
            15000,
            15000,
            15000,
            15000,

        };

        List<double> monthlyFeeList = new List<double>()
        {
            500,
            500,
            1000,
            1000,
            1000,
            1500,
            1500,
            1500,
            2000,
            2000,
            2700,
            2700,

        };

        //Dictionary<string,double> admissionFeeDictionary = new Dictionary<string, double>()
        //{
        //    {"Class 1",10000},
        //    {"Class 2",10000},
        //    {"Class 3",10000},
        //    {"Class 4",10000},
        //    {"Class 5",10000},
        //    {"Class 6",12000},
        //    {"Class 7",12000},
        //    {"Class 8",12000},
        //    {"Class 9",15000},
        //    {"Class 10",15000},
        //    {"Class 11",15000},
        //    {"Class 12",15000},
        //};
        //Dictionary<string, double> monthlyFeeDictionary = new Dictionary<string, double>()
        //{
        //    {"Class 1",500},
        //    {"Class 2",500},
        //    {"Class 3",1000},
        //    {"Class 4",1000},
        //    {"Class 5",1000},
        //    {"Class 6",1500},
        //    {"Class 7",1500},
        //    {"Class 8",1500},
        //    {"Class 9",2000},
        //    {"Class 10",2000},
        //    {"Class 11",2700},
        //    {"Class 12",2700},
        //};



        private void totalAmountCalculateButton_Click(object sender, EventArgs e)
        {
            if (classesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class . ");
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    if (classesComboBox.SelectedIndex == i)
                    {
                        double totalAmount = admissionFeeList[i] + (monthlyFeeList[i] * 12);
                        if (discountCheckBox.Checked == true)
                        {

                            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                        }
                        else
                        {

                            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                        }
                    }
                }


                //if (classesComboBox.SelectedIndex == 0)
                //{
                //    double totalAmount = admissionFeeList[0] + (monthlyFeeList[0]*12);
                //    if (discountCheckBox.Checked == true)
                //    {

                //        double totalAmountWithDiscount = totalAmount - (totalAmount*5)/100;
                //        MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //    }
                //    else
                //    {

                //        MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //    }


                //}

                //    if (classesComboBox.SelectedIndex == 1)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 2"] + (monthlyFeeDictionary["Class 2"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 2)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 3"] + (monthlyFeeDictionary["Class 3"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 3)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 4"] + (monthlyFeeDictionary["Class 4"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 4)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 5"] + (monthlyFeeDictionary["Class 5"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 5)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 6"] + (monthlyFeeDictionary["Class 6"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 6)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 7"] + (monthlyFeeDictionary["Class 7"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 7)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 8"] + (monthlyFeeDictionary["Class 8"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 8)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 9"] + (monthlyFeeDictionary["Class 9"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 9)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 10"] + (monthlyFeeDictionary["Class 10"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 10)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 11"] + (monthlyFeeDictionary["Class 11"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }

                //    if (classesComboBox.SelectedIndex == 11)
                //    {
                //        double totalAmount = admissionFeeDictionary["Class 12"] + (monthlyFeeDictionary["Class 12"] * 12);
                //        if (discountCheckBox.Checked == true)
                //        {

                //            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmountWithDiscount));
                //        }
                //        else
                //        {

                //            MessageBox.Show("Total amount for one year : " + Convert.ToString(totalAmount));
                //        }


                //    }
                //}

            }

        }


    }
}
