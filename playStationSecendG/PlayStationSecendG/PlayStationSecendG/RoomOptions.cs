using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayStationSecendG
{
    public partial class RoomOptions : Form
    {

        #region var
        int h, m, s;
        int cost;
        int totalDrink;
        public string type;
        User user;
        Timer time;
        Room room;
        Datils datils;
        Product[] productsList = new Product[10];
        ArrayList arrayname = new ArrayList();
        ArrayList arraynumber = new ArrayList();
        ArrayList arraytotalcost = new ArrayList();
        RoomPage roomPage;
        RoomDat roomdat;
        int roomNumber; 
        #endregion
        public RoomOptions()
        {
            InitializeComponent();
            time = new Timer();
        }

        public RoomOptions(int roomNum)
        {
            InitializeComponent();
            time = new Timer();
            roomNumber = roomNum;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rid_single.Checked || rid_multi.Checked)
            {
                if (open.Checked)
                {
                    timer1.Start();
                    btnPause.Enabled = true;
                    btnStop.Enabled = true;
                    btnStart.Enabled = false;
                    panelDrink.Enabled = true;
                    datils = new Datils();
                    roomdat.datils.start_time = DateTime.Now.ToString();
                    roomdat.room = new Room(); //-get room datils or hour cost-//
                    switch (roomNumber)
                    {
                        case 1:
                            RoomPage.lblStute1.Text = "غير متاح  ";
                            RoomPage.lblStute1.ForeColor = Color.Red;
                            break;
                        case 2:
                            RoomPage.lblStute2.Text = "غير متاح";
                            RoomPage.lblStute2.ForeColor = Color.Red;
                            break;
                        case 3:
                            RoomPage.lblStute3.Text = "غير متاح";
                            RoomPage.lblStute3.ForeColor = Color.Red;
                            break;
                        case 4:
                            RoomPage.lblStute4.Text = "غير متاح";
                            RoomPage.lblStute4.ForeColor = Color.Red;
                            break;
                        case 5:
                            RoomPage.lblStute5.Text = "غير متاح";
                            RoomPage.lblStute5.ForeColor = Color.Red;
                            break;
                        case 6:
                            RoomPage.lblStute6.Text = "غير متاح";
                            RoomPage.lblStute6.ForeColor = Color.Red;
                            break;
                        case 7:
                            RoomPage.lblStute7.Text = "غير متاح";
                            RoomPage.lblStute7.ForeColor = Color.Red;
                            break;
                        case 8:
                            RoomPage.lblStute8.Text = "غير متاح";
                            RoomPage.lblStute8.ForeColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    timer1.Start();
                    h = (int)setHours.Value;
                    m = (int)setMinutes.Value;
                    btnPause.Enabled = true;
                    btnStop.Enabled = true;
                    btnStart.Enabled = false;
                    panelDrink.Enabled = true;
                    datils = new Datils();
                    roomdat.datils.start_time = DateTime.Now.ToString();
                    roomdat.room = new Room(); //-get room datils or hour cost-//
                    roomdat.datils.user = new User();
                    roomdat.datils.customer = new Customer();
                    switch (roomNumber)
                    {
                        case 1:
                            RoomPage.lblStute1.Text = "غير متاح  ";
                            RoomPage.lblStute1.ForeColor = Color.Red;
                            break;
                        case 2:
                            RoomPage.lblStute2.Text = "غير متاح";
                            RoomPage.lblStute2.ForeColor = Color.Red;
                            break;
                        case 3:
                            RoomPage.lblStute3.Text = "غير متاح";
                            RoomPage.lblStute3.ForeColor = Color.Red;
                            break;
                        case 4:
                            RoomPage.lblStute4.Text = "غير متاح";
                            RoomPage.lblStute4.ForeColor = Color.Red;
                            break;
                        case 5:
                            RoomPage.lblStute5.Text = "غير متاح";
                            RoomPage.lblStute5.ForeColor = Color.Red;
                            break;
                        case 6:
                            RoomPage.lblStute6.Text = "غير متاح";
                            RoomPage.lblStute6.ForeColor = Color.Red;
                            break;
                        case 7:
                            RoomPage.lblStute7.Text = "غير متاح";
                            RoomPage.lblStute7.ForeColor = Color.Red;
                            break;
                        case 8:
                            RoomPage.lblStute8.Text = "غير متاح";
                            RoomPage.lblStute8.ForeColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Single or Multi", "What is type ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void btnPuse_Click(object sender, EventArgs e)
        {

            if (btnPause.Text == "استمرار")
            {
                timer1.Start();
                btnPause.Text = "ايقاف";
                btnPause.Image = Image.FromFile(@"D:\playStation\ICON\pause (1).png");
                if(rid_multi.Checked)
                    roomdat.room.room_type="multi";

            }
            else
            {
                timer1.Stop();
                btnPause.Text = "استمرار";
                btnPause.Image = Image.FromFile(@"D:\playStation\ICON\pause-play (1).png");

            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            {
                time.ResetTime();
                timer1.Stop();
                lblTimer.Text = "00:00:00";
                if (btnPause.Text == "استمرار")
                    btnPause.Text = "ايقاف";
                btnPause.Image = Image.FromFile(@"D:\playStation\ICON\pause (1).png");
                btnPause.Enabled = false;
                btnStart.Enabled = false;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                switch (roomNumber)
                {
                    case 1:
                        RoomPage.lblStute1.Text = "متاح";
                        RoomPage.lblStute1.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom1.Text ="00:00:00";
                        break;
                    case 2:
                        RoomPage.lblStute2.Text = "متاح";
                        RoomPage.lblStute2.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom2.Text = "00:00:00";
                        break;
                    case 3:
                        RoomPage.lblStute3.Text = "متاح";
                        RoomPage.lblStute3.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom3.Text = "00:00:00";
                        break;
                    case 4:
                        RoomPage.lblStute4.Text = "متاح";
                        RoomPage.lblStute4.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom4.Text = "00:00:00";
                        break;
                    case 5:
                        RoomPage.lblStute5.Text = "متاح";
                        RoomPage.lblStute5.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom5.Text = "00:00:00";
                        break;
                    case 6:
                        RoomPage.lblStute6.Text = "متاح";
                        RoomPage.lblStute6.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom6.Text = "00:00:00";
                        break;
                    case 7:
                        RoomPage.lblStute7.Text = "متاح";
                        RoomPage.lblStute7.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom7.Text = "00:00:00";
                        break;
                    case 8:
                        RoomPage.lblStute8.Text = "متاح";
                        RoomPage.lblStute8.ForeColor = Color.Green;
                        RoomPage.lblTimerRoom8.Text = "00:00:00";
                        break;
                    default:
                        break;
                }
            }
            //---------------------------------------------------------------------------------------------------
            if (open.Checked)
            {
                h = 0;
                m = 0;
                s = 0;
                setHours.Value = 0;
                setMinutes.Value = 0;

            }
            else
            {
                h = 0;
                m = 0;
                s = 0;
                setHours.Value = 0;
                setMinutes.Value = 0;

            }
        }
        private void addTime_Click(object sender, EventArgs e)
        {
            int hoursToAdd = (int)setHours.Value;
            int minutesToAdd = (int)setMinutes.Value;

            // Add minutes first
            m += minutesToAdd;

            // Handle carry-over from minutes to hours
            if (m >= 60)
            {
                h += m / 60;
                m %= 60;
            }

            // Add hours
            h += hoursToAdd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lblTimer.Text != "00:00:00")
                MessageBox.Show("تحذير", "يجب انهاء الغرفة اولا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                this.Dispose();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (open.Checked)
                {
                    time.IncrementTime();
                    lblTimer.Text = time.GetFormattedTime();
                    switch (roomNumber)
                    {
                        case 1 :
                            RoomPage.lblTimerRoom1.Text = time.GetFormattedTime();
                            break;
                        case 2:
                            RoomPage.lblTimerRoom2.Text = time.GetFormattedTime();
                            break;
                        case 3:
                            RoomPage.lblTimerRoom3.Text = time.GetFormattedTime();
                            break;
                        case 4:
                            RoomPage.lblTimerRoom4.Text = time.GetFormattedTime();
                            break;
                        case 5:
                            RoomPage.lblTimerRoom5.Text = time.GetFormattedTime();
                            break;
                        case 6:
                            RoomPage.lblTimerRoom6.Text = time.GetFormattedTime();
                            break;
                        case 7:
                            RoomPage.lblTimerRoom7.Text = time.GetFormattedTime();
                            break;
                        case 8:
                            RoomPage.lblTimerRoom8.Text = time.GetFormattedTime();
                            break;
                        default:
                            break;
                    }
                    
                }
                else
                {
                    time.decrementTime(ref h, ref m, ref s);
                    lblTimer.Text = time.GetFormattedTime(ref h, ref m, ref s);
                    switch (roomNumber)
                    {
                        case 1:
                            RoomPage.lblTimerRoom1.Text = time.GetFormattedTime();
                            break;
                        case 2:
                            RoomPage.lblTimerRoom2.Text = time.GetFormattedTime();
                            break;
                        case 3:
                            RoomPage.lblTimerRoom3.Text = time.GetFormattedTime();
                            break;
                        case 4:
                            RoomPage.lblTimerRoom4.Text = time.GetFormattedTime();
                            break;
                        case 5:
                            RoomPage.lblTimerRoom5.Text = time.GetFormattedTime();
                            break;
                        case 6:
                            RoomPage.lblTimerRoom6.Text = time.GetFormattedTime();
                            break;
                        case 7:
                            RoomPage.lblTimerRoom7.Text = time.GetFormattedTime();
                            break;
                        case 8:
                            RoomPage.lblTimerRoom8.Text = time.GetFormattedTime();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //*************    ADD ITEM TO TOTAL COST     ****************
        private void btnAddItem_Click(object sender, EventArgs e)

        {
            string itemName = Drinkmenu1.Text.ToString();

            try
            {
                // Find the product in the productsList
                Product selectedProduct = null;
                foreach (Product product in productsList)
                {
                    if (product.product_name == itemName)
                    {
                        selectedProduct = product;
                        break;
                    }
                }

                if (selectedProduct != null)
                {
                    // Check if the product is already in the DataGridView
                    int rowIndex = -1;
                    for (int i = 0; i < drinkDatilsView.Rows.Count; i++)
                    {
                        if (drinkDatilsView.Rows[i].Cells[0].Value != null && drinkDatilsView.Rows[i].Cells[0].Value.ToString() == selectedProduct.product_name)
                        {
                            rowIndex = i;
                            break;
                        }
                    }
                    if (((int)numbrtOfItem.Value != 0))
                    {
                        if (rowIndex == -1)
                        {
                            // If the product is not in the DataGridView, add a new row
                            arrayname.Add(selectedProduct.product_name);
                            arraynumber.Add((int)numbrtOfItem.Value);
                            double costto = selectedProduct.product_cost * (int)numbrtOfItem.Value;
                            arraytotalcost.Add(costto);
                            drinkDatilsView.Rows.Add(selectedProduct.product_name, (int)numbrtOfItem.Value, costto);
                        }
                        else
                        {
                            // If the product is already in the DataGridView, update the quantity and cost
                            arraynumber[rowIndex] = int.Parse(arraynumber[rowIndex].ToString()) + (int)numbrtOfItem.Value;
                            arraytotalcost[rowIndex] = int.Parse(arraytotalcost[rowIndex].ToString()) + (selectedProduct.product_cost * (int)numbrtOfItem.Value);
                            drinkDatilsView.Rows[rowIndex].Cells[1].Value = arraynumber[rowIndex];
                            drinkDatilsView.Rows[rowIndex].Cells[2].Value = arraytotalcost[rowIndex];


                        }
                    }
                    // Update the total cost
                    totalDrink += selectedProduct.product_cost * (int)numbrtOfItem.Value;
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
