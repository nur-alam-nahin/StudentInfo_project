using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student_information.StudentInfo> _studentInfo = new List<student_information.StudentInfo>();

            int _studentId;
            string _studentFirstName;
            string _studentLastName;
            string _studentEmail;
            string _department;
            string _session;
            char _section;
            string _gender;
            int _phoneNumber;


        int num;

            do
            {
                Console.WriteLine();
                Console.WriteLine("------menu------");
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. All Information");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your Choise = ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                if (num >= 1 && num <= 3)
                {
                    switch (num)
                    {
                        case 1:
                            Console.Write("Enter Id = ");
                            _studentId = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter First Name = ");
                            _studentFirstName = Console.ReadLine();

                            Console.Write("Enter First Name = ");
                            _studentLastName = Console.ReadLine();

                            Console.Write("Enter First Name = ");
                            _department = Console.ReadLine();

                            Console.Write("Enter First Name = ");
                            _session = Console.ReadLine();

                            Console.Write("Enter First Name = ");
                            _section = Convert.ToChar(Console.ReadLine());

                            Console.Write("Enter First Name = ");
                            _gender = Console.ReadLine();

                            Console.Write("Enter First Name = ");
                            _phoneNumber = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Email = ");
                            _studentEmail = Console.ReadLine();

                            student_information.StudentInfo _student = new student_information.StudentInfo();

                            _student._id = _studentId;
                            _student._FirstName = _studentFirstName;
                            _student._lastName = _studentLastName;
                            _student._dept = _department;
                            _student._session = _session;
                            _student._section = _section;
                            _student._gender = _gender;
                            _student._phoneNumber = _phoneNumber;
                            _student._email = _studentEmail;




                            _studentInfo.Add(_student);

                            Console.WriteLine();
                            break;

                        case 2:

                            int _searchNum;
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("----Search menu----");
                                Console.WriteLine("1. search Id");
                                Console.WriteLine("2. Search Name");
                                Console.WriteLine("3. Exit");

                                Console.Write("Enter your Choise = ");
                                _searchNum = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();

                                if (_searchNum >= 1 && _searchNum <= 2)
                                {
                                    switch (_searchNum)
                                    {
                                        case 1:
                                            Console.Write("Search student Id = ");
                                            int _stdId = Convert.ToInt32(Console.ReadLine());
                                            var _stdIdData = _studentInfo.Where(x => x._id == _stdId);

                                            int notFoundId = 0;
                                            foreach (var item in _stdIdData)
                                            {
                                                notFoundId = item._id;
                                                Console.WriteLine();
                                                Console.WriteLine("----result----");
                                                Console.WriteLine();
                                                Console.WriteLine($"student id = {item._id}");
                                                Console.WriteLine($"student First name = {item._FirstName}");
                                                Console.WriteLine($"student Last name = {item._lastName}");
                                                Console.WriteLine($"student Last name = {item._dept}");
                                                Console.WriteLine($"student Last name = {item._session}");
                                                Console.WriteLine($"student Last name = {item._section}");
                                                Console.WriteLine($"student Last name = {item._gender}");
                                                Console.WriteLine($"student Last name = {item._phoneNumber}");
                                                Console.WriteLine($"student email = {item._email}");



                                            }

                                            if (notFoundId != _stdId)
                                            {
                                                Console.WriteLine("not found");
                                            }


                                            break;

                                        case 2:

                                            Console.Write("Search Student Name = ");
                                            string _stdName = Console.ReadLine();

                                            var _stdNameData = _studentInfo.Where(x => x._FirstName  == _stdName);


                                            string notFound = "";

                                            foreach (var item in _stdNameData)
                                            {
                                                notFound = item._FirstName;
                                                

                                                Console.WriteLine();
                                                Console.WriteLine("----result----");
                                                Console.WriteLine();
                                                Console.WriteLine($"student id = {item._id}");
                                                Console.WriteLine($"student First name = {item._FirstName}");
                                                Console.WriteLine($"student Last name = {item._lastName}");
                                                Console.WriteLine($"student Last name = {item._dept}");
                                                Console.WriteLine($"student Last name = {item._session}");
                                                Console.WriteLine($"student Last name = {item._section}");
                                                Console.WriteLine($"student Last name = {item._gender}");
                                                Console.WriteLine($"student Last name = {item._phoneNumber}");
                                                Console.WriteLine($"student email = {item._email}");

                                            }

                                            if (notFound != _stdName)
                                            {
                                                Console.WriteLine("Not Found");
                                            }

                                            break;

                                    }
                                }

                            }
                            while (_searchNum != 3);



                            Console.WriteLine();

                            break;

                        case 3:
                            foreach (var item in _studentInfo)
                            {
                                Console.WriteLine("----result----");
                                Console.WriteLine();
                                Console.WriteLine($"student id = {item._id}");
                                Console.WriteLine($"student First name = {item._FirstName}");
                                Console.WriteLine($"student Last name = {item._lastName}");
                                Console.WriteLine($"student Last name = {item._dept}");
                                Console.WriteLine($"student Last name = {item._session}");
                                Console.WriteLine($"student Last name = {item._section}");
                                Console.WriteLine($"student Last name = {item._gender}");
                                Console.WriteLine($"student Last name = {item._phoneNumber}");
                                Console.WriteLine($"student email = {item._email}");


                                Console.WriteLine();
                            }

                            break;
                    }
                }
            }
            while (num != 4);
        }
    }
}
