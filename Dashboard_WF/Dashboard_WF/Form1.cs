using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization; //Project
using System.Net; //Project
using Newtonsoft.Json; //Project

namespace Dashboard_WF
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            //getInfo(); Uncomment once I have some real code in there
        }

        public void getInfo()
        {
            //Here I should add the default or last location.
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //getInfo();
            string json = (new WebClient()).DownloadString("http://api.openweathermap.org/data/2.5/weather?id=6167863&appid=3f2635c452b15905dfc6b23c042f2a24");            
            var example2 = new JavaScriptSerializer().Deserialize<GetWeather>(json);
            lblTest.Text = example2.main.temp.ToString();
            
        }

        
    }
}
