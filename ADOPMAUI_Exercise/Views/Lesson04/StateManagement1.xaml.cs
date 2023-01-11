﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ADOPMAUI_Exercise.Globals;
using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson04
{
    public partial class StateManagement1 : ContentPage
    {
        public List<Friend> myFriends { get; set; }
        public StateManagement1()
        {
            InitializeComponent();

            var startMessage = Global.Data.Message;
            var startTime = Global.Data.Time;

            myFriends = Global.Data.myBlueFriends;
            BindingContext= this;
        }
    }
}

