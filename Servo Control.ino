#include <Servo.h>

int servoCount = 6;
int servoPins[] = {3, 5, 6, 9, 10, 11};
Servo servos[6];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  AttachServos();


}

void loop() {
  // put your main code here, to run repeatedly:

}
void serialEvent() {
  int channel;
  int pos;
  if (Serial.available() > 0) {

    channel = Serial.readStringUntil(':').toInt();
    pos = Serial.readStringUntil('*').toInt();
    servos[channel].write(pos);
    
  }
}

void AttachServos() {
  for (int i = 0; i < servoCount; i++) {
    servos[i].attach(servoPins[i]);
  }
}






