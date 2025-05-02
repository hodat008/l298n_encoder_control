// ==== Motor Control Pins ====
const int ena = 5;
const int in1 = 6;
const int in2 = 7;

// ==== Encoder Pins ====
const int encoderPinA = 2;
const int encoderPinB = 3;

// ==== Encoder Variables ====
volatile long encoderCount = 0;
const int pulsesPerRevolution = 16;
const float gearRatio = 75.0;

// ==== PID Parameters ====
float kp = 0.5;
float ki = 0.01;
float kd = 0.1;

float error = 0;
float prevError = 0;
float integral = 0;
int pwmOutput = 0;

// ==== Control Variables ====
String data = "stop";
int value = 0;
bool isMoving = false;

void setup() {
  // Initialize motor control pins
  pinMode(ena, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);

  // Initialize encoder pins
  pinMode(encoderPinA, INPUT_PULLUP);
  pinMode(encoderPinB, INPUT_PULLUP);

  // Attach interrupt to encoder channel A
  attachInterrupt(digitalPinToInterrupt(encoderPinA), encoderISR, CHANGE);

  // Start serial communication
  Serial.begin(9600);
}

void loop() {
  String input = "";

  // === Read serial input ===
  if (Serial.available() > 0) {
    input = Serial.readStringUntil('\n');
    input.trim(); // Remove trailing characters

    if (input != "") {
      if (isNumber(input)) {
        value = input.toInt();
        data = "none";
        encoderCount = 0;  // Reset encoder before each movement
        isMoving = true;
      } else {
        data = input;
      }
    }
  }

  // === Copy encoder count safely ===
  long countCopy;
  noInterrupts();
  if (data == "reset" || value == 0) {
    encoderCount = 0;
    countCopy = encoderCount;
  } else {
    countCopy = encoderCount;
  }
  interrupts();

  // === Calculate angle ===
  float Angle = (countCopy / (pulsesPerRevolution * gearRatio)) * 360.0;
  Serial.print("Pulses: ");
  Serial.print(countCopy);
  Serial.print(" | Angle: ");
  Serial.println(Angle);

  // === Manual motor commands ===
  if (data == "rotate_right") {
    motor_left();
  } else if (data == "rotate_left") {
    motor_right();
  } else if (data == "stop" || data == "reset") {
    motor_stop();
  }

  // === PID control ===
  if (isMoving) {
    error = value - encoderCount;
    integral += error;
    float derivative = error - prevError;
    prevError = error;

    float output = kp * error + ki * integral + kd * derivative;
    pwmOutput = constrain(abs(output), 0, 255);  // Limit PWM to 0–255

    if (error > 0) {
      analogWrite(ena, pwmOutput);
      digitalWrite(in1, HIGH);
      digitalWrite(in2, LOW);
    } else if (error < 0) {
      analogWrite(ena, pwmOutput);
      digitalWrite(in1, LOW);
      digitalWrite(in2, HIGH);
    } else {
      motor_stop();
      isMoving = false;
      integral = 0;
      prevError = 0;
    }
  }
}

// ==== Utility function to check if input string is a number ====
bool isNumber(String str) {
  for (unsigned int i = 0; i < str.length(); i++) {
    if (!isDigit(str[i]) && str[i] != '.' && str[i] != '-') {
      return false;
    }
  }
  return true;
}

// ==== Motor Control Functions ====
void motor_right() {
  analogWrite(ena, 120);  // Set PWM
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
}

void motor_left() {
  analogWrite(ena, 120);
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
}

void motor_stop() {
  analogWrite(ena, 0);
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
}

// ==== Encoder Interrupt Service Routine ====
void encoderISR() {
  bool A = digitalRead(encoderPinA);
  bool B = digitalRead(encoderPinB);

  if (A == B) {
    encoderCount++;
  } else {
    encoderCount--;
  }
}
