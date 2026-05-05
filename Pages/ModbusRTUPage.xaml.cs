namespace xPoll.Pages;

public partial class ModbusRTUPage : ContentPage
{
    public ModbusRTUPage()
    {
        InitializeComponent();
    }

    private void OnConnectClicked(object sender, EventArgs e)
    {
        string port = PortEntry.Text;
        string baudRate = BaudRateEntry.Text;

        if (int.TryParse(BaudRateEntry.Text, out int baudRate))
        {
            ModbusService.ConnectRTU(port, baudRate);
        }
        else
        {
            // TODO: Handle invalid baud rate error
        }
    }
}