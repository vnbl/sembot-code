# sembot-code

This is the code for the graphic interface and artificial vision of Sembot, a prototype of an autonomous vehicle that plants different types of seeds in an open field.

Vehicle: The vehicle is equipped with the following sensors and actuators:
- Two high torque DC motors (recicled from an old car).
- H-bridge circuit for controling the motors.
- Magnetometers.
- Distance sensors to avoid obstacles.
- All this is controlled with an Arduino in a master-slave configuration with a Raspberry Pi.

Seed distribution with artificial vision: The vehicle is equipped with 3 seed dispensers with motors and a camera connected to a Raspberry Pi. The Raspberry Pi has code in it to read QR code. To use sembot, we put signs with QR code in the field and sembot dispenses different types of seeds according to what it reads from the QR code.

