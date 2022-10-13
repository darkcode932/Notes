//using Android.Graphics.Drawables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    internal class Note

    {
        public String Filename { get; set; }
        public String Title { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public String Format { get; set; } = "yyyy-MM-dd";
        public String Text { get; set; }

        public ImageButton Rating { get; set; }
    }
}
