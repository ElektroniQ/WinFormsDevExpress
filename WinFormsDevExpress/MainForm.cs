using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDevExpress
{
    public partial class MainForm : Form
    {

        public class ExportDatabase : DataContext
        {
            public Table<ExportHistory> exportHistoryTable;
            public ExportDatabase(string connection) : base(connection) { }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var database = new ExportDatabase(ConfigurationManager.ConnectionStrings["ExportDB"].ConnectionString);

                var beginTime = ToValidDateTime(dateBegin.DateTime);
                var endTime = ToValidDateTime(dateEnd.DateTime);
                var place = inputPlace.Text;

                gridControl1.DataSource = GetFilteredExportHistory(database);
                gridControl1.RefreshDataSource();
            }
            catch(Exception except)
            {
                string message = "Błąd przy pobieraniu danych z bazy!\n\n" + except.ToString();
                string caption = "Błąd";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
        }

        private List<ExportHistory> GetFilteredExportHistory(ExportDatabase database)
        {
            var beginTime = ToValidDateTime(dateBegin.DateTime);
            var endTime = ToValidDateTime(dateEnd.DateTime);
            if(endTime == ToValidDateTime(new DateTime()))
            {
                endTime = DateTime.MaxValue;
            }

            var place = inputPlace.Text;

            return database.exportHistoryTable
                .Where(x => (x.Datetime >= beginTime))
                .Where(x => (x.Datetime <= endTime))
                .Where(x => place != "" ? (x.Place.IndexOf(place) >= 0) : true).ToList();
        }

        private DateTime ToValidDateTime(DateTime date)
        {
            DateTime minValue = (DateTime)SqlDateTime.MinValue;

            if (date < minValue)
            {
                return minValue;
            }
            else
            {
                return date;
            }
        }

        private void DateBegin_EditValueChanged(object sender, EventArgs e)
        {
            dateEnd.Properties.MinValue = dateBegin.DateTime;
        }

        private void DateEnd_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEnd.DateTime != DateTime.MinValue)
            {
                dateBegin.Properties.MaxValue = dateEnd.DateTime;
            }
            else
            {
                dateBegin.Properties.MaxValue = DateTime.MaxValue;
            }
        }
    }
}
