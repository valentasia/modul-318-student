using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan2
{
    public partial class Form1 : Form
    {
        private ITransport testee;
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                LabelFehler.Visible = true;
            }
            else
            {

                testee = new Transport();
                var connections = testee.GetConnections(textBox1.Text, textBox2.Text);

                foreach (var result in connections.ConnectionList)
                {
                    ConnectionPoint from = result.From;
                    ConnectionPoint to = result.To;

                    ListView LVverbindung = new ListView();
                    LVverbindung.Bounds = new Rectangle(new Point(30, 280), new Size(630, 200));

                    // Set the view to show details.
                    LVverbindung.View = View.Details;
                    // Allow the user to edit item text.
                    LVverbindung.LabelEdit = true;
                    // Allow the user to rearrange columns.
                    LVverbindung.AllowColumnReorder = true;
                    // Select the item and subitems when selection is made.
                    LVverbindung.FullRowSelect = true;
                    // Display grid lines.
                    LVverbindung.GridLines = true;
                    // Sort the items in the list in ascending order.
                    LVverbindung.Sorting = SortOrder.Ascending;

                    ListViewItem item1 = new ListViewItem(from.Station.Name, 0);
                    item1.SubItems.Add(validateDateTime(result.From.Departure));
                    item1.SubItems.Add(to.Station.Name);
                    item1.SubItems.Add(validateDateTime(result.To.Arrival));
                    item1.SubItems.Add(result.Duration);





                    LVverbindung.Columns.Add("Von:", 140, HorizontalAlignment.Left);
                    LVverbindung.Columns.Add("Abfahrt:", 120, HorizontalAlignment.Left);
                    LVverbindung.Columns.Add("Nach:", 140, HorizontalAlignment.Left);
                    LVverbindung.Columns.Add("Ankunft:", 120, HorizontalAlignment.Left);
                    LVverbindung.Columns.Add("Dauer:", 100, HorizontalAlignment.Left);

                    LVverbindung.Items.AddRange(new ListViewItem[] { item1 });

                    this.Controls.Add(LVverbindung);



                }



            }
        }

        private String validateDateTime(String time)
        {

            DateTimeOffset datetime = DateTimeOffset.Parse(time);
            String result = datetime.ToString();
            result = result.Split('+')[0];

            return result;


        }

        /*private string validateDuration(string duration)
        {
            int days = Convert.ToInt32(duration.Substring(0,6));
            int hours = Convert.ToInt32(duration.Substring(2,6));
            int min = Convert.ToInt32(duration.Substring(3,6));
        }
        */
        private void label2_Click(object sender, EventArgs e)
        {

        }
    } 
}
