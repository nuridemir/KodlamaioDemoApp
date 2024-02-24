

using KodlamaioApp.Buisness.Concretes;
using KodlamaioApp.DataAccess.Concretes;
using KodlamaioApp.Entities.Concretes;

// Kategori işlemleri ==>
Console.WriteLine("======>Kategori işlemleri");
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
categoryManager.GetAll();
Console.WriteLine("------------------------");
Category ModaCategory = new Category { Id = 5, Name = "Moda", Description = "Moda kategorisi açıklaması" };
categoryManager.Add(ModaCategory);
Console.WriteLine("------------------------");
categoryManager.GetAll();
Console.WriteLine("------------------------");
categoryManager.Delete(1);
Console.WriteLine("------------------------");
categoryManager.GetAll();
Console.WriteLine("------------------------");
ModaCategory.Name = "Moda & Giyim";
ModaCategory.Description = "Moda & Giyim kategorisi açıklaması";
categoryManager.Update(ModaCategory);
categoryManager.GetAll();
Console.WriteLine("Kategori işlemleri<======");
// Kategori işlemleri <==

Console.WriteLine();
Console.WriteLine();

// Kurs işlemleri ==>
Console.WriteLine("======>Kurs işlemleri");
CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.GetAll();
Console.WriteLine("------------------------");
Course JavascriptCourse = new Course { Id = 7, Name = "JavaScript", Description = "JavaScript kursu açıklaması" };
courseManager.Add(JavascriptCourse);
Console.WriteLine("------------------------");
courseManager.GetAll();
Console.WriteLine("------------------------");
courseManager.Delete(1);
Console.WriteLine("------------------------");
courseManager.GetAll();
Console.WriteLine("------------------------");
JavascriptCourse.Name = "JavaScript +ES6";
JavascriptCourse.Description = "JavaScript +ES6 kursu açıklaması";
courseManager.Update(JavascriptCourse);
courseManager.GetAll();
Console.WriteLine("Kurs işlemleri<======");
// Kurs işlemleri <==

Console.WriteLine();
Console.WriteLine();

// Eğitmen işlemleri ==>
Console.WriteLine("======>Eğitmen işlemleri");
InstructorManager instructorManager = new InstructorManager(new InstructorDal());
instructorManager.GetAll();
Console.WriteLine("------------------------");
Instructor NuriInstructor = new Instructor { Id = 12, Name = "Nuri Demirr", Description = "Nuri Demir eğitmeni açıklaması" };
instructorManager.Add(NuriInstructor);
Console.WriteLine("------------------------");
instructorManager.GetAll();
Console.WriteLine("------------------------");
instructorManager.Delete(1);
Console.WriteLine("------------------------");
instructorManager.GetAll();
Console.WriteLine("------------------------");
NuriInstructor.Name = "Nuri DEMIR";
NuriInstructor.Description = "Nuri DEMIR eğitmeni açıklaması";
instructorManager.Update(NuriInstructor);
instructorManager.GetAll();
Console.WriteLine("Eğitmen işlemleri<======");
// Eğitmen işlemleri <==
