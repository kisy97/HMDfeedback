int AA = 5;
int BB = 6;

char command;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(AA, OUTPUT);
  pinMode(BB, OUTPUT);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available > 0) 
  {
    if(command == 'a') 
    {
      digitalWrite(AA,HIGH);
      digitalWrite(BB,LOW);
    }
    else if(command == 's') 
    {
      digitalWrite(AA,LOW);
      digitalWrite(BB,LOW);
    }
  }

}
