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
            Tabelle();
            testee = new Transport();
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
              
                        for (int i = 0; i < connections.ConnectionList.Count; i++)
                        {
                            Connection result = connections.ConnectionList[i];

                            ConnectionPoint from = result.From;
                            ConnectionPoint to = result.To;

                            FahrplanVerbindungen verbindung = new FahrplanVerbindungen(from, to, result);

                            var item = new ListViewItem(new[] { verbindung.getStartStation(), verbindung.getEndStation(), verbindung.getDeparture(), verbindung.getArrival(), verbindung.getDuration() });

                            LVverbindung.Items.Add(item);
                            
                                                                          
                        }
                    Vontb.Clear();
                    Nachtb.Clear();
                }
            }
        private void Tabelle()
        {
            LVverbindung.View = View.Details;
            LVverbindung.Columns.Add("Von:", 140, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Abfahrt:", 120, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Nach:", 140, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Ankunft:", 120, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Dauer:", 100, HorizontalAlignment.Left);

            LVtafel.View = View.Details;
            LVtafel.Columns.Add("Abfahrt:", 120, HorizontalAlignment.Left);
            LVtafel.Columns.Add("Katogerie:", 65, HorizontalAlignment.Left);
            LVtafel.Columns.Add("Name:", 50, HorizontalAlignment.Left);
            LVtafel.Columns.Add("Von:", 130, HorizontalAlignment.Left);
            LVtafel.Columns.Add("Nach:", 130, HorizontalAlignment.Left);
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            String eingabe =  ComboListe.Text;

            var stations =  testee.GetStations(eingabe);

            foreach (Station stationName in stations.StationList)
            {
                ComboListe.Items.Add(stationName.Name);
            }
        }

        private void Search2_Click(object sender, EventArgs e)
        {
            LVtafel.Items.Clear();

            testee = new Transport();
            Stations stations = testee.GetStations(Stationtb.Text);
            Station station = stations.StationList[0];
            String id = station.Id;

            StationBoardRoot stationBoard = testee.GetStationBoard(Stationtb.Text, id);

            foreach (StationBoard entries in stationBoard.Entries)
            {
                var item = new ListViewItem(new[] { entries.Stop.Departure.ToString(), entries.Category, entries.Name, station.Name, entries.To });
                LVtafel.Items.Add(item);
            }
            Stationtb.Clear();
        }

       
    } 
}
