using Microsoft.Maui.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace MauiApp4;

public partial class MainPage : ContentPage
{

    int count = -1;
    int number = 0;
    DateTime dt = DateTime.Now;

    public MainPage()
    {
        InitializeComponent();
        Time_now.Text = dt.ToString("HH:mm");
        Time_now.IsEnabled = true;
        Time.IsEnabled = true;

    }

    

    private void Bt_show_Clicked(object sender, EventArgs e)
    {
        Procento2.IsVisible = true;
        Objem2.IsVisible = true;
        number++;
        count++;
        Grid.SetRow(Bt_man, 3);
        Grid.SetRow(Bt_woman, 3);
        Grid.SetRow(Time, 4);
        Grid.SetRow(Time_now, 4);
        Grid.SetRow(Entry_time, 4);
        Grid.SetRow(Entry_weight, 5);
        Grid.SetRow(Bt_vysledek, 6);
        Grid.SetRow(Border_konec, 7);
        Grid.SetRow(Border_Promile,7);
        Grid.SetRow(Bt_new, 8);

        if (number == 2)
        {
            Procento3.IsVisible = true;
            Objem3.IsVisible = true;
            Grid.SetRow(Bt_man, 4);
            Grid.SetRow(Bt_woman, 4);
            Grid.SetRow(Time, 5);
            Grid.SetRow(Time_now, 5);
            Grid.SetRow(Entry_time, 5);
            Grid.SetRow(Entry_weight, 6);
            Grid.SetRow(Bt_vysledek, 7);
            Grid.SetRow(Border_konec, 8);
            Grid.SetRow(Border_Promile, 8);
            Grid.SetRow(Bt_new, 9);

        }

        if (number == 3)
        {
            Procento4.IsVisible = true;
            Objem4.IsVisible = true;
            Grid.SetRow(Bt_man, 5);
            Grid.SetRow(Bt_woman, 5);
            Grid.SetRow(Time, 6);
            Grid.SetRow(Time_now, 6);
            Grid.SetRow(Entry_time, 6);
            Grid.SetRow(Entry_weight, 7);
            Grid.SetRow(Bt_vysledek, 8);
            Grid.SetRow(Border_konec, 9);
            Grid.SetRow(Border_Promile, 9);
            Grid.SetRow(Bt_new, 10);

        }

        if (number == 4)
        {
            Procento5.IsVisible = true;
            Objem5.IsVisible = true;
            Grid.SetRow(Bt_man, 6);
            Grid.SetRow(Bt_woman, 6);
            Grid.SetRow(Time, 7);
            Grid.SetRow(Time_now, 7);
            Grid.SetRow(Entry_time, 7);
            Grid.SetRow(Entry_weight, 8);
            Grid.SetRow(Bt_vysledek, 9);
            Grid.SetRow(Border_konec, 10);
            Grid.SetRow(Border_Promile, 10);
            Grid.SetRow(Bt_new, 11);

        }
    }

    private void Bt_vysledek_Clicked(object sender, EventArgs e)
    {
        Border_konec.IsVisible = true;
        double Hmotnost_alkoholu = ((((Convert.ToDouble(Procento1.Text))*(Convert.ToDouble(Objem1.Text))+(Convert.ToDouble(Procento2.Text))*(Convert.ToDouble(Objem2.Text))+(Convert.ToDouble(Procento3.Text))*(Convert.ToDouble(Objem3.Text))+(Convert.ToDouble(Procento4.Text))*(Convert.ToDouble(Objem4.Text))+(Convert.ToDouble(Procento5.Text))*(Convert.ToDouble(Objem5.Text)))*08)/1000);

        double Vaha = Convert.ToDouble(Entry_weight.Text);
        DateTime x = DateTime.Parse(Entry_time.Text);
        DateTime dt = DateTime.Now;


        if (Bt_man.IsEnabled == false)
        {
            double promile_muz = Hmotnost_alkoholu / (Vaha * 0.7);
            double strizlivost_muz = Hmotnost_alkoholu / (Vaha * 0.1);
            if (Time_now.IsEnabled == false)
            {
                DateTime dt_muz = dt.AddHours(strizlivost_muz);
                Label_konec.Text = dt_muz.ToString("HH:mm");
            }

            if (Time.IsEnabled == false)
            {
                Label_konec.Text = (x.AddHours(strizlivost_muz)).ToString("HH:mm");
            }
            Label_Promile.Text = Math.Round(promile_muz, 2).ToString() + " ‰";
        }

        if (Bt_woman.IsEnabled == false)
        {
            double promile_zena = Hmotnost_alkoholu / (Vaha * 0.6);
            double strizlivost_zena = Hmotnost_alkoholu / (Vaha *0.085);


            Label_Promile.Text = Math.Round(promile_zena, 2).ToString() + " ‰";
            Label_konec.Text = (x.AddHours(strizlivost_zena)).ToString("HH:mm");

            if (Time.IsEnabled == false)
            {
                Label_konec.Text = (x.AddHours(strizlivost_zena)).ToString("HH:mm");
            }
            Label_Promile.Text = Math.Round(promile_zena, 2).ToString() + " ‰";
        }

        Border_konec.IsVisible = true;
        Border_Promile.IsVisible = true;
        Bt_new.IsVisible = true;
    }

    private void Bt_woman_Clicked(object sender, EventArgs e)
    {
        Bt_woman.IsEnabled = false;
        Bt_man.IsEnabled = true;
    }

    private void Bt_man_Clicked(object sender, EventArgs e)
    {
        Bt_man.IsEnabled = false;
        Bt_woman.IsEnabled = true;
    }


    private void Time_now_Clicked(object sender, EventArgs e)
    {
        Time_now.IsEnabled = false;
        Time.IsEnabled = true;
        Entry_time.IsEnabled = false;

        if (Time_now.IsEnabled == false)
        {
            Entry_time.IsVisible = false;
            Time.IsVisible = true;

            //Grid.SetRow(Bt_vysledek, 5);
            //Grid.SetColumn(Bt_vysledek, 3);
            //Grid.SetRow(Label_Promile, 6);
            //Grid.SetRow(Label_konec, 6);
            //Grid.SetRow(Bt_new, 6);

        }

        if (string.IsNullOrEmpty(Entry_time.Text))
        {
            Entry_time.Text = "0:00";
        }
    }

    private void Time_Clicked(object sender, EventArgs e)
    {

        Time_now.IsEnabled = true;
        Time.IsEnabled = false;
        Entry_time.IsVisible = true;
        Entry_time.IsEnabled = true;
        Time.IsVisible = false;
        /*Grid.SetRow(Bt_vysledek, 6);
        Grid.SetColumn(Bt_vysledek, 0);
        Grid.SetColumnSpan(Bt_vysledek, 3);
        Grid.SetRow(Border_Promile, 7);
        Grid.SetRow(Border_konec, 7);
        Grid.SetRow(Bt_new, 7);
        R6.Height = 50;*/


        if (Time.IsEnabled == false)
        {
            Entry_time.Text = "";

        }


    }

    private void Bt_new_Clicked(object sender, EventArgs e)
    {
        Procento1.Text = string.Empty;
        Objem1.Text = string.Empty;
        Procento2.Text = string.Empty;
        Objem2.Text = string.Empty;
        Procento3.Text = string.Empty;
        Objem3.Text = string.Empty;
        Procento4.Text = string.Empty;
        Objem4.Text = string.Empty;
        Procento5.Text = string.Empty;
        Objem5 .Text = string.Empty;
        Entry_time.Text = string.Empty;
        Entry_weight.Text = string.Empty;
        Bt_man.IsEnabled = true;
        Bt_woman.IsEnabled = true;
        Time.IsEnabled = true;
        Time_now.IsEnabled = true;
        Bt_new.IsVisible = false;
        Border_konec.IsVisible = false;
        Border_Promile.IsVisible = false;

        if(Entry_time.IsVisible == true) 
        {
            Entry_time.IsVisible = false;
            //Grid.SetColumn(Bt_vysledek, 3);
            //Grid.SetRow(Bt_vysledek, 5);
            Time.IsVisible = true;
        }
    }
}


