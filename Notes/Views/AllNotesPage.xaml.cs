//using Java.Nio.Channels;

namespace Notes.Views;

public partial class AllNotesPage : ContentPage
{
	public AllNotesPage()
	{
		InitializeComponent();

        BindingContext = new Models.AllNotes();
    }

	private async void Add_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(NewNote));
	}
}