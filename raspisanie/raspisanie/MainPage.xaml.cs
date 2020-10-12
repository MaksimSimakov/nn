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
            uroki1 = new Label { BackgroundColor = Color.LightGreen, Text = "Keel ja \n Kirjandus" };
            abs.Children.Add(uroki1, 1, 1);
            Grid.SetColumnSpan(uroki1, 2);
            uroki2 = new Label { BackgroundColor = Color.Beige, Text = "Võrgud ja Seadm." };
            abs.Children.Add(uroki2, 3, 1);
            Grid.SetColumnSpan(uroki2, 3);
            uroki3 = new Label { BackgroundColor = Color.DeepSkyBlue, Text = "Mob. Rak." };
            abs.Children.Add(uroki3, 7, 1);
            Grid.SetColumnSpan(uroki3, 3);
            uroki4 = new Label { BackgroundColor = Color.LightSeaGreen, Text = "Transp.log.hut." };
            abs.Children.Add(uroki4, 1, 2);
            Grid.SetColumnSpan(uroki4, 3);
            uroki5 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };
            abs.Children.Add(uroki5, 5, 2);
            Grid.SetColumnSpan(uroki5, 2);
            uroki6 = new Label { BackgroundColor = Color.Pink, Text = "Eesti keel \n teise kellena" };
            abs.Children.Add(uroki6, 7, 2);
            Grid.SetColumnSpan(uroki6, 2);
            uroki7 = new Label { BackgroundColor = Color.Violet, Text = "W.paig.sead." };
            abs.Children.Add(uroki7, 1, 3);
            Grid.SetColumnSpan(uroki7, 3);
            uroki8 = new Label { BackgroundColor = Color.LightSeaGreen, Text = "Transp.log.hut." };
            abs.Children.Add(uroki8, 4, 3);
            Grid.SetColumnSpan(uroki8, 5);
            uroki9 = new Label { BackgroundColor = Color.DarkViolet, Text = "Keemia \n Biologia" };
            abs.Children.Add(uroki9, 9, 3);
            uroki10 = new Label { BackgroundColor = Color.Violet, Text = "W.paig.sead." };
            abs.Children.Add(uroki10, 1, 4);
            Grid.SetColumnSpan(uroki10, 3);
            uroki11 = new Label { BackgroundColor = Color.Beige, Text = "Võrgud ja Seadm." };
            abs.Children.Add(uroki11, 5, 4);
            Grid.SetColumnSpan(uroki11, 2);
            uroki12 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.Hald" };
            abs.Children.Add(uroki12, 7, 4);
            Grid.SetColumnSpan(uroki12, 2);
            uroki13 = new Label { BackgroundColor = Color.DarkViolet, Text = "Keemia, bioloogia eesti keeles" };
            abs.Children.Add(uroki13, 1, 5);
            uroki14 = new Label { BackgroundColor = Color.DeepSkyBlue, Text = "Mob.rak" };
            abs.Children.Add(uroki14, 3, 5);
            Grid.SetColumnSpan(uroki14, 3);
            Content = abs;
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                uroki1 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B221 \n Mihhailova Ljudmilla", "закрыть");
            };
            uroki1.GestureRecognizers.Add(tap1);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += async (s, e) =>
            {
                uroki2 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет A123 \n Agapov Mikhail", "закрыть");
            };
            uroki2.GestureRecognizers.Add(tap2);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += async (s, e) =>
            {
                uroki3 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет E07 \n Oleinik Marina", "закрыть");
            };
            uroki3.GestureRecognizers.Add(tap3);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += async (s, e) =>
            {
                uroki4 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B002 \n Krull Jaanus", "закрыть");
            };
            uroki4.GestureRecognizers.Add(tap4);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += async (s, e) =>
            {
                uroki5 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B242 \n Voronetskaja Julia", "закрыть");
            };
            uroki5.GestureRecognizers.Add(tap5);
            var tap6 = new TapGestureRecognizer();
            tap6.Tapped += async (s, e) =>
            {
                uroki6 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B236 \n Laaneväli-Toots Alina", "закрыть");
            };
            uroki6.GestureRecognizers.Add(tap6);
            var tap7 = new TapGestureRecognizer();
            tap7.Tapped += async (s, e) =>
            {
                uroki7 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет A243 \n Shkarbanova Lury", "закрыть");
            };
            uroki7.GestureRecognizers.Add(tap7);
            var tap8 = new TapGestureRecognizer();
            tap8.Tapped += async (s, e) =>
            {
                uroki8 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B002 \n Krull Jaanus", "закрыть");
            };
            uroki8.GestureRecognizers.Add(tap8);
            var tap9 = new TapGestureRecognizer();
            tap9.Tapped += async (s, e) =>
            {
                uroki9 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B144 \n Pesetskaja Svetlana", "закрыть");
            };
            uroki9.GestureRecognizers.Add(tap9);
            var tap10 = new TapGestureRecognizer();
            tap10.Tapped += async (s, e) =>
            {
                uroki10 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет a243 \n Shkarbanova Lury", "закрыть");
            };
            uroki10.GestureRecognizers.Add(tap10);
            var tap11 = new TapGestureRecognizer();
            tap11.Tapped += async (s, e) =>
            {
                uroki11 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет A123 \n Agapov Mikhail", "закрыть");
            };
            uroki11.GestureRecognizers.Add(tap11);
            var tap12 = new TapGestureRecognizer();
            tap12.Tapped += async (s, e) =>
            {
                uroki12 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B242 \n Voronetskaja Julia", "закрыть");
            };
            uroki12.GestureRecognizers.Add(tap12);
            var tap13 = new TapGestureRecognizer();
            tap13.Tapped += async (s, e) =>
            {
                uroki13 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет B144 \n Pesetskaja Svetlana", "закрыть");
            };
            uroki13.GestureRecognizers.Add(tap13);
            var tap14 = new TapGestureRecognizer();
            tap14.Tapped += async (s, e) =>
            {
                uroki14 = (Label)s;
                await DisplayAlert("Доп. инфо", "Кабинет E007 \n Oleinik Marina", "закрыть");
            };
            uroki14.GestureRecognizers.Add(tap14);
        }
    }
}

