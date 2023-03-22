using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace date_picker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int ageToDrive = 15;
        const int ageToVote = 18;
        const int ageToDrink = 21;

        public MainWindow()
        {
            InitializeComponent();

            BlogPost bp = new BlogPost( "current ", " Day");

            runDisplay.Text = bp.ToString();
        }
        public void ExampleCode()
        {


            DateTime date = new DateTime(2023, 2, 15);
            DateTime now = DateTime.Now;


            string shortTime = now.ToShortTimeString();
            string longTime = now.ToLongTimeString();

            string formatString = $"" +
                $"Short Time: {shortTime}\n" +
                $"Long Time: {longTime}\n" +
                $"short Day: {now.ToShortDateString()}\n" +
                $"Long Date: {now.ToLongDateString()}\n" +
                $"Year: {now.Year}\n" +
                $"Day of the week: {now.DayOfWeek}";

            DateTime nowPlus7Monthes = now.AddMonths(7);

            TimeSpan differentInDaysFor7Monthes = nowPlus7Monthes - now;



            runDisplay.Text = (differentInDaysFor7Monthes.Days / 365.25).ToString();
        }

        private void btnDisplayTime_Click(object sender, RoutedEventArgs e)
        {
            DateTime bday = BirthdayObject();

            runDisplay.Text = $"Your Birthday is {bday}";
        }
        public DateTime BirthdayObject()
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);



            return new DateTime(year, month, day);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime bday = BirthdayObject();
            DateTime now = DateTime.Now;

            TimeSpan ageInDays = now - bday;
            int age = (int)(ageInDays.Days / 365.25);

            runDisplay.Text = $"you are {age} old\n";

            if (age >= ageToDrive)
            {
                runDisplay.Text += "you are old enough to drive";
            }


            if (age >= ageToDrink)
            {
                runDisplay.Text += "you are old enough to drink";
            }


            if (age >= ageToVote)
            {
                runDisplay.Text += "you are old enough to vote";
            }
        }

        private void btnResults_Click(object sender, RoutedEventArgs e)
        {
            bool calanderDateSelected = calDate.SelectedDate.HasValue;

            DateTime timeSelected = DateTime.Now;


            if (calanderDateSelected)
            {
                timeSelected = calDate.SelectedDate.Value;
            }

            runDisplay.Text = timeSelected.ToString();
        }

       
    }
}
