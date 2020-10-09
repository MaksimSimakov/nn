using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace raspisanie
{
    public partial class MainPage : ContentPage
    {
        //BoxView box;
        Label  nomer1, nomer2, nomer3, nomer4, nomer5, nomer6, nomer7, nomer8, pon, vtor, sre, chet, pjat, uroki1, uroki2, uroki3, uroki4, uroki5, uroki6, uroki7, uroki8, uroki9, uroki10, uroki11, uroki12, uroki13, uroki14;
        //Frame frm, frm2;
        public MainPage()
        {
            Grid abs = new Grid();
            for (int i = 0; i < 6; i++)
            {
                abs.RowDefinitions.Add(new RowDefinition
                { Height = new GridLength(5, GridUnitType.Star) });
            }
            for (int j = 0; j < 3; j++)
            {
                abs.ColumnDefinitions.Add(new ColumnDefinition
                { Width = new GridLength(1, GridUnitType.Star) });
            }
            nomer1 = new Label { BackgroundColor = Color.White, Text = "\n \n 1" };
            abs.Children.Add(nomer1, 1, 0);
            nomer2 = new Label { BackgroundColor = Color.White, Text = "\n \n 2" };
            abs.Children.Add(nomer2, 2, 0);
            nomer3 = new Label { BackgroundColor = Color.White, Text = "\n \n 3" };
            abs.Children.Add(nomer3, 3, 0);
            nomer4 = new Label { BackgroundColor = Color.White, Text = "\n \n 4" };
            abs.Children.Add(nomer4, 4, 0);
            nomer5 = new Label { BackgroundColor = Color.White, Text = "\n \n 5" };
            abs.Children.Add(nomer5, 5, 0);
            nomer6 = new Label { BackgroundColor = Color.White, Text = "\n \n 6" };
            abs.Children.Add(nomer6, 6, 0);
            nomer7 = new Label { BackgroundColor = Color.White, Text = "\n \n 7" };
            abs.Children.Add(nomer7, 7, 0);
            nomer8 = new Label { BackgroundColor = Color.White, Text = "\n \n 8" };
            abs.Children.Add(nomer8, 8, 0);
            pon = new Label { BackgroundColor = Color.White, Text = "\n \n Понедельник" };
            abs.Children.Add(pon, 0, 1); 
            vtor = new Label { BackgroundColor = Color.White, Text = "\n \n Вторник" };
            abs.Children.Add(vtor, 0, 2); 
            sre = new Label { BackgroundColor = Color.White, Text = "\n \n Среда" };
            abs.Children.Add(sre, 0, 3); 
            chet = new Label { BackgroundColor = Color.White, Text = "\n \n Четверг" };
            abs.Children.Add(chet, 0, 4); 
            pjat = new Label { BackgroundColor = Color.White, Text = "\n \n Пятница" };
            abs.Children.Add(pjat, 0, 5);
            uroki1 = new Label { BackgroundColor = Color.White, Text = "Keel ja \n Kirjandus" };
            abs.Children.Add(uroki1, 1, 1);
            Grid.SetColumnSpan(uroki1, 2);
            uroki2 = new Label { BackgroundColor = Color.White, Text = "Võrgud ja Seadm." };
            abs.Children.Add(uroki2, 5, 1);
            Grid.SetColumnSpan(uroki2, 3);
            uroki3 = new Label { BackgroundColor = Color.White, Text = "Mob. Rak." };
            abs.Children.Add(uroki3, 8, 1);
            Grid.SetColumnSpan(uroki3, 3);
            uroki4 = new Label { BackgroundColor = Color.White, Text = "Transp.log.hut." };
            abs.Children.Add(uroki4, 3, 2);
            Grid.SetColumnSpan(uroki4, 3);
            uroki5 = new Label { BackgroundColor = Color.White, Text = "Inglise W.hald" };
            abs.Children.Add(uroki5, 7, 2);
            Grid.SetColumnSpan(uroki5, 2);
            uroki6 = new Label { BackgroundColor = Color.White, Text = "Eesti keel \n teise kellena" };
            abs.Children.Add(uroki6, 9, 2);
            Grid.SetColumnSpan(uroki6, 2);
            uroki7 = new Label { BackgroundColor = Color.White, Text = "W.paig.sead." };
            abs.Children.Add(uroki7, 3, 3);
            Grid.SetColumnSpan(uroki7, 3);
            uroki8 = new Label { BackgroundColor = Color.White, Text = "Transp.log.hut." };
            abs.Children.Add(uroki8, 6, 3);
            Grid.SetColumnSpan(uroki8, 5);
            uroki9 = new Label { BackgroundColor = Color.White, Text = "Keemia \n Biologia" };
            abs.Children.Add(uroki9, 11, 3);
            uroki10 = new Label { BackgroundColor = Color.White, Text = "W.paig.sead." };
            abs.Children.Add(uroki10, 3, 4);
            Grid.SetColumnSpan(uroki10, 3);
            uroki11 = new Label { BackgroundColor = Color.White, Text = "Võrgud ja Seadm." };
            abs.Children.Add(uroki11, 7, 4);
            uroki12 = new Label { BackgroundColor = Color.White, Text = "Inglise W.Hald" };
            abs.Children.Add(uroki12, 9, 4);
            Grid.SetColumnSpan(uroki12, 2);
            Content = abs;
        }
    }
}

