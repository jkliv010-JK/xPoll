namespace xPoll.Pages;

public partial class ModbusASCIIPage : ContentPage
{
    public ModbusASCIIPage()
    {
        InitializeComponent();
    }

    private void OnConnectClicked(object sender, EventArgs e)
    {
        string portOrIP = PortEntry.Text;
        string paramsASCII = ParametersEntry.Text;

        ModbusService.ConnectASCII(portOrIP, paramsASCII);
    }
}