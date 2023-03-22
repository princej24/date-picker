using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_picker
{
     class BlogPost
    {
        string _header;
        string _body;
        DateTime _created;

        public BlogPost(string header, string body)
        {
            _header = header;
            _body = body;
            _created = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{_created.ToShortDateString()} - {_header}";
        }






        //represents a point in time it includes information such as year, month, day

        // structure that represents a duration of time. It can be used to describe the amount of time between two DateTime objects

        // You can get the current time with DateTime.Now


        //  you need to divide the number of days by the number of days in a year 365 or 365.25

        //difference between DatePicker and Calendar controls is that DatePicker allows the user to select a specific date
        //while Calendar allows the user to view and select dates on a calendar

        //SelectedDate  SelectedValue

    }
}
