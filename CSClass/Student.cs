namespace CSClass
{
     class Student
    {
        public string name; //이름
        public int grade; //학년

        //학생 객체 문자열 출력 메서드
        public override string ToString()
        {
            return this.name+":"+this.grade; //이름 +: +학점 문자열 리턴 
        }

    }
}