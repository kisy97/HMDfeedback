// 워터 펌프 핀번호
int AA = 5;
int BB = 6;

//입력값 변수
char command; 

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(AA, OUTPUT);
  pinMode(BB, OUTPUT);

}

void loop() {
  // put your main code here, to run repeatedly:
  //입력값을 받았을 경우
  
  if(Serial.available() > 0) 
  {
    command = Serial.read();
    // 실행 입력값일 경우 워터펌프 킨다.
    if(command == 'a') 
    {
      digitalWrite(AA,HIGH);
      digitalWrite(BB,LOW);
    }
    // 종료 입력값일 경우 워터펌프를 종료한다.
    else if(command == 's') 
    {
      digitalWrite(AA,LOW);
      digitalWrite(BB,LOW);
    }
  }

}
