namespace Notes.Views;

public partial class NewNote : ContentPage
{
	public NewNote()
	{
		InitializeComponent();
	}

    private async void Save_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NotePage));
    }
}