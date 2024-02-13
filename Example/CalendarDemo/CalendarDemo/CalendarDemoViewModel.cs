﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CalendarDemo.Base;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using XamForms.Controls;

namespace CalendarDemo
{
    public class CalendarDemoViewModel : BaseViewModel
    {
        private DateTime? _date;
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                NotifyPropertyChanged(nameof(Date));
            }
        }

        private ObservableCollection<SpecialDate> attendances;
        public ObservableCollection<SpecialDate> Attendances
        {
            get { return attendances; }
            set { attendances = value; NotifyPropertyChanged(nameof(Attendances)); }
        }

        public ICommand DateChosen => new Command((obj) =>
        {
            System.Diagnostics.Debug.WriteLine(obj as DateTime?);
        });

        public CalendarDemoViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            var dates = new List<SpecialDate>();
            
            var grayColor = Color.FromArgb("#CCE5E5E5");

            Attendances = new ObservableCollection<SpecialDate>(dates) {
                new SpecialDate(DateTime.Now.AddDays(3))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.7f, Color = Color.FromArgb("#FFFFFF")}, //White
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.3f, Color = Color.FromArgb("#FFFFFF00")/*Yellow*/,Text = "Vacation", TextColor=Color.FromArgb("##FF00008B")/*DarkBlue*/, TextSize=11, TextAlign=TextAlign.Middle},
                        }
                    }
                },
                new SpecialDate(DateTime.Now.AddDays(5))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.7f, Color = Color.FromArgb("#FFFFFF")}, //White
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.3f, Color = Color.FromArgb("#FF90EE90")/*LightGreen*/, Text = "Absence", TextColor=Color.FromArgb("#FF00008B")/*DarkBlue*/, TextSize=11, TextAlign=TextAlign.Middle},
                        }
                    }
                },
                new SpecialDate(DateTime.Now.AddDays(4))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.7f, Color = grayColor},
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.15f, Color = Color.FromArgb("#FFFFFF00")/*Yellow*/, Text = "Vacation", TextColor=Color.FromArgb("#FF00008B")/*DarkBlue*/, TextSize=9, TextAlign=TextAlign.Middle},
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.15f, Color = Color.FromArgb("#FF90EE90")/*LightGreen*/, Text = "Absence", TextColor=Color.FromArgb("#FF00008B")/*DarkBlue*/, TextSize=9, TextAlign=TextAlign.Middle},
                        }
                    }
                },
                new SpecialDate(DateTime.Now.AddDays(6))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.7f, Color = grayColor},
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.3f, Color = Color.FromArgb("#FF90EE90")/*LightGreen*/, Text = "Absence", TextColor=Color.FromArgb("#FF00008B")/*DarkBlue*/, TextSize=11, TextAlign=TextAlign.Middle},
                        }
                    }
                },
                new SpecialDate(DateTime.Now)
                {
                    Selectable = true,
                    TextColor = Color.FromArgb("#FFFF0000"),//Red,
                    FontAttributes = FontAttributes.Bold
                },
                new SpecialDate(DateTime.Now.AddDays(1))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 1f, Color = grayColor},
                        }
                    }
                },
                new SpecialDate(DateTime.Now.AddDays(2))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 1f, Color = grayColor},
                        }
                    }
                },
                new SpecialDate(DateTime.Now.AddDays(8))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 1f, Color = grayColor},
                        }
                    }
                },
                new SpecialDate(DateTime.Now.AddDays(9))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern{ WidthPercent = 1f, HightPercent = 1f, Color = grayColor},
                        }
                    }
                },
                
            };
        }
    }
}

