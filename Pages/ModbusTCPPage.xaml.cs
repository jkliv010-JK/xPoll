namespace xPoll.Pages;

public partial class ModbusTCPPage : ContentPage
{
    public ModbusTCPPage()
    {
        InitializeComponent();
    }

    private void OnConnectClicked(object sender, EventArgs e)
    {
        string ipAddress = HostEntry.Text;
        string tcpPort = PortEntry.Text;

        if (int.TryParse(tcpPort, out int port))
        {
            ModbusService.ConnectTCP(ipAddress, port);
        }
        else
        {
            // TODO: Handle invalid port error
        }
    }
}