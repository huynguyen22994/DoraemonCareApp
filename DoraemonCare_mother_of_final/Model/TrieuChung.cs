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
    class TrieuChung
    {
        private string trieuchung1, trieuchung2;

        public string TrieuChung1
        {
            get { return trieuchung1; }
            set { trieuchung1 = value; }
        }

        public string TrieuChung2
        {
            get { return trieuchung2; }
            set { trieuchung2 = value; }
        }
    }
}