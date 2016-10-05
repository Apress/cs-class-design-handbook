using System;

public class Teacher
{
   int grade = 0;

   public Teacher(int grade){
      if(grade < 3) new Teacher();
      this.grade= grade;
   	Console.WriteLine("Called Public Teacher..");
   	
   }

   private Teacher(){
   	Console.WriteLine("Called Private Teacher..");
     try{
        throw new Exception("Grade error");
     	     }
     catch(Exception e) {
        throw e;
     }
     
  }

   static void Main(string[] args)
   {
        Teacher teach = new Teacher(5);
   }           
}


