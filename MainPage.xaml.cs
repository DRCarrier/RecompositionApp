namespace RecompositionApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void LogInBtnClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			LogInBtn.Text = $"Clicked {count} time";
		else
            LogInBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(LogInBtn.Text);
	}
}

