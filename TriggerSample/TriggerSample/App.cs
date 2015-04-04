using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TriggerSample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
    public class EntryValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int n;
            if (!Int32.TryParse(sender.Text, out n))
            {
                sender.TextColor = Color.Red;
            }
            else
            {
                sender.TextColor = Color.Blue;
            }
        }
    }

}
