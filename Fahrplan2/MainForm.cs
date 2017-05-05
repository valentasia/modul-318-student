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
        private ITransport transport;
        private bool needAutoCompleteUpdate = false;
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

        public MainForm()
        {
            InitializeComponent();
            Tabelle(); // Tabelle laden
            transport = new Transport(); 
            dTPTime.Format = DateTimePickerFormat.Custom;  
            dTPTime.CustomFormat = "dd.MM.yyyy | HH:mm"; // Datumsformat angepasst
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (Vontb.Text == "" || Nachtb.Text == "")
            {
                LabelFehler.Visible = true; // Fehlermeldung anzeigen lassen
            }
            else
            {
                LVverbindung.Items.Clear(); // Tabelle leeren

                String inputTime = dTPTime.Text;
                var date = DateTime.Parse(inputTime.Substring(0, 10));
                String formatDate = date.ToString("yyyy-MM-dd");
                String time = inputTime.Substring(12, 6); // Datum und Uhrzeit formatieren 

                var connections = transport.GetConnections(Vontb.Text, Nachtb.Text, formatDate, time);

                for (int i = 0; i < connections.ConnectionList.Count; i++)
                {
                    Connection result = connections.ConnectionList[i];

                    ConnectionPoint from = result.From;
                    ConnectionPoint to = result.To;

                    FahrplanVerbindungen verbindung = new FahrplanVerbindungen(from, to, result);

                    var item = new ListViewItem(new[] { verbindung.getStartStation(), verbindung.getEndStation(), verbindung.getDeparture(), verbindung.getArrival(), verbindung.getDuration() });

                    LVverbindung.Items.Add(item); // Datensätze zur Fahrplan hinzufügen  
                }
                LabelFehler.Visible = false;
            }
        }
        private void Tabelle()
        {   
            // Tabelle Fahrplan
            LVverbindung.View = View.Details;
            LVverbindung.Columns.Add("Von:", 140, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Nach:", 120, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Abfahrt:", 140, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Ankunft:", 120, HorizontalAlignment.Left);
            LVverbindung.Columns.Add("Dauer:", 100, HorizontalAlignment.Left);

            // Tabelle Abfahrtstafel
            LVtafel.View = View.Details;
            LVtafel.Columns.Add("Abfahrt:", 120, HorizontalAlignment.Left);
            LVtafel.Columns.Add("Nummer:", 90, HorizontalAlignment.Left);
            LVtafel.Columns.Add("Von:", 130, HorizontalAlignment.Left);
            LVtafel.Columns.Add("Nach:", 130, HorizontalAlignment.Left);
        }

        private void SearchButton2_Click(object sender, EventArgs e)
        {
            LVtafel.Items.Clear();

            if (Stationtb.Text == "")
            {
                LabelFehler3.Visible = true; // Fehlermeldung anzeigen lassen
            }
            else
            {
                transport = new Transport();
                Stations stations = transport.GetStations(Stationtb.Text);
                Station station = stations.StationList[0];
                String id = station.Id;

                StationBoardRoot stationBoard = transport.GetStationBoard(Stationtb.Text, id);

                foreach (StationBoard entries in stationBoard.Entries)
                {
                    var item = new ListViewItem(new[] { entries.Stop.Departure.ToString(), entries.Name, station.Name, entries.To });
                    LVtafel.Items.Add(item); // Datensätze zur Abfahrtstafel hinzufügen 
                }
                Stationtb.Clear();
                LabelFehler3.Visible = false; 
            }


        }

        private void karte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Stations stations = transport.GetStations(Vontb.Text);

            if (stations.StationList.Count > 0)
            {
                Station station = stations.StationList[0];
                System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + station.Name + " Haltestelle"); // Zeigt die Haltestelle bei Google Maps an
            }
            else
            {
                LabelFehler.Visible = true; // Fehlermeldung anzeigen lassen
            }
        }

        private void karte2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stations stations = transport.GetStations(Nachtb.Text);

            if (stations.StationList.Count > 0)
            {
                Station station = stations.StationList[0];
                System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + station.Name + " Haltestelle"); // Zeigt die Haltestelle bei Google Maps an
            }
            else
            {
                LabelFehler.Visible = true; // Fehlermeldung anzeigen lassen
            }
        }

       

        private void Switch_Click(object sender, EventArgs e)
        {
            String input1 = Vontb.Text;
            String input2 = Nachtb.Text;

            Nachtb.Text = input1;
            Vontb.Text = input2;
        }

        private void Vontb_TextChanged(object sender, EventArgs e)
        {
            {
                if (AutoCom.Checked)
                {

                    var input = Vontb.Text;

                    if (input.Length > 3)
                    {
                        needAutoCompleteUpdate = true;
                    }
                    else
                    {
                        needAutoCompleteUpdate = false;
                    }
                    if (needAutoCompleteUpdate)
                    {
                        var stations = transport.GetStations(input);

                        foreach (Station stationName in stations.StationList)
                        {
                            Vontb.AutoCompleteCustomSource.Add(stationName.Name);
                        }
                        this.Vontb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        this.Vontb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        this.Vontb.AutoCompleteCustomSource = autoComplete;
                    }
                }
                else
                {
                    this.Vontb.AutoCompleteMode = AutoCompleteMode.None;
                }
            }

        }

        private void Nachtb_TextChanged(object sender, EventArgs e)
        {
            {
                if (AutoCom.Checked)
                {

                    var input = Nachtb.Text;

                    if (input.Length >= 3)
                    {
                        needAutoCompleteUpdate = true;
                    }
                    else
                    {
                        needAutoCompleteUpdate = false;
                    }
                    if (needAutoCompleteUpdate)
                    {
                        var stations = transport.GetStations(input);

                        foreach (Station stationName in stations.StationList)
                        {
                            Nachtb.AutoCompleteCustomSource.Add(stationName.Name);
                        }
                        this.Nachtb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        this.Nachtb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        this.Nachtb.AutoCompleteCustomSource = autoComplete;
                    }
                }
                else
                {
                    this.Nachtb.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }
    }
 }

