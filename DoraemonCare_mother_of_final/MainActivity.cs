using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;
using System.Net;
using System.IO;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;
using RestSharp;
using DoraemonCare_mother_of_final.Model;

namespace DoraemonCare_mother_of_final
{
    [Activity(Label = "Doraemon Care", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static readonly List<string> phoneNumbers = new List<string>();
        private List<string> nItems;
        private ListView myListView;

        private ListView lv;
        private ArrayAdapter<string> adap;
        private SynchronizationContext sc;

        public class TrieuChung
        {
            public string TrieuChung1 { get; set; }
            public string TrieuCHung2 { get; set; }
        }
        public class RootObject
        {
            public string _id { get; set; }
            public string TenBenh { get; set; }
            public string BieuHien { get; set; }
            public TrieuChung TrieuChung { get; set; }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button btnChanDoan = FindViewById<Button>(Resource.Id.Button_Chandoan);
            Button test = FindViewById<Button>(Resource.Id.Button_Tracuu);

            lv = FindViewById<ListView>(Resource.Id.abc);
            adap = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line);
            adap.Add("chua co du lieu");
            adap.Add("sdfdsf");
            lv.Adapter = adap;

            sc = SynchronizationContext.Current;

            btnChanDoan.Click += laydulieu;

        }

        void laydulieu(object sender, System.EventArgs e)
        {
            getJSON();
        }

        private async void getJSON()
        {
            adap.Clear();

            IRestClient client = new RestClient("http://salty-journey-61143.herokuapp.com/api/benh");
            IRestRequest request = new RestRequest("/", Method.GET);

            try
            {
                await Task.Run(() =>
                {
                    IRestResponse<List<Benh>> response = client.Execute<List<Benh>>(request);
                    Console.Out.Write("acc: {0}", response.Content);
                    foreach(var benh in response.Data)
                    {
                        sc.Post(new SendOrPostCallback(o =>
                        {
                            adap.Add(o as string);
                            adap.NotifyDataSetChanged();
                            lv.Adapter = adap;
                        }), benh.TenBenh);
                    }
                });
            }
            catch (Exception e)
            {

                Console.Out.Write("error: {0}", e.Message);
            }
        }
    }
}

