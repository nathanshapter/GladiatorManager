using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateManager : MonoBehaviour
{
  //  int monthsInYear = 12, weeksInMonth = 4;

   
  //  int currentDay =1;

    DateTime currentDate;
    private void Start()
    {
        // Initial date
       currentDate = new DateTime(51, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        Debug.Log(FormatDate(currentDate));

     
    }


   



    private DateTime IncreaseDateOneWeek(DateTime date)
    {
        return date.AddDays(7);
    }

    private DateTime IncreaseDateByMonth(DateTime date)
    {
        return date.AddMonths(1);
    }

    private string FormatDate(DateTime date)
    {
        string era = date.Year < 1 ? "BCE" : "CE";
        return date.ToString("d MMMM yyyy ") + era;
    }
}
