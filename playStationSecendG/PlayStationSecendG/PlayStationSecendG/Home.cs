using System;
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
    public partial class Home : Form
    {
        #region var
        //fields
        private Button currentbutton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private RoomPage roomPage;
        private Cafe cafe;
        private PaymentPage payment;
        #endregion
        //constructor
        public Home()
        {
            InitializeComponent();
            random = new Random();
            btnCloseforms.Visible = false;
            roomPage= new RoomPage();
            cafe = new Cafe();
            payment = new PaymentPage();
        }
        //methods
        private  Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index=random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void activateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentbutton != (Button)btnSender)
                {
                    disableButton();
                    Color color = selectThemeColor();
                    currentbutton = (Button)btnSender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font= new System.Drawing.Font("Al-Mohanad Extra Bold", 18.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseforms.Visible = true;
                }
            }
        }

        private void disableButton()
        {
            foreach(Control previousBtn in panalMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(12, 125, 198);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Al-Mohanad Extra Bold", 14.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Hide();
            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(roomPage, sender);
            activateButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }


        private void Reset()
        {
            disableButton();
            lblTitle.Text = "رئسية";
            panelTitle.BackColor = Color.FromArgb(12, 125, 198);
            panelLogo.BackColor = Color.FromArgb(11, 115, 184);
            currentbutton = null;
            btnCloseforms.Visible = false;
        }

        private void btnCloseforms_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Hide();
            Reset();
        }



        private void btnPyment_Click(object sender, EventArgs e)
        {
            OpenChildForm(payment, sender);
            activateButton(sender);
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            OpenChildForm(cafe, sender);
            activateButton(sender);
        }
    }
    
}
