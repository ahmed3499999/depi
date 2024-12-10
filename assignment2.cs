Student s1 = new Student("Hamoda", 20, "A");
Student s2 = new Student("Hamada", 22, "B+");

s1.DisplayInfo();
s2.DisplayInfo();

class Student{
    private String name;
    private int age;
    private String grade;

    public Student(String name, int age, String grade) {
        this.name = name;
        this.age = age;
        this.grade = grade;        
    }

    public void DisplayInfo(){
        Console.WriteLine("Name: " + this.name + "\nAge: " + this.age.ToString() + "\nGrade: " + this.grade);
    }
}
