using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Authenticator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            string version = AppInfo.VersionString;
            string build = AppInfo.BuildString;
            InitializeComponent();
            initalDisplay.Text = "Copyright 2018 Top Cat as Authenticator / Resolver for Identifiers == build " + version;
        }



    }
}
