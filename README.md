# robotic_arm
6-Axis Arduino Based Robotic Arm

Devices used:

1) SainSmart 6-Axis Desktop Robotic Arm
2) Arduino UNO
3) Arduino Sensor Shield V5.0
4) 36W power supply
5) GUI

The motion of the robotic arm, in all the 6 axes, is given by two types of servomotors, 4 MG966R servos, and 2 SG90 servos. The robotic arm is controlled through an Arduino UNO motherboard, an Arduino Sensor Shield v5.0, and Visual C# GUI. In order to be able to control the servos, they are connected to the digital ports of the motherboard, to match the PWM signal type and thus to be able to control them. In order to supply enough power to make the servos work, the shield is connected to the Arduino UNO motherboard using connecting wires mother-father going from the digital I/O pins of the Arduino UNO motherboard to the digital I/O ports of the shield. The external power is connected to the motherboard using a female DC power connector, and thus bypass the power bridge of 3.3V. The GUI is written in Visual C#, Windows Form Application, and uses TrackBars to set the rotation angle of the servos. These values are transmitted to the Arduino program loaded into the board, which in turn sends the information to the servos.

Files in this project:

Servo Control.ino - Controller code in C

Robot GUI directory - GUI in C#

