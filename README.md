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

#### Net Reg your Device
If you are bringing your own hardware, it needs to be registered to get access on Iowa State's network.  I've provided 2 options that should work.

The first way is the easiest, but relies on the response time of ISU IT.  Email the [solutions center](http://www.it.iastate.edu/solution/) with your Net ID and your device's Mac Address, explaining why your device needs to be connected to the network.  To find the Mac Address, follow instructions to open your board's device portal from the IoT Dashboard.  Click on the **Networking** tab and scroll down to whichever module has an IP address.  The **Physical address** listed is your device's Mac Address.

The second way is completely DIY, but takes a bit more effort.  Download the [IoT Core Browser Sample](https://developer.microsoft.com/enus/windows/iot/samples/iotbrowser) and deploy it to your device as per the instructions.  From the device portal, set the browser app as the default app.  Once your device is connected to Iowa State's network, when you try to navigate anywhere the netreg page should redirect your browser (this requires connecting your device to a monitor and keyboard.)  Follow the prompts as necessary and restart your device to get internet access.

#### Enable Remote Server
To enable remote server, follow instructions to open your board's device portal from the IoT Dashboard.  Click on the **Remote** tab and click the checkbox to enable remote server.

**Wait until the lab jam to continue**

## Using IoT Dashboard
Open the IoT Dashboard.  You should see a list of all IoT devices presently connected to this network.

Find your device on the list and double click.  It should be named **minwinpc** by default.  Open the **Device Portal** from the **Settings** screen.  The default username and password to all IoT devices is Administrator and p@ssw0rd.

## Deploy an App to your device

## Connect your app to Azure
