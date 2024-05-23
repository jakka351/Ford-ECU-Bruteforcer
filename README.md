# Ford-ECU-Bruteforcer

<a href="https://testerpresent.com.au/"><img src="https://img.shields.io/badge/Tester Present -Specialist Automotive Solutions-blue" /></a>

Bruteforce Security Access on Ford ECU's

I have tested this on an Audio Control Module, an Audio Interface Module and an Instrument Cluster with success. Uses the keybag from the Ford Hack to bruteforce 0x27 Security Access, and finds a matching key that unlocks the module. Options to select Midspeed or High Speed CAN, and options to select which type of diagnostic session you want to try the bruteforce in, handles 0x7F errors by aborting the bruteforce attempt. This should work on any Ford ECU that is pre 2011, assuming it is a 3 Byte Seed and a 5 Byte Key.

## Interface
Development done with an OBDxPro FT J2534 interface. <a href="https://obdxpro.com/product/obdx-pro-fx-ford-obd2-j2534-diagnostics-and-tuning/?ref=jakka351">https://obdxpro.com/product/obdx-pro-fx-ford-obd2-j2534-diagnostics-and-tuning/</a>

## User Interface
![image](https://github.com/jakka351/Ford-ECU-Bruteforcer/assets/57064943/41386f2e-4357-4f20-a3a7-ac2af29046e3)

## Error Handling
![image](https://github.com/jakka351/Ford-ECU-Bruteforcer/assets/57064943/d9bcd70a-90e3-4523-86af-fa4658074ee0)
