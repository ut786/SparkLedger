﻿using System;

namespace TechFlurry.SparkLedger.Shared.Extentions
{
    public static class DateTimeExtentions
    {
        public static string GetPassedTimeSpanFromNow(this DateTime time)
        {
            string s = time.ToString("dd-mmm-yyyy hh:mm:ss");
            TimeSpan span = DateTime.Now - time;
            var mins = decimal.Round(Convert.ToDecimal(span.TotalMinutes));
            var hrs = decimal.Round(Convert.ToDecimal(span.TotalHours));
            var days = decimal.Round(Convert.ToDecimal(span.TotalDays));
            if (mins < 1)
            {
                s = "Just Now";
            }
            else if (hrs < 1)
            {
                if (mins == 1)
                {
                    s = "1 minute ago";
                }
                else
                {
                    s = mins + " minutes ago";
                }
            }
            else if (days < 1)
            {
                if (hrs == 1)
                {
                    s = "1 hour ago";
                }
                else
                {
                    s = hrs + " hours ago";
                }
            }
            else if (days == 1)
            {
                s = "1 day ago";
            }
            else if (days < 31)
            {
                s = days + " days ago";
            }
            return s;
        }
        public static string GetPassedDateSpanFromNow(this DateTime date)
        {
            string s = date.ToString("dd-mmm-yyyy");
            TimeSpan span = DateTime.Now - date;
            var days = decimal.Round(Convert.ToDecimal(span.TotalDays));
            if (days < 1)
            {
                s = "Less than a day";
            }
            else if (days < 31)
            {
                s = days + " days ago";
            }
            return s;
        }
    }
}

