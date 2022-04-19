using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Newtonsoft.Json;
using System.Net.Http;


namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        List<Item> Items = new List<Item>();
        List<Task> Tasks = new List<Task>();
        string currentDate = DateTime.Today.ToShortDateString();

        string APIKey = "f2f160e83ec212a5ecbb5de99f90dbb5";
        public MainWindow()
        {
            InitializeComponent();
            DisplayTasksAfterStart();
            string buffer = "Things to do on: " + currentDate;
            label1.Content = buffer;
        }


        public void DisplayTasksAfterStart()
        {
            using (var context = new ApplicationDbContext())
            {
                Tasks = context.Tasks.Where(s => s.Date == DateTime.Today).ToList();
            }

            Items.Clear();

            foreach (var x in Tasks)
            {
                Items.Add(new Item(x.Name));
            }

            ListOfTasks.ItemsSource = Items;
            ListOfTasks.Items.Refresh();
        }



        public void RefreshListOfTasks()
        {
            Items.Clear();

            foreach (var x in Tasks)
            {
                Items.Add(new Item(x.Name));
            }

            ListOfTasks.ItemsSource = Items;
            ListOfTasks.Items.Refresh();
        }


        private void CreateTask(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
 
            var task = new Task {Name = window1.new_task.Text, Date = cal.SelectedDate};

            using (var context = new ApplicationDbContext())
            {
                context.Tasks.Add(task);
                context.SaveChanges();

                Tasks = context.Tasks.Where(s => s.Date == cal.SelectedDate).ToList();
            }
            RefreshListOfTasks();
        }

        private void cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... See if a date is selected.
            if (cal.SelectedDate.HasValue)
            {
                // ... Display SelectedDate in Title.
                DateTime date = cal.SelectedDate.Value;
                string buffer = "Things to do on: " + date.ToShortDateString();
                label1.Content = buffer;
            }

            using (var context = new ApplicationDbContext())
            {
                Tasks = context.Tasks.Where(s => s.Date == cal.SelectedDate).ToList();
            }
            RefreshListOfTasks();
        }


        private void DeleteMarkedTasks(object sender, RoutedEventArgs e)
        {
            foreach (var item in Items)
            {
                if (item.IsMarked)
                {
                    using (var context = new ApplicationDbContext())
                    {
                        foreach (var task in context.Tasks)
                        {
                            if (item.Content == task.Name)
                            {
                                context.Tasks.Remove(task);
                            }
                        }
                        context.SaveChanges();
                    }
                    Task? help = new Task();
                    foreach (var task in Tasks)
                    {
                        if (item.Content == task.Name)
                        {
                            help = task;
                            break;
                        }
                    }
                    Tasks.Remove(help);
                }
            }
            RefreshListOfTasks();
        }


        private void ButtonSearchClick(object sender, RoutedEventArgs e)
        {
            GetWeather();
        }

        async void GetWeather()
        {
            using (HttpClient web = new HttpClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBoxCity.Text, APIKey);
                HttpResponseMessage response = await web.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                weatherIcon.Source = new BitmapImage(new Uri("http://openweathermap.org/img/w/" + info.weather[0].icon + ".png"));
                labelConditions.Content = "Conditions: " + info.weather[0].main;
                labelDetails.Content = "Details: " + info.weather[0].description;
                labelSunset.Content = "Sunset: " + GetTime(info.sys.sunset).ToString();
                labelSunrise.Content = "Sunrise: " + GetTime(info.sys.sunrise).ToString();
                labelWindSpeed.Content = "Wind: " + info.wind.speed.ToString() + " m/s";
                labelPressure.Content = "Pressure: " + info.main.pressure.ToString() + " hPa";
                labelTemp.Content = "Temperature: " + Convert.ToInt32(info.main.temp - 273.15).ToString() + " C";
            }
        }

        DateTime GetTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;
        }

        
    }
}
