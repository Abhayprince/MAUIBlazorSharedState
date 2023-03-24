using MAUIBlazorSharedState.States;
using Microsoft.AspNetCore.Components;

namespace MAUIBlazorSharedState;

public partial class App : Application
{
	public App(CounterState counterState)
	{
		InitializeComponent();

		MainPage = new MainPage(counterState);
	}
}
