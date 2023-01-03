﻿using ADOPMAUI_Exercise.Views.Lesson04;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Exercise.ViewModels
{
    public class Lesson04aViewModel
    {
        public Lesson04aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson04aViewModel()
        {
            All = new List<Lesson04aViewModel>
            {

                new Lesson04aViewModel(typeof(SelectingValueExercisePage), "Setting Value Exercise",
                        "Select values from various UI elements"),

                new Lesson04aViewModel(typeof(ListViewExercise1), "ListView Exercise1",
                        "Connect a ListView to datamodel"),

                new Lesson04aViewModel(typeof(ListViewExercise2), "ListView Exercise2",
                        "Customize the ListView by adding images"),
                
                new Lesson04aViewModel(typeof(ListViewExercise3), "ListView Exercise3",
                        "Customize the ListView by adding buttons"),
  
                new Lesson04aViewModel(typeof(ListViewExercise4), "ListView Exercise4",
                        "Use Linq to group items in a ListView"),
                
                new Lesson04aViewModel(typeof(StateManagement1), "StateManagement Exercise1",
                        "Accessing Global Data"),
            };
        }

        public static IList<Lesson04aViewModel> All { private set; get; }
    }
}
