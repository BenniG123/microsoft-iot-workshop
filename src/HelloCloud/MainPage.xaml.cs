using System;
using System.Text;
using Microsoft.Azure.Devices;
using Windows.UI.Xaml.Controls;
using Microsoft.Azure.Devices.Common.Exceptions;
using System.Diagnostics;
using Microsoft.Azure.Devices.Client;

namespace HelloCloud
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InitDeviceAsync();
        }

        async void InitDeviceAsync()
        {
            Device device;
            RegistryManager registryManager = RegistryManager.CreateFromConnectionString(connectionString);

            try
            {
                device = await registryManager.AddDeviceAsync(new Device(deviceId));
            }
            catch (DeviceAlreadyExistsException)
            {
                device = await registryManager.GetDeviceAsync(deviceId);
            }

            deviceKey = device.Authentication.SymmetricKey.PrimaryKey;
            Debug.WriteLine(deviceKey);
            progress.IsActive = false;

            txtDeviceID.Text = deviceId;
            txtIsConnected.Text = "Connected";
        }

        private async void btnSendMessage_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var deviceClient = DeviceClient.Create(iotHubUri,
                    Microsoft.Azure.Devices.Client.AuthenticationMethodFactory.
                        CreateAuthenticationWithRegistrySymmetricKey(deviceId, deviceKey),
                    Microsoft.Azure.Devices.Client.TransportType.Http1);

            var str = boxMessage.Text;
            var message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(str));

            progress.IsActive = true;
            await deviceClient.SendEventAsync(message);
            progress.IsActive = false;
        }
    }
}
