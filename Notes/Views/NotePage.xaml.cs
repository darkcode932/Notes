//using static Android.Content.ClipData;
namespace Notes.Views;


[QueryProperty(nameof(ItemId), nameof(ItemId))]

public partial class NotePage : ContentPage
{

    public string ItemId
    {
        set { LoadNote(value); }
    }
    public NotePage()
	{
		InitializeComponent();
	}

    private void LoadNote(string fileName)
    {
        Models.Note noteModel = new Models.Note();
        noteModel.Filename = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Title = File.ReadAllText(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = noteModel;
    }
}