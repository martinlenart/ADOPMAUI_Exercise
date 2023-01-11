using ADOPMAUI_Exercise.Models;
using ADOPMAUI_Exercise.Views.Lesson05;
using Microsoft.Maui;

namespace ADOPMAUI_Exercise;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Exercise ShellMenu: Adding an item to a Shell Menu in C#
        var NewsPapers = NewsSource.All;

        Tab aTab;
        foreach (var item in NewsPapers)
        {
            //Create a Tab, set its relevant properties
            aTab = new Tab { Title = item.Name };

            //Create a ShellContent , set its relevant properties
            var sc = new ShellContent
            {
                Title = item.Name,
                Route = item.Name.ToLower(),
                ContentTemplate = new DataTemplate(() => new WebViewExplore(item))
            };
            //Add the ShellContent into the Tab
            aTab.Items.Add(sc);

            //Add the Tab into lesson5news2 flyout item from the Xaml page
            //Your code
            lesson5news2.Items.Add(aTab);
        }
    }
}
