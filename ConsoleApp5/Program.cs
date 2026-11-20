//struct  vs  class

//struct ve class arasindaki ferqler
//struct - value type                               | class - reference type
//struct - stack                                    | class - heap
//struct - inheritance yoxdur                       | class - inheritance var
//struct - default ctor olmur                       | class - default ctor olur
//struct - destructoru yoxdur                       | class - destructoru var
//struct - abstact,virtual,protected istifade etmir | class - istifade edir
//struct - default access modifieri public dir      | class - iprivate - dir
//struct - kicik strurukturlar ucun istifade edilir | class - boyuk isler gormek ucun istifade edilir
//struct - GC - istifade edilmir cunki stack de     | class - GC(Garbage Collector) istifade edilir



//Prooerty nedir - field + getter + setter
//esas istifade olunan 2 novu var autoproperty,fullproperty
//Burda c++ dan ferqli olaraq access modifier-ler her field,property,method ve sair qarisinda verilmelidir
//Auto property -de get ve set e mudaxil ede bilmirik
//Full propertyde get ve setde kodlar yaza bilirik
//Property icerisinde set yerine init yazsaq bu propertiye yalniz ctor icerisinde deyer vere bilirik sonradan deyeri deyismek olmur
//Struct ve ya Class -da object yaradarken deyer ctor dan deyilde bir basa obyektin yaninda {} icerisinde qeyd edilerek yaradilmasi Object Initializer adlanir

//using System.Diagnostics.CodeAnalysis;

//class Program
//{

//    //struct Test
//    //{
//    //    public int X;
//    //    public int Y { get; set; }
//    //    public int Z { get; }
//    //    public int D { get; init; }
//    //    public Test(int x, int y, int z, int d)
//    //    {
//    //        X = x;
//    //        Y = y;
//    //        Z = z;
//    //        D = d;
//    //    }
//    //    //private int myVar;

//    //    //public int MyProperty
//    //    //{
//    //    //    get { return myVar; }
//    //    //    set { myVar = value; }
//    //    //}
//    //}
//    //static void Main(string[] args)
//    //{

//    //    Test test = new Test(5,5,5,5);
//    //    //test.X = 5;
//    //    //test.Y = 5;
//    //    //Console.WriteLine(test.Y);
//    //    //test.Z = 5;
//    //    test.D = 10;
//    //}

//    //struct Person
//    //{
//    //    public string Gender { get; set; }
//    //    private string _name;

//    //    public string Name
//    //    {
//    //        get {
//    //            if (Gender == "Male") return "Mr " + _name;
//    //            else return "Ms " + _name;
//    //        }
//    //        set { _name = value; }
//    //    }
//    //    //public void showPerson() {
//    //    //    Console.WriteLine("Gender:"+Gender);
//    //    //    Console.WriteLine("Name:"+Name);
//    //    //}

//    //    public override string ToString()
//    //    {
//    //        return "Gender:"+Gender + "\n" +"Name:" +Name;
//    //    }
//    //}


//    //static void Main(string[] args)
//    //{
//    //    Person person = new Person()
//    //    { Gender = "Female", Name = "Durdane" };

//    //    //Console.WriteLine(person.Name);
//    //    //person.showPerson();
//    //    Console.WriteLine(person);

//    //}

//    //DateTime
//    //DateOnly
//    //TimeOnly


//    //static void Main(string[] args)
//    //{



//    //    //DateTime dateTime = new DateTime(1997, 4, 18);
//    //    //DateTime dateTime1 = DateTime.Now;
//    //    //Console.WriteLine(dateTime.ToString());
//    //    //Console.WriteLine(dateTime1.ToString());
//    //    //Console.WriteLine(dateTime1.ToLongTimeString());
//    //    //Console.WriteLine(dateTime1.ToLongDateString());
//    //    //Console.WriteLine(dateTime1.ToShortDateString());
//    //    //Console.WriteLine(dateTime1.ToShortTimeString());
//    //    //Console.WriteLine(dateTime1.ToUniversalTime());


//    //    //DateTime dateTime2 = DateTime.Now;
//    //    //DateTime dateTime1 = DateTime.Now.AddDays(5);

//    //    //DateTime dateTime1 = new DateTime(1997, 4, 18);
//    //    //DateTime dateTime2 = new DateTime(1997, 5, 18);


//    //    //TimeSpan tp = dateTime2 - dateTime1;
//    //    //Console.WriteLine(tp);



//    //}
//}


//Exe file - ise duse bilen istifade tek basina istifade olan bilen file
//DLL (Data Link Library) - tek basina run ola bilmeyen sadece icerisinde mueyyen kodlar yazilan file lardir
//Hem dll hemde exe file lari umumilikde assambly adlanir

//ve diger file icerisinde cagrila bilirler


//class Student
//{
//    private int test;
//    protected int test2;

//    public void foo()
//    {
//        test = 5;
//        test2 = 6;
//    }
//}

//Access Modifier 
//public  - solution el catilandir
//private - yalniz class daxilinder el catilandir
//protected - yalniz class icinde ve toreme class larda
//internal - yalniz 1 assambly daxilinde cata bilrik
//protected internal
//private protected

//class lar eger access modifier vermesek defeaul olaraq internal olur

//using Demo;

//Student student = new Student();






using Demo;

Student student1 = new Student(1,"Nazim","Nazimli",Specialty.Programming);
Student student2 = new Student(2, "Alcagulu", "Alcaguliyev", Specialty.It);
Student student3 = new Student(3, "Telman", "Nazimli", Specialty.Design);

List<Student> students = new List<Student>() { student1, student2, student3 };


Group group = new Group(1, "Group-1", students);