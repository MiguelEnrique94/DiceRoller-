using System.Diagnostics;

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public int SelectedItem { get; private set; }
    public int chosenOpt { get; private set; }

    public MainPage()
	{
		InitializeComponent();
	}

    

    void diceChoice(object sender, EventArgs e)
	{
        var picker = (Picker)sender;
        var selectedItem = picker.SelectedItem;

        switch (SelectedItem)
        {
            case 4:
                chosenOpt = 4;
                break;
            case 6:
                chosenOpt = 6;
                break;
            case 10:
                chosenOpt = 10;
                break;
            case 20:
                chosenOpt = 20;
                break;
            case 100:
                chosenOpt = 100;
                break;
            default:
                chosenOpt = -1;
                break;
        }
    }



    void calc(object sender, EventArgs e)
    {
        Random rnd = new Random();
        diceValue = rnd.Next(int chosenOpt);
    }
}

