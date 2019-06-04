using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDevExpress
{
    [Table(Name = "ExportHistory")]
    public class ExportHistory
    {
        public ExportHistory()
        {
            Datetime = new DateTime();
        }
        [Column(Name = "name")]
        public string Name { get; set; }
        [Column(Name = "date")]
        public DateTime Datetime { get; set; }

        public string Date
        {
            get
            {
                return Datetime.ToString("yyyy-MM-dd");
            }

            set
            {
                Datetime = DateTime.ParseExact(value, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        public string Time
        {
            get
            {
                return Datetime.ToString("HH:mm");
            }

            set
            {
                Datetime = DateTime.ParseExact(value, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        [Column(Name = "username")]
        public string User { get; set; }
        [Column(Name = "place")]
        public string Place { get; set; }
    }
}
