using System.Windows;


namespace Calendar
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        /**
        * @brief Obsługuje kliknięcie przycisku Save
        * @param sender - obiekt, dla którego wywołano funkcję
        * @param e - informacje o zdarzeniu
        **/
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
