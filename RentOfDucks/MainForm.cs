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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            fOrderForm = new OrderForm();
            fEditOrderForm = new EditOrderForm();
        }

        OrderForm fOrderForm;
        EditOrderForm fEditOrderForm;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            fOrderForm.ShowDialog();

            UpdateDataOrders();
            UpdateDataDucks();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                int n = dGV_Orders.CurrentRow.Index;
                fEditOrderForm.id_order = Convert.ToInt32(dGV_Orders.Rows[n].Cells[2].Value.ToString());

                fEditOrderForm.ShowDialog();
                UpdateDataOrders();
                UpdateDataDucks();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                int n = dGV_Orders.CurrentRow.Index;

                Orders o = new Orders();
                o.id_order = Convert.ToInt32(dGV_Orders.Rows[n].Cells[2].Value.ToString());
                o.number_red_duck = Convert.ToInt32(dGV_Orders.Rows[n].Cells[5].Value.ToString());
                o.number_green_duck = Convert.ToInt32(dGV_Orders.Rows[n].Cells[4].Value.ToString());
                o.number_black_duck = Convert.ToInt32(dGV_Orders.Rows[n].Cells[3].Value.ToString());

                OrderDuck od = new OrderDuck();
                od.id_order = Convert.ToInt32(dGV_Orders.Rows[n].Cells[2].Value.ToString());

                Ducks d = new Ducks();

                Service1Client service = new Service1Client();

                if (o.number_red_duck > 0)
                {
                    d.id_duck = 1;
                    d.number_in_stock = service.GetDucksInStock(d) + o.number_red_duck;
                    d.number_leased = service.GetDucksLeased(d) - o.number_red_duck;
                    service.UpdateDuck(d);
                }

                if (o.number_green_duck > 0)
                {
                    d.id_duck = 2;
                    d.number_in_stock = service.GetDucksInStock(d) + o.number_green_duck;
                    d.number_leased = service.GetDucksLeased(d) - o.number_green_duck;
                    service.UpdateDuck(d);
                }

                if (o.number_black_duck > 0)
                {
                    d.id_duck = 3;
                    d.number_in_stock = service.GetDucksInStock(d) + o.number_black_duck;
                    d.number_leased = service.GetDucksLeased(d) - o.number_black_duck;
                    service.UpdateDuck(d);
                }

                service.DeleteOrderDuck(od);
                service.DeleteOrder(o);              

                UpdateDataOrders();
                UpdateDataDucks();
            }
        }

        private void UpdateDataOrders()
        {
            Service1Client service = new Service1Client();

            dGV_Orders.DataSource = service.GetAllOrders();
            dGV_Orders.Columns["id_order"].Visible = false;

            dGV_Orders.Columns["id_order"].DisplayIndex = 0;
            dGV_Orders.Columns["date_beginning"].DisplayIndex = 1;
            dGV_Orders.Columns["date_expiration"].DisplayIndex = 2;
            dGV_Orders.Columns["price"].DisplayIndex = 3;
            dGV_Orders.Columns["number_red_duck"].DisplayIndex = 4;
            dGV_Orders.Columns["number_green_duck"].DisplayIndex = 5;
            dGV_Orders.Columns["number_black_duck"].DisplayIndex = 6;

            dGV_Orders.Columns["date_beginning"].HeaderText = "Дата начала";
            dGV_Orders.Columns["date_expiration"].HeaderText = "Дата окончания";
            dGV_Orders.Columns["price"].HeaderText = "Цена";
            dGV_Orders.Columns["number_red_duck"].HeaderText = "Количество красных уточек";
            dGV_Orders.Columns["number_green_duck"].HeaderText = "Количество зеленых уточек";
            dGV_Orders.Columns["number_black_duck"].HeaderText = "Количество черных уточек";

            dGV_Orders.Columns["date_beginning"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Orders.Columns["date_expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Orders.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Orders.Columns["number_red_duck"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Orders.Columns["number_green_duck"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Orders.Columns["number_black_duck"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void UpdateDataDucks()
        {
            Service1Client service = new Service1Client();

            dGV_Ducks.DataSource = service.GetAllDucks();
            dGV_Ducks.Columns["id_duck"].Visible = false;

            dGV_Ducks.Columns["id_duck"].DisplayIndex = 0;
            dGV_Ducks.Columns["color"].DisplayIndex = 1;
            dGV_Ducks.Columns["number_in_stock"].DisplayIndex = 2;
            dGV_Ducks.Columns["number_leased"].DisplayIndex = 3;
            dGV_Ducks.Columns["price"].DisplayIndex = 4;

            dGV_Ducks.Columns["color"].HeaderText = "Цвет";
            dGV_Ducks.Columns["number_in_stock"].HeaderText = "Есть в наличии";
            dGV_Ducks.Columns["number_leased"].HeaderText = "Количество арендованных";
            dGV_Ducks.Columns["price"].HeaderText = "Цена";

            dGV_Ducks.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Ducks.Columns["number_in_stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Ducks.Columns["number_leased"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_Ducks.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDataOrders();
            UpdateDataDucks();
        }
    }
}
