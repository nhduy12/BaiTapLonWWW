using MyDatabase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void Form1_LoadAsync(object sender, EventArgs e)
        {
            var url = @"http://localhost:60990/api/";

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(url);
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                ////GET Method  
                //var responseTask = await client.GetAsync("api/Department/1");

                //if (responseTask.IsSuccessStatusCode)
                //{
                //    var sv = await responseTask.Content.ReadAsAsync<List<SinhVien>>();


                //}
                    
            }
        }
    }
}
