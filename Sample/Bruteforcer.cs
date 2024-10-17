#region Copyright (c) 2024, Jack Leighton
// /////     __________________________________________________________________________________________________________________
// /////
// /////                  __                   __              __________                                      __   
// /////                _/  |_  ____   _______/  |_  __________\______   \_______   ____   ______ ____   _____/  |_ 
// /////                \   __\/ __ \ /  ___/\   __\/ __ \_  __ \     ___/\_  __ \_/ __ \ /  ___// __ \ /    \   __\
// /////                 |  | \  ___/ \___ \  |  | \  ___/|  | \/    |     |  | \/\  ___/ \___ \\  ___/|   |  \  |  
// /////                 |__|  \___  >____  > |__|  \___  >__|  |____|     |__|    \___  >____  >\___  >___|  /__|  
// /////                           \/     \/            \/                             \/     \/     \/     \/      
// /////                                                          .__       .__  .__          __                    
// /////                               ____________   ____   ____ |__|____  |  | |__| _______/  |_                  
// /////                              /  ___/\____ \_/ __ \_/ ___\|  \__  \ |  | |  |/  ___/\   __\                 
// /////                              \___ \ |  |_> >  ___/\  \___|  |/ __ \|  |_|  |\___ \  |  |                   
// /////                             /____  >|   __/ \___  >\___  >__(____  /____/__/____  > |__|                   
// /////                                  \/ |__|        \/     \/        \/             \/                         
// /////                                  __                         __  .__                                        
// /////                   _____   __ ___/  |_  ____   _____   _____/  |_|__|__  __ ____                            
// /////                   \__  \ |  |  \   __\/  _ \ /     \ /  _ \   __\  \  \/ // __ \                           
// /////                    / __ \|  |  /|  | (  <_> )  Y Y  (  <_> )  | |  |\   /\  ___/                           
// /////                   (____  /____/ |__|  \____/|__|_|  /\____/|__| |__| \_/  \___  >                          
// /////                        \/                         \/                          \/                           
// /////                                                  .__          __  .__                                      
// /////                                       __________ |  |  __ ___/  |_|__| ____   ____   ______                
// /////                                      /  ___/  _ \|  | |  |  \   __\  |/  _ \ /    \ /  ___/                
// /////                                      \___ (  <_> )  |_|  |  /|  | |  (  <_> )   |  \\___ \                 
// /////                                     /____  >____/|____/____/ |__| |__|\____/|___|  /____  >                
// /////                                          \/                                      \/     \/                 
// /////                                   Tester Present Specialist Automotive Solutions
// /////     __________________________________________________________________________________________________________________
// /////      |--------------------------------------------------------------------------------------------------------------|
// /////      |       https://github.com/jakka351/| https://testerPresent.com.au | https://facebook.com/testerPresent        |
// /////      |--------------------------------------------------------------------------------------------------------------|
// /////      | Copyright (c) 2022/2023/2024 Benjamin Jack Leighton                                                          |          
// /////      | All rights reserved.                                                                                         |
// /////      |--------------------------------------------------------------------------------------------------------------|
// /////        Redistribution and use in source and binary forms, with or without modification, are permitted provided that
// /////        the following conditions are met:
// /////        1.    With the express written consent of the copyright holder.
// /////        2.    Redistributions of source code must retain the above copyright notice, this
// /////              list of conditions and the following disclaimer.
// /////        3.    Redistributions in binary form must reproduce the above copyright notice, this
// /////              list of conditions and the following disclaimer in the documentation and/or other
// /////              materials provided with the distribution.
// /////        4.    Neither the name of the organization nor the names of its contributors may be used to
// /////              endorse or promote products derived from this software without specific prior written permission.
// /////      _________________________________________________________________________________________________________________
// /////      THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES,
// /////      INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// /////      DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// /////      SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// /////      SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
// /////      WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE
// /////      USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// /////      _________________________________________________________________________________________________________________
// /////
// /////       This software can only be distributed with my written permission. It is for my own educational purposes and  
// /////       is potentially dangerous to ECU health and safety. Gracias a Gato Blancoford desde las alturas del mar de chelle.                                                        
// /////      _________________________________________________________________________________________________________________
// /////
// /////
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion License
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.IO;
using System.Drawing;
using System.Threading;
using J2534;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Collections;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Text;
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Bruteforcer
{
	// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public partial class Bruteforcer : Form
	{
		// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		public Bruteforcer()
		{
			InitializeComponent();
		}


		// ////////////////////////////////
		// Write log string to textBoxLog
		public void addTxtLog(string m)
		{
			// Invoke required to marshal the call back to the UI thread
			if (textBoxLog.InvokeRequired)
			{
				textBoxLog.Invoke(new Action<string>(addTxtLog), m);
			}
			else
			{
				textBoxLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + "\r\n" + m);
				if (textBoxLog.Focused)
				{
					textBoxLog.SelectionStart = textBoxLog.Text.Length;
					textBoxLog.SelectionLength = 0;
					textBoxLog.ScrollToCaret();
				}
			}
		}
		// //////////////////////////////////
		public void addTxtObd(string m)
		{
			
		}
		// //////////////////////////////////
		static string HexToASCII(string hexString)
		{
			byte[] bytes = new byte[hexString.Length / 2];
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
			}
			return Encoding.ASCII.GetString(bytes);
		}
		// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// exit buttton in menu
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		// //////////////////////////////////////////////////////////////////////////
		// SUPPORT INFO FORM
		private void supportInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form Support = new global::Bruteforcer.Support();
			Support.Activate();
			Support.Show();
		}
		// ////////////////////////////////////////////////////////////////////////
		private void viewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form License = new global::Bruteforcer.License();
			License.Activate();
			License.Show();
		}
		// /////////////////////////////////////////////////////////////////
		// Save Device Log File
		private void saveDeviceLogButton_Click(object sender, EventArgs e)
		{
			string lines = textBoxLog.Text;
			File.WriteAllText(@"bruteforcer.log", lines);
			System.Windows.Forms.MessageBox.Show("J2534 Device & Application Log saved to .exe directory", "Ford ECU Bruteforcer - Tester Present Specialist Automotive Solutions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		// /////////////////////////////////////////////////////////////////
		private void clearDeviceLogButton_Click(object sender, EventArgs e)
		{
			textBoxLog.Text = "";
		}
		// ///////////////////////////////////////////////////////////////////////////////////////////
		class J2534_Struct
		{
			public J2534_Struct()
			{
				Functions = new J2534FunctionsExtended();
				LoadedDevice = new J2534Device();
			}
			public J2534.J2534FunctionsExtended Functions;
			public J2534.J2534Device LoadedDevice;
		}
		// //////////////////////////////////////////////////////////////
		private J2534_Struct J2534Port = new J2534_Struct();
		private uint DeviceID;//This is the unique ID of the J2534 that is used in all functions.
		public uint ChannelID;//This is the unqiue ID of the CHannel (Protocol) that we connect to
		public int FilterID; //This is the unique ID of the Filter we set (Every filter gets a ID, so you should make this a list to save them all if doing more then 1.
							 // //////////////////////////////////////////////////////////////
							 // Detect Installed J2534 Devices
		private void CmdDetectDevicesClick(object sender, EventArgs e)
		{
			// ///////////////////////////////////////////////////
			//1) Search for all of our J2534 Devices
			List<J2534.J2534Device> MyListOfJ2534Devices = J2534DeviceFinder.FindInstalledJ2534DLLs();
			//List of devices installed on the PC
			for (int i = 0; i < MyListOfJ2534Devices.Count; i++)
			{
				string J2534ToolsName = MyListOfJ2534Devices[i].Name;
				comboBoxJ2534Devices.Items.Add(J2534ToolsName);
				addTxtLog("Found Installed Device: " + J2534ToolsName.ToString() + "\r\n");
			}
		}
		// ////////////////////////////////////////////////////////////////
		// Connect the selected J2534 device from the comboBox
		private void connectSelectedJ2534Device(byte ecuId, byte ecuId2, byte ecuId3, bool highSpeed)
		{
			List<J2534.J2534Device> MyListOfJ2534Devices = J2534DeviceFinder.FindInstalledJ2534DLLs();
			for (int i = 0; i < MyListOfJ2534Devices.Count; i++)
			{
				string J2534ToolsName = MyListOfJ2534Devices[i].Name;
				//comboBoxJ2534Devices.Items.Add(J2534ToolsName);
				//addTxtLog("Found Installed Device: " + J2534ToolsName.ToString() + "\r\n");
			}

			// ///////////////////////////////////////////////////
			//2) Select our device and load the DLL into memory
			//Below is my fancy way of specificaly targeting a tool in the list based on its name.
			//J2534Port.LoadedDevice = MyListOfJ2534Devices.Where(x => x.Name == "CDR900").First(); //MyListOfJ2534Devices[0];
			J2534Port.LoadedDevice = MyListOfJ2534Devices[comboBoxJ2534Devices.SelectedIndex];
			if (J2534Port.Functions.LoadLibrary(J2534Port.LoadedDevice) == false)
			{
				addTxtLog("Failed to load library DLL ERROR \r\n");
				//Error here, DLL is fucked.
			}
			else
			{
				addTxtLog("Library Loaded Succesfully \r\n");

			}
			addTxtLog("Selected Device: " + comboBoxJ2534Devices.SelectedItem.ToString() + "\r\n");  //get ti this point successfully
			// ///////////////////////////////////////////////////
			//3) Open the connection to the J2534 Tool
			var ErrorResult = J2534Port.Functions.PassThruOpen(IntPtr.Zero, ref DeviceID); //then error out here with invalid device number
			if (ErrorResult != J2534Err.STATUS_NOERROR)
			{
				addTxtLog(ErrorResult.ToString() + "\r\n");
				addTxtLog("PassThru Open ERROR) \r\n");
			}
			else
			{
				addTxtLog("PassThru Open Success \r\n");
			}
			// ///////////////////////////////////////////////////////////////////
			//4) Start our OBD2 connection 
			//Use ProtocolID.ISO15765_PS if needing to connect to MS CAN. Have to pass the pins 3/11 to tell it to go to those.
			ushort psValue = 0x60E;
			if (highSpeed == true)
			{
				ErrorResult = J2534Port.Functions.PassThruConnect(DeviceID, ProtocolID.ISO15765, ConnectFlag.NONE, BaudRate.CAN_500000, ref ChannelID);
				if (ErrorResult != J2534Err.STATUS_NOERROR)
				{
					addTxtLog(ErrorResult.ToString() + "\r\n");
					addTxtLog("PassThru Connect ERROR \r\n");
				}
				else
				{
					addTxtLog("PassThru Connect Success \r\n");
				}
				psValue = 0x60E;
			}
			if (highSpeed == false) // edited for bench rig
			{
				//ErrorResult = J2534Port.Functions.PassThruConnect(DeviceID, ProtocolID.ISO15765, ConnectFlag.NONE, BaudRate.CAN_125000, ref ChannelID); //_PS
				ErrorResult = J2534Port.Functions.PassThruConnect(DeviceID, ProtocolID.ISO15765_PS, ConnectFlag.NONE, BaudRate.CAN_125000, ref ChannelID); //_PS
				if (ErrorResult != J2534Err.STATUS_NOERROR)
				{
					addTxtLog(ErrorResult.ToString() + "\r\n");
					addTxtLog("PassThru Connect ERROR \r\n");
				}
				else
				{
					addTxtLog("PassThru Connect Success \r\n");
				}
				//psValue = 0x60E;
				psValue = 0x30B; //0x30B for real world				

			}
			List<SConfig> configuration = new List<SConfig>();
			configuration.Add(new SConfig() { Parameter = ConfigParameter.J1962_PINS, Value = psValue }); //0x30B
			ErrorResult = J2534Port.Functions.SetConfig((int)ChannelID, ref configuration);
			if (ErrorResult != J2534Err.STATUS_NOERROR)
			{
				addTxtLog(ErrorResult.ToString() + "\r\n");
				addTxtLog("SConfig Pin Select ERROR \r\n");
			}
			else
			{
				addTxtLog("SConfig Pin Select Success\r\n");
			}
			// //////////////////////////////////////////////////////////////
			//5) Set the OBD2 pins we are connecting to on the canbus line
			//Set pins if doing MSCAN or selecting the _PS channel (PS stands for Pin Select)
			//pins= 0x60E 'pin 6 for CAN H, pin 14 for CAN L
			//pins= 0x30B 'pin 3 for CAN H, pin 11 for CAN L

			///////////////////////
			//6) Set Filters
			//A flow filter is whats required for ending multi line messages. Pass is for sending just individual messages.
			PassThruMsg maskMsg = new PassThruMsg(ProtocolID.ISO15765, TxFlag.NONE, new byte[] { 0, 0, 07, 0xFF }); //Set mask of 7FF (Only accept the exact PATTERN
			PassThruMsg patternMsg = new PassThruMsg(ProtocolID.ISO15765, TxFlag.NONE, new byte[] { 0, 0, ecuId, ecuId3 }); //Search for 7E8
			PassThruMsg flowMsg = new PassThruMsg(ProtocolID.ISO15765, TxFlag.NONE, new byte[] { 0, 0, ecuId, ecuId2 }); //Use the flow message of 7E0
			IntPtr maskPtr = maskMsg.ToIntPtr();
			IntPtr PatternPtr = patternMsg.ToIntPtr();
			IntPtr FlowPtr = flowMsg.ToIntPtr();
			ErrorResult = J2534Port.Functions.PassThruStartMsgFilter((int)ChannelID, FilterType.FLOW_CONTROL_FILTER, maskPtr, PatternPtr, FlowPtr, ref FilterID);
			if (ErrorResult != J2534Err.STATUS_NOERROR)
			{
				addTxtLog(ErrorResult.ToString() + "\r\n");
				//Shits fucked, couldnt set required folter
			}
			else
			{
				addTxtLog("Control Module Start Message Filter Success \r\n");
			}

			//ALWAYS do this after all commands that use a INTPTR so that it releases any used memory/ram by that variable.
			Marshal.FreeHGlobal(maskPtr);
			Marshal.FreeHGlobal(PatternPtr);
			Marshal.FreeHGlobal(FlowPtr);
		}
		// /////////////////////////////////////////////////////////////////////////////////////////////////////////////

		// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//       ____.________   .________________     _____  
		//      |    |\_____  \  |   ____/\_____  \   /  |  | 
		//      |    | /  ____/  |____  \   _(__  <  /   |  |_
		//  /\__|    |/       \  /       \ /       \/    ^   /
		//  \________|\_______ \/______  //______  /\____   |  Send PassThru Message
		//                    \/       \/        \/      |__| 
		// ///////////////////////////////////////////////////
		string sendPassThruMsg(byte[] frame)
		{
			// ///////////////////////////////////////
			// ///////////////////////////////////////////////////////////////////
			//7) Write a message
			int NumberOfMsgs = 1;
			//new byte[] { 0, 0, 0, canId1, canId2, data0, data1, data2, data3, data4, data5, data6, data7 }
			//byte[] tempframe = new byte[] { 0, 0, 0x7, 0xDF, 4 }; //this equals 7DF 01 04  00 00 00 00 00 00 (Rest of 00's is just filler bytes to make up full 8 byte frame).
			PassThruMsg WriteMsg = new PassThruMsg(ProtocolID.ISO15765, TxFlag.ISO15765_FRAME_PAD, frame); //Send 7E0 mode 1 table C. SAE REQUEST.
			IntPtr WritePtr = WriteMsg.ToIntPtr();
			var ErrorResult = J2534Port.Functions.PassThruWriteMsgs((int)ChannelID, WritePtr, ref NumberOfMsgs, 0);//timeout of 0 means just send it and dont care how long.
			if (ErrorResult != J2534Err.STATUS_NOERROR)
			{
				addTxtLog(ErrorResult.ToString() + "\r\n");
				//Shits fucked, fauled writing.
			}
			else
			{
				//addTxt1("PassThru Write Msg Success \r\n");
			}
			// ///////////////////////////////////////////////////////////////
			//8) Read Respnse
			bool SearchForResponse = true;
			while (SearchForResponse == true)
			{
				int NumReadMsgs = 1;
				IntPtr MyRXMsg = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PassThruMsg)) * NumReadMsgs);
				ErrorResult = J2534Port.Functions.PassThruReadMsgs((int)ChannelID, MyRXMsg, ref NumReadMsgs, 2000); //this is your timeout here.
				if (ErrorResult != J2534Err.STATUS_NOERROR) //if no frames received, it goes here.
				{
					addTxtLog(ErrorResult.ToString() + "\r\n");
					addTxtLog("Failed to read PassThru Msg \r\n");
					//Shits fucked, fauled reading!!!
					break;
				}
				else
				{
					//addTxt1("PassThru Read Msg Success \r\n");
				}
				//Convert the memory pointer back to a PassThruMsg Object
				PassThruMsg FoundFrame = MyRXMsg.AsMsgList(1).Last();
				if (((int)FoundFrame.RxStatus == ((int)J2534.RxStatus.TX_INDICATION_SUCCESS ^ (int)J2534.RxStatus.TX_MSG_TYPE)) ||
					((int)FoundFrame.RxStatus == ((int)J2534.RxStatus.TX_INDICATION_SUCCESS ^ (int)J2534.RxStatus.TX_MSG_TYPE ^ (int)J2534.RxStatus.ISO15765_ADDR_TYPE)) ||
					((int)FoundFrame.RxStatus == ((int)J2534.RxStatus.START_OF_MESSAGE))
					)
				{
					//We dont want any of this, continue!
					Marshal.FreeHGlobal(MyRXMsg);
					continue;
				}
				Marshal.FreeHGlobal(MyRXMsg);
				//This should have our bytes!
				byte[] MyRXDBytes = FoundFrame.GetBytes();
				string DataToString = "";
				for (int i = 0; i < MyRXDBytes.Length; i++)
				{
					DataToString += MyRXDBytes[i].ToString("X2") + "  ";
				}
				addTxtLog("Rx: " + DataToString + "\r\n");
				return DataToString;
			}
			string noData = "No Data";
			return noData;
		}
		byte ecuId;
		byte ecuId2;
		byte ecuId3;

		private void darkButton1_Click(object sender, EventArgs e)
		{
			try
	        {
	        
				bool highSpeed = true; ;
				switch (comboBoxCanbus.SelectedIndex)
				{
					case 0x00:
						highSpeed = false;
						break;
					case 0x01:
						highSpeed = true;
						break;
				}
				string ecuCanId = "0" + textBoxEcuId.Text;
				// Ensure the input string is exactly 4 characters
				if (ecuCanId.Length != 4)
				{
					addTxtLog("ECU CAN RX ID must be 3 characters. \r\n");
					return;
				}
				// Get the ASCII values of each character
				byte byte1 = (byte)ecuCanId[0];
				byte byte2 = (byte)ecuCanId[1];
				byte byte3 = (byte)ecuCanId[2];
				byte byte4 = (byte)ecuCanId[3];
				// Combine the first two characters into the first byte
				ecuId = (byte)((byte1 << 4) | (byte2 & 0x0F));
				// Combine the third and fourth characters into the second byte
				ecuId2 = (byte)((byte3 << 4) | (byte4 & 0x0F));
				ecuId3 = (byte)(ecuId2 + 8);
				connectSelectedJ2534Device(ecuId, ecuId2, ecuId3, highSpeed);
				if (checkBoxFEPS.Checked)
				{
					var ErrorResult = J2534Port.Functions.PassThruSetProgrammingVoltage((int)DeviceID, (PinNumber)13, 18000);
					if (ErrorResult != J2534Err.STATUS_NOERROR)
					{
						addTxtLog(ErrorResult.ToString() + "\r\n");
						addTxtLog("Setting FEPS Voltage ERROR \r\n");
					}
					else
					{
						addTxtLog("FEPS Programming Voltage set \r\n");
					}
				}
				string sessionType = "";
				switch(comboBoxDiagSess.SelectedIndex)
				{
					case 0x00:
						sessionType = "81";
						break;
					case 0x01:
						sessionType = "83";
						break;
					case 0x02:
						sessionType = "85";
						break;
					case 0x03:
						sessionType = "87";
						break;
					case 0x04:
						sessionType = "FE";
						break;
					case 0x05:
						sessionType = "FA";
						break;
					case 0x06:
						sessionType = "01";
						break;
					case 0x07:
						sessionType = "02";
						break;
					case 0x08:
						sessionType = "03";
						break;
				}
				startDiagnosticSession(sessionType);
				bruteforce();
	        }
	        catch (Exception ex)
	        {
	            addTxtLog("An error occurred, Stopping bruteforce attack: " + ex.Message);
	            // The method stops execution here if an exception is caught
	            return;
	        }
		}


		// /////////////////////////////////////////////////////////////////
	}
}
