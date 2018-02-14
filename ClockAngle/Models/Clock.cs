using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace ClockAngle.Models
{
  public class Clock
  {
    private int _hour;
    private int _minute;
    private int _totalminutes;
    private int _degrees;

    public Clock (int hour, int minute)
    {
      _hour = hour;
      _minute = minute;
    }

    public int GetHour()
    {
      return _hour;
    }
    public void SetHour(int hour)
    {
      _hour = hour;
    }
    public int GetMinute()
    {
      return _minute;
    }
    public void SetMinute(int minute)
    {
      _minute = minute;
    }
    public int GetDegrees()
    {
      return _degrees;
    }

    public void CalculateMinutes()
    {
      _totalminutes = (_hour * 60) + _minute;
    }

    public void ToDegrees()
    {
      _degrees = _totalminutes / 4;
    }

  }

}
