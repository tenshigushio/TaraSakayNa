using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaraSakayNa
{

    
    public partial class MainPage : ContentPage
    {
        public IList<JeepneyCode> JeepneyCodes { get; private set; }
        
        public string a = "Alpha";
        public string b = "Bravo";
        public string c = "Charlie";
        public string d = "Delta";
        public string e = "Echo";
        public string f = "Foxtrot";
        public string g = "Golf";
        public string h = "Hotel";
        public string i = "India";
        public string j = "Juliet";
        public string k = "Kilo";
        public string l = "Lima";
        public string m = "Mike";
        public string n = "November";
        public string o = "Oscar";
        public string p = "Papa";
        public string q = "Quebec";
        public string r = "Romeo";

        public MainPage()
        {
            InitializeComponent();

            JeepneyCodes = new List<JeepneyCode>
            {
                new JeepneyCode
                {
                    Jcode = "01A",
                    Route = a + " <-> " + b + " <-> " + c + " <-> " + e + " <-> " + g,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "02B",
                    Route = a + " <-> " + c + " <-> " + d + " <-> " + f + " <-> " + g,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "03C",
                    Route = c + " <-> " + d + " <-> " + f + " <-> " + h + " <-> " + i,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "04A",
                    Route = c + " <-> " + d + " <-> " + e + " <-> " + f + " <-> " + j,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "04D",
                    Route = c + " <-> " + e + " <-> " + f + " <-> " + g + " <-> " + i,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "06B",
                    Route = d + " <-> " + h + " <-> " + j + " <-> " + k + " <-> " + l,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "06D",
                    Route = d + " <-> " + f + " <-> " + g + " <-> " + i + " <-> " + k,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "10C",
                    Route = f + " <-> " + g + " <-> " + h + " <-> " + i + " <-> " + j,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "10H",
                    Route = f + " <-> " + h + " <-> " + j + " <-> " + l + " <-> " + n,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "11A",
                    Route = f + " <-> " + g + " <-> " + k + " <-> " + n + " <-> " + m,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "11B",
                    Route = f + " <-> " + g + " <-> " + l + " <-> " + o + " <-> " + p,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "20A",
                    Route = i + " <-> " + j + " <-> " + n + " <-> " + p + " <-> " + r,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "20C",
                    Route = i + " <-> " + k + " <-> " + l + " <-> " + m + " <-> " + r,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "42C",
                    Route = j + " <-> " + k + " <-> " + l + " <-> " + m + " <-> " + o,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },

                new JeepneyCode
                {
                    Jcode = "42D",
                    Route = j + " <-> " + n + " <-> " + o + " <-> " + q + " <-> " + r,
                    ImageUrl = "https://cdn-icons-png.flaticon.com/512/1485/1485447.png"

                },
            };

            BindingContext = this;
        }

        public void SearchBar_textChanged(object sender, TextChangedEventArgs e)
        {
            var searchresults = JeepneyCodes.Where(value => value.Jcode.Contains(searchCode.Text));
            Jlist.ItemsSource = searchresults;

            
        }
    }
}
