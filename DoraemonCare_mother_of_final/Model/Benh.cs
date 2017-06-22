using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DoraemonCare_mother_of_final.Model
{
    class Benh
    {
        private string tenbenh, bieuhien;
        public TrieuChung TrieuChung { get; set; }

        public string TenBenh
        {
            get { return tenbenh; }
            set { tenbenh = value; }
        }

        public string BieuHien
        {
            get { return bieuhien; }
            set { bieuhien = value; }
        }
    }
}