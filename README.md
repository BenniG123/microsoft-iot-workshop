![logo](https://blog.adafruit.com/wp-content/uploads/2015/08/windows_iot1.jpg)

# Microsoft IoT Workshop
Welcome!  This repository contains source files and resources for the Iowa State Fall 2016 Microsoft IoT Lab Jam.  Here you will learn how to setup and deploy connected applications to an Windows powered IoT device.

## Requirements
Windows 10 desktop computer

**Optional but encouraged:** Your own [IoT Core Supported Device](https://developer.microsoft.com/en-us/windows/iot/explore/deviceoptions) and SD Card (8 GB+ is preferred)

## Setup
### Install Visual Studio 2015 Community or Higher
Follow [this link](https://www.visualstudio.com/vs/) to download and install Visual Studio.  Make sure you install the UWP tools.

### Install Windows 10 IoT Core Dashboard
Follow [this link](https://developer.microsoft.com/en-us/windows/iot/downloads) to download and install the IoT Core Dashboard.  You will need this to configure and manage your devices.

### Install Windows IoT Remote Client
Install at the Windows Store [here](https://www.microsoft.com/store/apps/9nblggh5mnxz)

### Set your development machine to Developer Mode
Open the **Settings app** > **Update & Security**. Click on **For developers** in the left side.  Now select **Developer mode**.

You will be prompted to restart your machine.

### Are you bringing your own device?
If you are bringing your own [IoT Core Supported Device](https://developer.microsoft.com/en-us/windows/iot/explore/deviceoptions), follow [this setup guide](https://developer.microsoft.com/en-us/windows/iot/GetStarted).

**Make sure you have the default IoT Core app running on your device so you can connect to my provided wifi**

#### Enable Remote Server
To enable remote server, follow instructions to open your board's device portal from the IoT Dashboard.  Click on the **Remote** tab and click the checkbox to enable remote server.

**Wait until the lab jam to continue**

## Using IoT Dashboard
Open the IoT Dashboard.  You should see a list of all IoT devices presently connected to this network.

Find your device on the list and double click.  It should be named **minwinpc** by default.  Open the **Device Portal** from the **Settings** screen.  The default username and password to all IoT devices is Administrator and p@ssw0rd.

Here you can manage your device settings, configure which apps run on startup, and do other administrative tasks.  This is a good go-to place for debugging or network troubleshooting.

## Deploy an App to your device
Open the **HelloWorld** project under the **src** directory.  It will automatically open up in Visual Studio 2015.  You should see a window popup with any dependencies or packages that you have not installed yet.

Now, on the platform selection drop down, select **ARM** as your build target (by default this is usually set to x86.  It is located next to the Green run arrow.)

Then, next to the green run arrow, select **Remote Machine** for the deployment target.  A window should popup with a few remote connections that your machine can see.  You can also configure this under 

Enter the name of your board (viewable in the **IoT Dashboard**) into the Address input.  Select Universal (Unencrypted Protocol) for the Authentication Mode.

You should now be able to build and run on your IoT Device by clicking the green arrow.  To see the UI from the device, open up the **Windows IoT Remote Client** app and select your device to get a remote desktop view.

## Connect your app to Azure
Now, open up the **HelloCloud** project under the **src** directory.  Change the **deviceId** string in the file **ConnectionStrings.cs** to whatever you want the name of your device to be.

Now, run this project and wait for the presenter to show you the dashboard from the IoT Hub instance.  Your deviceId should be listed within a minute or two as a device.

## More
Look at some of [these samples](https://github.com/ms-iot/samples) to modify your HelloCloud application.  Do something cool with it!
