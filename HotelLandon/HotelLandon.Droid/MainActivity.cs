using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Views;
using Android;

namespace HotelLandon.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        /// <summary>
        /// Appelée à la création de votre activité.
        /// Initialise l'activité, charge les données, etc.
        /// </summary>
        /// <param name="savedInstanceState">Etat de sauvegarde lors de la dernière exécution de l'activité</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //Button button = new Button(this);
           // button.Text = "Android tu resteras !!";
            //this.AddContentView(button, new Android.Views.ViewGroup.LayoutParams(600, 200));

           // button.Click += Button_click;
            //button.LongClick += Button_Longclick;
           /* if((int)Build.VERSION.SdkInt >= 27)
            {

                if (CheckSelfPermission(Manifest.Permission.Internet)
                    != Android.Content.PM.Permission.Denied)
                {
                    RequestPermissions(new string[]
                    {
                        Manifest.Permission.Internet
                    }, 0);
                    Toast.MakeText(this, "Permission accordée par l'utilisateur", ToastLength.Short).Show();
                }
                Toast.MakeText(this, "Permission déja accordée", ToastLength.Long).Show();
            }*/
        }

       /* private void Button_Longclick(object sender, View.LongClickEventArgs e)
        {
            var clickedButton = (Button)sender;
            clickedButton.Text += "This is a long click";
        }

        private void Button_click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            clickedButton.Text += "#";
        }*/
     
    }
}