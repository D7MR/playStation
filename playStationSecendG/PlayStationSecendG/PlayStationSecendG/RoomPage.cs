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
    public partial class RoomPage : Form
    {
        RoomOptions roomOption1;
        RoomOptions roomOption2;
        RoomOptions roomOption3;
        RoomOptions roomOption4;
        RoomOptions roomOption5;
        RoomOptions roomOption6;
        RoomOptions roomOption7;
        RoomOptions roomOption8;
        public static List<Room> roomPrice = new List<Room>();

        public RoomPage()
        {
            InitializeComponent();
            roomOption1=new RoomOptions(1);
            roomOption2=new RoomOptions(2);
            roomOption3=new RoomOptions(3);
            roomOption4=new RoomOptions(4);
            roomOption5=new RoomOptions(5);
            roomOption6=new RoomOptions(6);
            roomOption7=new RoomOptions(7);
            roomOption8=new RoomOptions(8);

        }  
        private void btnRoom1_Click(object sender, EventArgs e)
        {

            try
            {

                roomOption1.Show();

              
            }
            catch
            {
                roomOption1 = new RoomOptions(1);
                roomOption1.Show();
            }
        }

        private void btnRoom2_Click(object sender, EventArgs e)
        {
            try
            {

                roomOption2.Show();

            }
            catch
            {
                roomOption2 = new RoomOptions(2);
                roomOption2.Show();
            }
        }

        private void btnRoom3_Click(object sender, EventArgs e)
        {
            try
            {

                roomOption3.Show();

            }
            catch
            {
                roomOption3 = new RoomOptions(3);
                roomOption3.Show();
            }
        }

        private void btnRoom4_Click(object sender, EventArgs e)
        {
            try
            {

                roomOption4.Show();

            }
            catch
            {
                roomOption4 = new RoomOptions(4);
                roomOption4.Show();
            }
        }

        private void btnRoom5_Click(object sender, EventArgs e)
        {
            try
            {

                roomOption5.Show();

            }
            catch
            {
                roomOption5 = new RoomOptions(5);
                roomOption5.Show();
            }
        }

        private void btnRoom6_Click(object sender, EventArgs e)
        {
            try
            {

                roomOption6.Show();

            }
            catch
            {
                roomOption6 = new RoomOptions(6);
                roomOption6.Show();
            }
        }

        private void btnRoom7_Click(object sender, EventArgs e)
        {
            try
            {

                roomOption7.Show();
                          
            }             
            catch         
            {             
                roomOption7 = new RoomOptions(7);
                roomOption7.Show();
            }
        }

        private void btnRoom8_Click(object sender, EventArgs e)
        {
            try
            {

                roomOption8.Show();

            }
            catch
            {
                roomOption8 = new RoomOptions(8);
                roomOption8.Show();
            }
        }

        private void LoadRoomData()
        {
            try
            {
                Connection dbConnection = new Connection();
                string query = "SELECT * FROM room";
                DataTable roomData = dbConnection.getTable(query);

                foreach (DataRow row in roomData.Rows)
                {
                    Room room = new Room
                    {
                        room_id = Convert.ToInt32(row["room_id"]),
                        room_number = Convert.ToInt32(row["room_number"]),
                        room_type = Convert.ToBoolean(row["room_type"]),
                        room_cost = Convert.ToDecimal(row["room_hourCost"])
                    };

                    roomPrice.Add(room);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
