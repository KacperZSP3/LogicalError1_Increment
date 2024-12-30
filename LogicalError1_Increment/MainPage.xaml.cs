namespace LogicalError1_Increment;

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