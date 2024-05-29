# Ford-ECU-Bruteforcer

<a href="https://testerpresent.com.au/"><img src="https://img.shields.io/badge/Tester Present -Specialist Automotive Solutions-blue" /></a>

Bruteforce Security Access on Ford ECU's

I have tested this on an Audio Control Module, an Audio Interface Module and an Instrument Cluster with success. Uses the keybag from the Ford Hack to bruteforce 0x27 Security Access, and finds a matching key that unlocks the module. Options to select Midspeed or High Speed CAN, and options to select which type of diagnostic session you want to try the bruteforce in, handles 0x7F errors by aborting the bruteforce attempt. This should work on any Ford ECU that is pre 2011, assuming it is a 3 Byte Seed and a 5 Byte Key.

## Updated on 24/05/2024
I have rejigged the user interface and implemented 18 Volts FEPS on OBD pin 13, so this will now hypothetically also be able to unlock Ford Powertrain Control Modules that require FEPS voltage to unlock security access. Also added a bunch of keys pulled out of Forscan with Ghidra.

## Interface
Development done with an OBDxPro FT J2534 interface. <a href="https://obdxpro.com/product/obdx-pro-fx-ford-obd2-j2534-diagnostics-and-tuning/?ref=jakka351">https://obdxpro.com/product/obdx-pro-fx-ford-obd2-j2534-diagnostics-and-tuning/</a>

## User Interface Updated 24/05/24
![image](https://github.com/jakka351/Ford-ECU-Bruteforcer/assets/57064943/6674f594-5326-48ad-9a13-61a29fff8dbb)

