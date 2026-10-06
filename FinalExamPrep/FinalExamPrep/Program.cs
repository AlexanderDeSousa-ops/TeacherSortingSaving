using System;
using System.IO;
using System.Collections; //need this for stack and queue
namespace FinalExamPrep
{
    internal class Program
    {
        static string FILENAME = "database.txt";

        static void Main(string[] args)
        {
            RoomManager roomManager = new RoomManager(10);
            int choice = 0;

            try
            {
                do
                {
                    Console.WriteLine("\nMain Menu");
                    Console.WriteLine("1: Add Teacher");
                    Console.WriteLine("2: Add Student");
                    Console.WriteLine("3: Add Faculty");
                    Console.WriteLine("4: Display All");
                    Console.WriteLine("5: Sort by Name");
                    Console.WriteLine("6: Sort by ID");
                    Console.WriteLine("7: Add File Info");
                    Console.WriteLine("8: Display File Info");
                    Console.WriteLine("9: Copy File");
                    Console.WriteLine("10: Exit");
                    Console.Write("Enter choice: ");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter ID: ");
                            int tId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            string tName = Console.ReadLine();

                            Console.Write("Enter Surname: ");
                            string tSurname = Console.ReadLine();

                            Console.Write("Enter Subject: ");
                            string subject = Console.ReadLine();

                            Console.Write("Enter Experience: ");
                            int exp = int.Parse(Console.ReadLine());

                            Teacher teacher = new Teacher(tId, tName, tSurname, subject, exp);
                            roomManager.AddRoom(teacher);

                            break;

                        case 2:
                            Console.Write("Enter ID: ");
                            int sId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            string sName = Console.ReadLine();

                            Console.Write("Enter Surname: ");
                            string sSurname = Console.ReadLine();

                            Console.Write("Enter Grade: ");
                            double grade = double.Parse(Console.ReadLine());

                            Console.Write("Enter Group: ");
                            string group = Console.ReadLine();

                            Student student = new Student(sId, sName, sSurname, grade, group);
                            roomManager.AddRoom(student);
                            break;

                        case 3:
                            Console.Write("Enter ID: ");
                            int fId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            string fName = Console.ReadLine();

                            Console.Write("Enter Surname: ");
                            string fSurname = Console.ReadLine();

                            Console.Write("Enter Years Worked: ");
                            int years = int.Parse(Console.ReadLine());

                            Console.Write("Enter Tasks Completed: ");
                            int tasks = int.Parse(Console.ReadLine());

                            Facalty faculty = new Facalty(fId, fName, fSurname, years, tasks);
                            roomManager.AddRoom(faculty);
                            break;

                        case 4:
                            roomManager.DisplayAll();
                            break;

                        case 5:
                            roomManager.SortByName();
                            Console.WriteLine("Sorted by name.");
                            break;

                        case 6:
                            roomManager.SortByID();
                            Console.WriteLine("Sorted by ID.");
                            break;

                        case 7:
                            AddInfo();
                            break;

                        case 8:
                            DisplayInfo();
                            break;

                        case 9:
                            CopyFile();
                            break;

                        case 10:
                            Console.WriteLine("Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                } while (choice != 10);

                //==================================queue meathods
                Queue<string> myq = new Queue<string>();

                myq.Enqueue("kevin");
                myq.Enqueue("micheal");
                myq.Enqueue("alex");


                //Console.WriteLine(myq);  cant print like this has to be foreach

                foreach (string nameT in myq)
                {
                    Console.WriteLine(nameT + " ");
                }

                //peak meathod looks at the first element
                Console.WriteLine("the first element to deque is " + myq.Peek());

                //count meathod counts the number of elements
                Console.WriteLine("the element of the count is " + myq.Count());

                //contains meathod checks if the elemnt is there
                Console.WriteLine("does the que contain alex ?" + myq.Contains("alex"));

                //removes the first element in the que
                myq.Dequeue();
                myq.Dequeue();


                foreach (string nameT in myq)
                {
                    Console.WriteLine(nameT + " ");
                }

                //makes it an array
                string[] names = myq.ToArray();

                //clear all elements
                myq.Clear();

                Console.WriteLine("Hello, World!");


                MyQueue<int> myqN = new MyQueue<int>(5);

                //myq.Print();

                myqN.Enqueue(10);
                myqN.Enqueue(20);
                myqN.Enqueue(30);
                myqN.Enqueue(40);


                myqN.Print();

                //==================================stack meathods 

                Stack mystack = new Stack();

                mystack.Push(10);
                mystack.Push(20);
                mystack.Push(30);
                mystack.Push(40);
                mystack.Push(50);

                Console.WriteLine("Stack elements are:");
                foreach (var item in mystack)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("lest pop 2 items from stack");
                mystack.Pop();
                mystack.Pop();

                Console.WriteLine("after poping 2 items from stack");
                foreach (var item in mystack)
                {
                    Console.WriteLine(item);
                }

                int myf = (int)mystack.Peek();
                mystack.Pop();
                int mys = (int)mystack.Peek();
                mystack.Pop();

                mystack.Push(myf);
                mystack.Push(mys);

                Console.WriteLine("peek element is:" + mystack.Peek());

                Console.WriteLine("Stack elements are:");
                foreach (var item in mystack)
                {
                    Console.WriteLine(item);
                }


                Console.WriteLine("Count of stack is:" + mystack.Count);



                //To the array
                object[] myarr = mystack.ToArray();

                Console.WriteLine("Show the array");
                for (int i = 0; i < myarr.Length; i++)
                {
                    Console.Write(myarr[i] + "   ");
                }

                Console.WriteLine("\nClear the stack");
                mystack.Clear();

                

                MyStack<int> stack = new MyStack<int>(5);

                MyStack<string> stack2 = new MyStack<string>(5);

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);


                stack.Display();

                Console.WriteLine("top the elemt of the stack " + stack.Peek());

                Console.WriteLine("lets pop some elements ");
                // stack.Pop();
                Console.WriteLine("poped element: " + stack.Pop());
                stack.Display();

                Console.WriteLine("contains 2 :" + stack.Contains(2));
                Console.WriteLine("contains 8 :" + stack.Contains(8));

                int[] myarr1 = stack.ToArray();
                Console.WriteLine("Show the array");
                foreach (var item in myarr1)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();

                Console.WriteLine("clear the stack");
                stack.Clear();

                stack.Display();

                Console.WriteLine("lets pop the array");
                stack.Pop();

                //================================== Generic Stack meathods

                Console.WriteLine("lets make generic objects");
                Console.WriteLine("enter the id of student 1");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the name of student 1");
                string name = Console.ReadLine();

                GenericClass<int, string> student1 = new GenericClass<int, string>(id, name);

                Console.WriteLine("information student 1");
                student1.ShowInfo();

                Console.WriteLine("");
                Console.WriteLine("enter the id of student 1");
                int id2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the name of student 1");
                string name2 = Console.ReadLine();

                GenericClass<int, string> student2 = new GenericClass<int, string>(id2, name2);

                student2.ShowInfo();

                Console.WriteLine("enter the name of product");
                string product1 = Console.ReadLine();

                Console.WriteLine("enter the price");
                double price1 = Convert.ToDouble(Console.ReadLine());

                GenericClass<string, double> prod1 = new GenericClass<string, double>(product1, price1);

                prod1.ShowInfo();


                //array
                //int[] myarr2 = new int[3];
                // myarr[0] = "st"; giving you error

                //Creating arraylist

                ArrayList myarlist = new ArrayList();
                myarlist.Add(10);
                myarlist.Add("alex");
                myarlist.Add(3.14);
                myarlist.Add(true);
                myarlist.Add(false);
                Console.WriteLine("inserting element");
                myarlist.Insert(4, "test"); //4 is the position

                Console.WriteLine("Elements of ArrayList:");
                //var means any element
                foreach (var item in myarlist)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
                Console.WriteLine("changing the false elemet");
                myarlist[5] = "Somthing else";

                foreach (var item in myarlist)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
                myarlist.InsertRange(2, new string[] { "hello , world" });
                Console.WriteLine("after change");
                foreach (var item in myarlist)
                {
                    Console.Write(item + "  ");
                }

                Console.WriteLine();

                Console.WriteLine("removing exact element");
                myarlist.Remove("test");

                Console.WriteLine("remove elememt at index");
                myarlist.RemoveAt(3);

                Console.WriteLine("display");
                foreach (var item in myarlist)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();

                Console.WriteLine("remove 3 elements from index 2");
                myarlist.RemoveRange(2, 3);

                Console.WriteLine("display");
                foreach (var item in myarlist)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();

                Console.WriteLine("the clear metheod delets everything");
                myarlist.Clear();


                bool testing = myarlist.Contains("hello");
                Console.WriteLine("is hello present in array list " + testing);
                myarlist.Add("alex");
                int index = myarlist.IndexOf("ales");
                Console.WriteLine("is alex present in array list " + testing);

                //if teh arraylist is mixed
                myarlist.Reverse();

                Console.WriteLine("After reversing the ArrayList:");
                foreach (var item in myarlist)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();

                //sorting
                ArrayList numbers = new ArrayList() { 3, 22, 1, 64, 23, 566, 2, 4, 1 };
                //printing before sorting
                Console.WriteLine("Before sorting:");
                foreach (var item in numbers)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();

                numbers.Sort();

                Console.WriteLine("After sorting:");
                foreach (var item in numbers)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();


                //count number of elements in arraylist
                int count = myarlist.Count;
                Console.WriteLine("Number of elements in the ArrayList: " + count);


                //copy the arraylist to another arraylist

                ArrayList copylist = new ArrayList(myarlist);

                Console.WriteLine("Elements of the copied ArrayList:");
                foreach (var item in copylist)
                {
                    Console.Write(item + "   ");
                }


                //conerting to array
                Object[] myarray = new Object[count];
                myarray = myarlist.ToArray();


                //forloop
                for (int i = 0; i < count; i++)
                {
                    Console.Write(myarlist[i] + "  ");

                }
                //arraylist of object
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Program finished.");
        }

        // =========================
        // FILE METHODS (KEPT SIMPLE)
        // =========================
        public static void FileCopy(StreamReader sr, StreamWriter sw)
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                sw.WriteLine(line);
            }
        }

        public static void AddInfo()
        {
            try
            {
                StreamWriter sw = new StreamWriter(FILENAME, true);

                Console.Write("Enter document id: ");
                string id = Console.ReadLine();

                Console.Write("Enter document name: ");
                string name = Console.ReadLine();

                sw.WriteLine(id + " " + name);
                Console.WriteLine("Document added.");

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void CountLines()
        {
            int count = 0;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(FILENAME);

                while ((sr.ReadLine()) != null)
                {
                    count++;
                }
                Console.WriteLine("the number of the line is " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }

            sr.Close();
        }
        public static void SearchName()
        {
            Console.WriteLine("enter name");
            string searchname = Console.ReadLine().ToLower();
            bool found = false;
            try
            {
                StreamReader sr = new StreamReader(FILENAME);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.ToLower().Contains((searchname)))
                    {
                        Console.WriteLine("Student found: " + line);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("eroror " + ex.Message);
            }
        }
        public static void DisplayInfo()
        {
            try
            {
                StreamReader sr = new StreamReader(FILENAME);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    Console.WriteLine(parts[0] + " " + parts[1]);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void CopyFile()
        {
            Console.Write("Enter new file name: ");
            string dest = Console.ReadLine();

            try
            {
                File.Copy(FILENAME, dest, true);
                Console.WriteLine("File copied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}