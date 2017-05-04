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
    public partial class MainForm : Form
    {
        private ITransport testee;
        public MainForm()
        {
            InitializeComponent();
            InitLists();
            dTPTime.Format = DateTimePickerFormat.Custom;
            dTPTime.CustomFormat = "dd.MM.yyyy | HH:mm"; 
        }

        private void Search_Click(object sender, EventArgs e)
        {           
            if (Vontb.Text == "" || Nachtb.Text == "")
                {
                   LabelFehler.Visible = true;
                }
                    else
                    {
                LVverbindung.Items.Clear();
                        String inputTime = dTPTime.Text;
                        var date = DateTime.Parse(inputTime.Substring(0, 10));
                        String formatDate = date.ToString("yyyy-MM-dd");
                        String time = inputTime.Substring(12, 6);

                        testee = new Transport();
                        var connections = testee.GetConnections(Vontb.Text, Nachtb.Text);

                        for(int i = 0; i < connections.ConnectionList.Count; i++)
                        {
                            Connection result = connections.ConnectionList[i];

                            ConnectionPoint from = result.From;
                            ConnectionPoint to = result.To;

                            FahrplanVerbindungen verbindung = new FahrplanVerbindungen(from, to, result);

                            var item = new ListViewItem(new[] { verbindung.getStartStation(), verbindung.getEndStation(), verbindung.getDeparture(), verbindung.getArrival(), verbindung.getDuration() });

                            LVverbindung.Items.Add(item);
                            LVverbindung.Bounds = new Rectangle(new Point(30, 280), new Size(630, 200));
                    
                                                                          
                        }
                    Vontb.Clear();
                    Nachtb.Clear();
                }
            }
        private void InitLists()
        {
            LVverbindung.View = View.Details;
            LVverbindung.Columns.Add("Von:", 140, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Abfahrt:", 120, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Nach:", 140, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Ankunft:", 120, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Dauer:", 100, HorizontalAlignment.Left);
        }
           
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = comboBox1.Text;

            var stations = testee.GetStations(input);

            foreach (Station stationName in stations.StationList)
            {
                comboBox1.Items.Add(stationName.Name);
            }
            this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    } 
}
