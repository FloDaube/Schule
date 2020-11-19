using SEAL_FahrzeugVermietung.BLL;
using SEAL_FahrzeugVermietung.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEAL_FahrzeugVermietung
{
    public partial class MainForm : Form
    {

        SQL_Service service = new SQL_Service();

        public MainForm()
        {
            InitializeComponent();

            //#if Debug
            service.Server = "localhost";
            service.Database = "schule";
            service.User = "SAEL_DB_User";
            service.Password = "KdycUvcYfzYXdJ1YVBPi";
//#endif

            timer_LoadData.Enabled = true;
        }

        private void timer_LoadData_Tick(object sender, EventArgs e)
        {
            this.UseWaitCursor = false;
            timer_LoadData.Enabled = false;
            button_reservierungen_Click(sender, e);
            this.UseWaitCursor = false;
        }

        private void button_reservierungen_Click(object sender, EventArgs e)
        {
            listView_Main.Clear();

            listView_Main.Columns.Add(new ColumnHeader {Text = "Nummer" });
            listView_Main.Columns.Add(new ColumnHeader {Text = "Reserierungs Zweck", Width = 250 });
            listView_Main.Columns.Add(new ColumnHeader {Text = "Beginn",Width = 80});
            listView_Main.Columns.Add(new ColumnHeader {Text = "Ende", Width = 80 });
            listView_Main.Columns.Add(new ColumnHeader {Text = "Hersteller" });
            listView_Main.Columns.Add(new ColumnHeader {Text = "Modell" });
            listView_Main.Columns.Add(new ColumnHeader {Text = "Kennzeichen", Width = 100});

            var list = service.GetView_ResevirungsListe();
            if(list.Count() > 0)
            {
                foreach(View_Resevirung vr in list)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = vr.Id.ToString();
                    lv.Tag = vr.Id.ToString();
                    lv.SubItems.Add(vr.Zweck);
                    lv.SubItems.Add(vr.Beginn.ToString("MM/dd/yyyy"));
                    lv.SubItems.Add(vr.Ende.ToString("MM/dd/yyyy"));
                    lv.SubItems.Add(vr.Hersteller);
                    lv.SubItems.Add(vr.Modell);
                    lv.SubItems.Add(vr.Kennzeichen);

                    listView_Main.Items.Add(lv);
                }
            }
        }

        private void button_Fahrzeuge_Click(object sender, EventArgs e)
        {

            this.UseWaitCursor = true;
            listView_Main.Clear();

            listView_Main.Columns.Add(new ColumnHeader { Text = "ID" });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Kennzwichen", Width = 100 });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Hersteller" });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Modell" });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Kraftstoff" });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Verbrauch", Width = 70});
            listView_Main.Columns.Add(new ColumnHeader { Text = "Angeschaft Am", Width = 100 });
            listView_Main.Columns.Add(new ColumnHeader { Text = "Anschafungskosten", Width = 110 });

            var list = service.GetFahrzeugListe();

            if(list.Count() > 0)
            {
                foreach (Fahrzeug f in list)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = f.Id.ToString();
                    lv.Tag = f.Id.ToString();
                    lv.SubItems.Add(f.Kennzeichen);
                    lv.SubItems.Add(f.Hersteller);
                    lv.SubItems.Add(f.Modell);
                    lv.SubItems.Add(f.Kraftstoff);
                    lv.SubItems.Add(f.Verbrauch.ToString());
                    lv.SubItems.Add(f.AnschafungsDatum.ToString("MM/dd/yyyy"));
                    lv.SubItems.Add(f.AnschafungsKosten.ToString("C"));

                    listView_Main.Items.Add(lv);
                }
            }

            this.UseWaitCursor = false;
        }

        private void ItemAreClickt(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView_Main.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
