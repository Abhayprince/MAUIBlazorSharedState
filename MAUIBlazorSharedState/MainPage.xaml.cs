using MAUIBlazorSharedState.States;

namespace MAUIBlazorSharedState;

public partial class MainPage : ContentPage
{
    private readonly CounterState _counterState;

    public MainPage(CounterState counterState)
	{
		InitializeComponent();
        _counterState = counterState;
		BindingContext= _counterState;
    }
    private void Button_Pressed(object sender, EventArgs e)
    {
        _counterState.Counter++;
    }
}
