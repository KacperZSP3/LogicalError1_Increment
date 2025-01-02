namespace LogicalError1_Increment;
//Polecenie
//Za każdym razem, gdy przycisk zostanie kliknięty,
//etykieta powinna zaktualizować się, pokazując bieżący licznik,
//zaczynając od 0.
public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void IncrementButtonClicked(object sender, EventArgs e)
    {
        count++;
        CountLabel.Text = "Count: " + (count -1);
        
    }
}
