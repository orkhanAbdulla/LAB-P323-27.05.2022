using System;

namespace Lab_P323_27._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Task-1
            //Group group = new Group();
            //group.No = "P323";
            //string answer;
            //do
            //{
            //    Student student = new Student();
            //    Console.WriteLine("input Fullname");
            //    student.Fullname = Console.ReadLine();
            //    Console.WriteLine("input Point");
            //    bool TryPoint = int.TryParse(Console.ReadLine(), out int point);
            //    student.Point = point;
            //    group.AddStudent(student);
            //    Console.WriteLine("Do you want to add student ? yes/no");
            //    answer = Console.ReadLine();
            //} while (answer=="yes");
            //Console.WriteLine("gorev tamam");
            //foreach (var item in group.students)
            //{
            //    Console.WriteLine($"{item.Fullname} {item.Point}");
            //}
            #endregion

            #region Task-2
            string password;

            do
            {
                Console.WriteLine("shifreni daxil edin");
                password = Console.ReadLine();
            } while (!User.PasswordChecked(password));

            User user = new User("Tural@Code", password);

            user.Fullname = "Tural Ismayilov";
            user.Password = "orxan";
            user.Showinfo();

            #endregion


        }

    }
}
