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
//using Cryptography.Obfuscation;
using System.Threading;
using System;
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
using System.Threading.Tasks;
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Bruteforcer
{
	public partial class Bruteforcer
	{
		byte ecuRxIdentifier1 = 0x07;
		byte ecuRxIdentifier2 = 0xE0;
		// /////
		// //////////////////////////
		// ////////////////////////////////////////
		// //////////////////////////////////////////////////////
		// ////////////////////////////////////////////////////////////////////
		// ///////////////////////////////////////////////////////////////////////////////////
		// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//  _______         _________________                                              __   _________                          .__  __            _____                                    
		//  \   _  \ ___  __\_____  \______  \_______   ____  ________ __   ____   _______/  |_/   _____/ ____   ____  __ _________|__|/  |_ ___.__. /  _  \   ____  ____  ____   ______ ______
		//  /  /_\  \\  \/  //  ____/   /    /\_  __ \_/ __ \/ ____/  |  \_/ __ \ /  ___/\   __\_____  \_/ __ \_/ ___\|  |  \_  __ \  \   __<   |  |/  /_\  \_/ ___\/ ___\/ __ \ /  ___//  ___/
		//  \  \_/   \>    </       \  /    /  |  | \/\  ___< <_|  |  |  /\  ___/ \___ \  |  | /        \  ___/\  \___|  |  /|  | \/  ||  |  \___  /    |    \  \__\  \__\  ___/ \___ \ \___ \ 
		//   \_____  /__/\_ \_______ \/____/   |__|    \___  >__   |____/  \___  >____  > |__|/_______  /\___  >\___  >____/ |__|  |__||__|  / ____\____|__  /\___  >___  >___  >____  >____  >
		//         \/      \/       \/                     \/   |__|           \/     \/              \/     \/     \/                       \/            \/     \/    \/    \/     \/     \/ 
		//sEcReT KeYs fRoM fOrScaN
		//'Carol', 'JAMES', 'Bosch', 'Flash', 'Bosch', 'FAITH', 'TAMER', 'REMAT', 'DIODE', 'Rowan', 'LAURA', 'JaMes', 'SAMMY', 'DIODE', 'conti', 'conti', 'Lupin', 'BOSEX', 'DIODE', 
		//'nowaR', 'PANDA', 'Jesus', 'Rowan', 'Flash', 'JAMES', 'GANES', 'SAMMY', 'Janis', 'COLIN', 'BOSCH', 'DIODE', 'Rowan', 'Rowan', 'ARIAN', 'ARIAN', 'DRIFT', 'BroWn', 'JaMes', 
		//'kbobA', '.Ted\', 'WALy\', 'euHUN', 'DRIFT', 'DRIFT', 'Flash', 'Bosch', 'Rowan', 'nowaR', 'DIODE', 'DIODE', 'DIODE', 'JaMes', 'conti', 'Rowan', 'MACOM', 'JAMES', 'MACOM', 
		//'MACOM', 'conti', 'Rowan', 'DIODE', 'BOSCH', 'JAMES', 'GANES', 'SKAND', 'FAITH', 'DIODE', 'OuTuY', 'slIor', '-MErM', 'pEde '
		/// <summary> SERVICE: 0X27 REQUEST SECURITY ACCESS seed keys 
		/// </summary>
		///         0x720: {0x01: 0x434f4c494e, 0x03: 0x40E234995F, 0x11: 0x0926F26388},
		///         0x720: {0x01: 0xfa5fc0, 0x03: 0x92c13b},
		///         0x7A6: {0x01: 0x4272616457, 0x11: 0x128665},
		///         0x727: {0x01: 0x42, 0x72, 0x61, 0x64, 0x57},
		///         0x767: {0x01: 0x4272616457}, 
		///         0x781: {0x01: 0x4272616457},
		///         0x731: {0x01: 0x672a70, 0x11: 0x462a71},0-
		///         0x760: {0x01: 0x5B4174657D, 0x03: 0x76807f, 0x11: 0x06316b}
		///////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// <summary>
		/// Security Access Function Calls with seed keys for midpeed can modules
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//////////////////////////////////////////////////////////////////
		//var obfuscator = new Obfuscator();
		//string obfuscatedID = obfuscator.Obfuscate(15);   // e.g. xVrAndNb
		// Reverse-process:
		//int deobfuscatedID = obfusactor.Deobfuscate(obfuscatedID);  // 15
		////////////////////////////////////////////////////////////////////
		// Seed Key Bruter Forcer
		void bruteforce()
		{
			try
			{
				Dictionary<string, int[]> keysDictionary = new Dictionary<string, int[]>
					{
					
				};
				// Brute-force loop
				textBoxSeed.Text = "";
				labelSeedFound.Visible = false;
				labelCnc.Visible = false;
				progressBar1.Value = 0x00;
				foreach (var kvp in keysDictionary)
				{
					//addTxt1($"Trying key: {keysDictionary.Key}");
					this.progressBar1.Value += 1;
					int[] keyValues = kvp.Value;
					if (requestSecurityAccess0x27(ecuId, ecuId2, keyValues[0], keyValues[1], keyValues[2], keyValues[3], keyValues[4]) == true)
					{
						addTxtLog("Found Seed: " + keyValues[0] + keyValues[1] + keyValues[2] + keyValues[3] + keyValues[4] + "\r\n");
						string seedKey = keyValues[0] + ", " + keyValues[1] + ", " + keyValues[2] + ", " + keyValues[3] + ", " + keyValues[4];
						textBoxSeed.Text += seedKey;
						this.progressBar1.Value = 483;
						labelSeedFound.Visible = true;
						break;
					}
					if (labelCnc.Visible == true)
					{
						break;
					}
					else
					{
						addTxtLog("Key Failed, trying next... \r\n");
						continue;
					}
				}
			}
			catch (Exception ex)
			{
				// Catching any exception of type Exception
				// Handle the exception here, such as logging or displaying an error message
				addTxtLog("Security Access Error: " + ex.Message);
				return;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// <summary>
		/// STANDARD SECURITY ACCESS SERVICE 0x27 BOOLEAN - Mark I Algo "KeyGenMkI(int s, int sknum, int sknum2, 
		///                                                                 int sknum3, int sknum4, int sknum5)"
		/// </summary>
		/// <returns>true or false</returns>
		///////////////////////////////////////////////////////////////////////////////////////////////////
		bool requestSecurityAccess0x27(byte ecuId, byte ecuId2, int seedkey0, int seedkey1, int seedkey2, int seedkey3, int seedkey4)
		{
			try
			{
				var num = 0;
				addTxtLog("Service: [0x27 reqSecurityAccess]\r\n");
				byte[] requestSecurityAccess = new byte[] { 0, 0, ecuId, ecuId2, 0x27, 0x01 };
				string requestSecurityAccessMsg = sendPassThruMsg(requestSecurityAccess);
				// parse response and build seed key algo into flow...
				//00  00  07  AE  67  01  AF  BB  7F 
				string responseData = requestSecurityAccessMsg.Replace(" ", "");
				string firstResponse = responseData.Substring(8, 2);
				int response01 = int.Parse(firstResponse, System.Globalization.NumberStyles.HexNumber);
				switch (response01)
				{
					case 0x67:
						addTxtLog("Security Seed Requested.\r\n");
						break;
					case 0x7F:
						//00  00  07  28  7F  27  22  
						string cnc = responseData.Substring(12, 2);
						int cnc01 = int.Parse(cnc, System.Globalization.NumberStyles.HexNumber);
						if (cnc01 == 0x22)
						{
							addTxtLog("0x22 Conditions Not Correct \r\n");
							labelCnc.Visible = true;
						}
						break;
				}
				string seed = responseData.Substring(12, 6);
				addTxtLog("Security Seed: " + seed + "\r\n");
				string rxbuf3 = responseData.Substring(12, 2);
				string rxbuf4 = responseData.Substring(14, 2);
				string rxbuf5 = responseData.Substring(16, 2);
				addTxtLog("Converting Seed to Int32: " + rxbuf3 + rxbuf4 + rxbuf5 + "\r\n");
				int buf3 = Convert.ToInt32(rxbuf3, 16);
				int buf4 = Convert.ToInt32(rxbuf4, 16);
				int buf5 = Convert.ToInt32(rxbuf5, 16);
				addTxtLog("Calculating Response. \r\n");
				var num22 = 0;
				num22 += buf3 << 0x10;
				num22 += buf4 << 8;
				num22 += buf5;
				string responseKey = KeyGenMkI(num22, seedkey0, seedkey1, seedkey2, seedkey3, seedkey4).ToString("X6");
				string response1 = responseKey.Substring(0, 2);
				string response2 = responseKey.Substring(2, 2);
				string response3 = responseKey.Substring(4, 2);
				byte responseByte1 = Convert.ToByte(response1, 16);
				byte responseByte2 = Convert.ToByte(response2, 16);
				byte responseByte3 = Convert.ToByte(response3, 16);
				byte[] requestSecurityAccess02 = new byte[] { 0, 0, ecuId, ecuId2, 0x27, 0x02, responseByte1, responseByte2, responseByte3 };
				string requestSecurityAccess02Msg = sendPassThruMsg(requestSecurityAccess02);
				string responseDataA = requestSecurityAccess02Msg.Replace(" ", "");
				string responseDataB = responseDataA.Substring(8, 2);
				//  00  00  07  2F  67  02  
				int response = int.Parse(responseDataB, System.Globalization.NumberStyles.HexNumber);
				switch (response)
				{
					case 0x67:
						addTxtLog("Security Access Granted.\r\n");
						return true;
					case 0x7F:
						addTxtLog("Security Access Denied. \r\n");
						return false;
				}
				return false;
			}
			catch (Exception ex)
			{
				// Catching any exception of type Exception
				// Handle the exception here, such as logging or displaying an error message
				addTxtLog("ECU error occurred: " + ex.Message);
			}
			return false;
		}
		// ##################################################################################################################
		
		
		// // // /// // // // // // // // // // 
		//
		int KeyGenMkI(int s, int sknum, int sknum2, int sknum3, int sknum4, int sknum5)
		{
			var sknum13 = (int)((byte)(s >> 0x10 & 0xFF));
			var b2 = (byte)(s >> 8 & 0xFF);
			var b3 = (byte)(s & 0xFF);
			var sknum6 = (sknum13 << 0x10) + ((int)b2 << 8) + (int)b3;
			var sknum7 = (sknum6 & 0xFF0000) >> 0x10 | (sknum6 & 0xFF00) | sknum << 0x18 | (sknum6 & 0xFF) << 0x10;
			var sknum8 = 0xC541A9;
			for (int i = 0; i < 0x20; i++)
			{
				int sknum10;
				int sknum9;
				sknum8 = (((sknum9 = (sknum10 = (((sknum7 >> i & 1) ^ (sknum8 & 1)) << 0x17 | sknum8 >> 1))) & 0xEF6FD7) | ((sknum9 & 0x100000) >> 0x14 ^ (sknum10 & 0x800000) >> 0x17) << 0x14 | ((sknum8 >> 1 & 0x8000) >> 0xF ^ (sknum10 & 0x800000) >> 0x17) << 0xF | ((sknum8 >> 1 & 0x1000) >> 0xC ^ (sknum10 & 0x800000) >> 0x17) << 0xC | 0x20 * ((sknum8 >> 1 & 0x20) >> 5 ^ (sknum10 & 0x800000) >> 0x17) | 8 * ((sknum8 >> 1 & 8) >> 3 ^ (sknum10 & 0x800000) >> 0x17));
			}
			for (int j = 0; j < 0x20; j++)
			{
				int sknum12;
				int sknum11;
				sknum8 = (((sknum11 = (sknum12 = ((((sknum5 << 0x18 | sknum4 << 0x10 | sknum2 | sknum3 << 8) >> j & 1) ^ (sknum8 & 1)) << 0x17 | sknum8 >> 1))) & 0xEF6FD7) | ((sknum11 & 0x100000) >> 0x14 ^ (sknum12 & 0x800000) >> 0x17) << 0x14 | ((sknum8 >> 1 & 0x8000) >> 0xF ^ (sknum12 & 0x800000) >> 0x17) << 0xF | ((sknum8 >> 1 & 0x1000) >> 0xC ^ (sknum12 & 0x800000) >> 0x17) << 0xC | 0x20 * ((sknum8 >> 1 & 0x20) >> 5 ^ (sknum12 & 0x800000) >> 0x17) | 8 * ((sknum8 >> 1 & 8) >> 3 ^ (sknum12 & 0x800000) >> 0x17));
			}
			return (sknum8 & 0xF0000) >> 0x10 | 0x10 * (sknum8 & 0xF) | ((sknum8 & 0xF00000) >> 0x14 | (sknum8 & 0xF000) >> 8) << 8 | (sknum8 & 0xFF0) >> 4 << 0x10;
		}
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		

	
		// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	}
}
