using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOfDucks.ServiceReference;

namespace RentOfDucks
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            sp = new SupportOperations();
        }
        SupportOperations sp;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (sp.Price(dTP_DateExpiration.Value, dTP_DateBeginning.Value, numUpDown_Red.Value, numUpDown_Green.Value, numUpDown_Black.Value, lbl_PriceRed.Text, lbl_PriceGreen.Text, lbl_PriceBlack.Text) > 0)
            {
                Service1Client service = new Service1Client();

                Orders o = new Orders();
                o.date_beginning = dTP_DateBeginning.Value;
                o.date_expiration = dTP_DateExpiration.Value;
                o.price = sp.Price(dTP_DateExpiration.Value, dTP_DateBeginning.Value, numUpDown_Red.Value, numUpDown_Green.Value, numUpDown_Black.Value, lbl_PriceRed.Text, lbl_PriceGreen.Text, lbl_PriceBlack.Text);
                o.number_red_duck = Convert.ToInt64(numUpDown_Red.Value);
                o.number_green_duck = Convert.ToInt64(numUpDown_Green.Value);
                o.number_black_duck = Convert.ToInt64(numUpDown_Black.Value);

                bool d_red_ok = false,
                     d_green_ok = false,
                     d_black_ok = false;

                if (cBx_Red.Checked)
                {
                    Ducks d_red = new Ducks();
                    d_red.id_duck = 1;
                    d_red.number_in_stock = Convert.ToInt64(lbl_InStockRed.Text) - Convert.ToInt64(numUpDown_Red.Value);
                    long duck_leased = sp.DucksLeased(1);
                    d_red.number_leased = duck_leased + Convert.ToInt64(numUpDown_Red.Value);
                    service.UpdateDuck(d_red);
                    d_red_ok = true;
                }

                if (cBx_Green.Checked)
                {
                    Ducks d_green = new Ducks();
                    d_green.id_duck = 2;
                    d_green.number_in_stock = Convert.ToInt64(lbl_InStockGreen.Text) - Convert.ToInt64(numUpDown_Green.Value);
                    long duck_leased = sp.DucksLeased(2);
                    d_green.number_leased = duck_leased + Convert.ToInt64(numUpDown_Green.Value);
                    service.UpdateDuck(d_green);
                    d_green_ok = true;
                }

                if (cBx_Black.Checked)
                {
                    Ducks d_black = new Ducks();
                    d_black.id_duck = 3;
                    d_black.number_in_stock = Convert.ToInt64(lbl_InStockBlack.Text) - Convert.ToInt64(numUpDown_Black.Value);
                    long duck_leased = sp.DucksLeased(3);
                    d_black.number_leased = duck_leased + Convert.ToInt64(numUpDown_Black.Value);
                    service.UpdateDuck(d_black);
                    d_black_ok = true;
                }
                
                if (service.InsertOrder(o) == 1)
                {
                    OrderDuck od = new OrderDuck();

                    if (d_red_ok)
                    {
                        od.id_order = service.MaxOrderId();
                        od.id_duck = 1;

                        service.InsertOrderDuck(od);
                    }

                    if (d_green_ok)
                    {
                        od.id_order = service.MaxOrderId();
                        od.id_duck = 2;

                        service.InsertOrderDuck(od);
                    }

                    if (d_black_ok)
                    {
                        od.id_order = service.MaxOrderId();
                        od.id_duck = 3;

                        service.InsertOrderDuck(od);
                    }

                    MessageBox.Show("Заказ добавлен.");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Заказ составлен неверно.");
            }            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            ClearForm();

            DialogResult = DialogResult.Cancel;
        }

        private void cBx_Red_CheckedChanged(object sender, EventArgs e)
        {
            if (cBx_Red.Checked)
            {
                cBx_Black.Enabled = false;
                numUpDown_Red.Enabled = true;
                numUpDown_Red.Value = 1;
                numUpDown_Red.Minimum = 1;
            }
            else
            {
                cBx_Black.Enabled = true;
                numUpDown_Red.Enabled = false;
                numUpDown_Red.Minimum = 0;
                numUpDown_Red.Value = 0;
            }                
        }

        private void cBx_Black_CheckedChanged(object sender, EventArgs e)
        {
            if (cBx_Black.Checked)
            {
                cBx_Red.Enabled = false;
                numUpDown_Black.Enabled = true;
                numUpDown_Black.Value = 1;
                numUpDown_Black.Minimum = 1;
            }                
            else
            {
                cBx_Red.Enabled = true;
                numUpDown_Black.Enabled = false;
                numUpDown_Black.Minimum = 0;
                numUpDown_Black.Value = 0;
            }                
        }
        

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ClearForm();            

            for (int i = 1; i<=3; i++)
            {
                Ducks d = new Ducks()
                {
                    id_duck = i
                };

                Service1Client service = new Service1Client();
                if (i == 1)
                {
                    lbl_InStockRed.Text = service.GetDucksInStock(d).ToString();
                    lbl_PriceRed.Text = service.GetDucksPrice(d).ToString();
                }
                    
                if (i == 2)
                {
                    lbl_InStockGreen.Text = service.GetDucksInStock(d).ToString();
                    lbl_PriceGreen.Text = service.GetDucksPrice(d).ToString();
                }                    
                if (i == 3)
                {
                    lbl_InStockBlack.Text = service.GetDucksInStock(d).ToString();
                    lbl_PriceBlack.Text = service.GetDucksPrice(d).ToString();
                }                   
            }

            numUpDown_Red.Maximum = Convert.ToDecimal(lbl_InStockRed.Text);
            numUpDown_Green.Maximum = Convert.ToDecimal(lbl_InStockGreen.Text);
            numUpDown_Black.Maximum = Convert.ToDecimal(lbl_InStockBlack.Text);
        }        

        private void btn_UpdatePreliminary_Click(object sender, EventArgs e)
        {
            decimal n = numUpDown_Red.Value + numUpDown_Green.Value + numUpDown_Black.Value;
            lbl_Number_All_Duck_Value.Text = n.ToString();
            lbl_All_Days_Value.Text = sp.Count_Days(dTP_DateExpiration.Value, dTP_DateBeginning.Value).ToString();
            lbl_Price_Result_Value.Text = sp.Price(dTP_DateExpiration.Value, dTP_DateBeginning.Value, numUpDown_Red.Value, numUpDown_Green.Value, numUpDown_Black.Value, lbl_PriceRed.Text, lbl_PriceGreen.Text, lbl_PriceBlack.Text).ToString();
        }

        private void cBx_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (cBx_Green.Checked)
            {
                numUpDown_Green.Enabled = true;
                numUpDown_Green.Value = 1;
                numUpDown_Green.Minimum = 1;
            }
            else
            {
                numUpDown_Green.Enabled = false;
                numUpDown_Green.Minimum = 0;
                numUpDown_Green.Value = 0;
            }
        }

        private void ClearForm()
        {
            cBx_Red.Checked = cBx_Green.Checked = cBx_Black.Checked = 
            numUpDown_Red.Enabled = numUpDown_Green.Enabled = numUpDown_Black.Enabled = false;

            numUpDown_Red.Value = numUpDown_Green.Value = numUpDown_Black.Value = 0;

            lbl_PriceRed.Text = lbl_PriceGreen.Text = lbl_PriceBlack.Text = 
            lbl_InStockRed.Text = lbl_InStockGreen.Text = lbl_InStockBlack.Text = 
            lbl_Number_All_Duck_Value.Text = lbl_All_Days_Value.Text = lbl_Price_Result_Value.Text = "-";

            dTP_DateBeginning.MinDate = DateTime.Today.AddDays(1);
            dTP_DateExpiration.MinDate = DateTime.Today.AddDays(2);
        }
    }
}
