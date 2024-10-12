//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//// where 
//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//var result = numbs.Where(x=> x%2 == 0);

//foreach(var x in result)
//{
//    Console.WriteLine(x);
//}


//List<Student> students = new List<Student> {
//    new Student {Isim ="berkay", Not =10 } ,
//    new Student {Isim ="Melis", Not =90 } ,
//};

//var result1 = students.Where(x => x.Not>=60);

//foreach(var x in result1)
//{ Console.WriteLine(x.Isi); }
//class Student
//{
//    public string Isim { get; set; }
//    public int  Not { get; set; }
//}

List<Student> studentList = new List<Student> { new Student("asım", 46), new Student("Berkay", 90), new Student("Ömer", 88), new Student("Tahir", 55), new Student("Murat", 87) };

var result = studentList.Select(x => new StudentDto { Name = x.Isim, Grade = x.Not });

foreach (var student in result)
{
    Console.WriteLine(student);
    Console.WriteLine(student.Name);
    Console.WriteLine(student.Grade);
}
class Student
{
    public Student(string isim, int not)
    {
        Isim = isim;
        Not = not;
    }
    public string Isim { get; set; }
    public int Not { get; set; }
}

class StudentDto
{
    public string Name { get; set; }
    public int Grade { get; set; }
}
