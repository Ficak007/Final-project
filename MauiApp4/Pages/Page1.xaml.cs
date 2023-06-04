namespace MauiApp4.Pages;

public partial class Page1 : ContentPage
{
    int number = 0;
    int Win = 0;
    int Lose = 0;
    int Game = 0;
    public Page1()
	{
        InitializeComponent();
        if (Game == 0)
        {
            Clear();
            
        }
    }

    private void Hra()
    {
        Random x = new Random();
        number =0;
        Game++;
        

        for (int i =x.Next(1,10); i>0;--i )
        {
            
            int y = x.Next(1,10);
            switch (y)
            {
                case 1: Beer1.IsVisible = true; 
                    break;
                case 2: Beer2.IsVisible = true;  
                    break;
                case 3: Beer3.IsVisible = true;
                    break;
                case 4: Beer4.IsVisible = true; 
                    break;
                case 5: Beer5.IsVisible = true; 
                    break;
                case 6: Beer6.IsVisible = true; 
                    break;
                case 7: Beer7.IsVisible = true;
                    break;
                case 8: Beer8.IsVisible = true; 
                    break;
                case 9: Beer9.IsVisible = true; 
                    break;
            }
        }
    }

    private void Clear()
    {
        Beer1.IsVisible = false;
        Beer2.IsVisible = false;
        Beer3.IsVisible = false;
        Beer4.IsVisible = false;
        Beer5.IsVisible = false;
        Beer6.IsVisible = false;
        Beer7.IsVisible = false;
        Beer8.IsVisible = false;
        Beer9.IsVisible = false;
        Entry_number.Text = "";
        Lb_win.Text=Win.ToString();
        Lb_lose.Text=Lose.ToString();
    }

    private void Bt_new_game_Clicked(object sender, EventArgs e)
    {
        
        Hra();
       Bt_new_game.IsEnabled = false;
        Bt_submit.IsEnabled = true;
    }

    private void Bt_submit_Clicked(object sender, EventArgs e)
    {
        
        
        

        if (Beer1.IsVisible==true)
        {
            number++;
        }
       
        if (Beer2.IsVisible==true)
        {
            number++;
        }
        
        if (Beer3.IsVisible==true)
        {
            number++;
        }
        
        if (Beer4.IsVisible==true)
        {
            number++;
        }
        
        if (Beer5.IsVisible==true)
        {
            number++;
        }
        
        if (Beer6.IsVisible==true)
        {
            number++;
        }
        
        if (Beer7.IsVisible==true)
        {
            number++;
        }
        
        if (Beer8.IsVisible==true)
        {
            number++;
        }
        
        if (Beer9.IsVisible==true)
        {
            number++;
        }

        if (Entry_number.Text==number.ToString())
        {
            Win++;
        }
        else
        {
            Lose++;
        }

        

        if (Game == 5)
        {

            if(Win>Lose)
            {
                DisplayAlert("Ještì to jde", "Klidnì pokraèuj", "OK");
                Clear();
            }

            if(Lose>Win)
            {
                DisplayAlert("Už jsi opilí", "Dej si pauzu", "OK");
                Clear();
            }
            Game =0;
            Win =0;
            Lose=0;
        }



        Clear();
        if(Game != 0)
        Hra();
        if (Game ==0)
        {
            Clear(); 
            Bt_new_game.IsEnabled = true;
        }
  
        

        

       
    }
}