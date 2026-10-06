using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class RoomManager
    {
        private DataBase[] data;
        private int count;

        public RoomManager(int capacity)
        {
            data = new DataBase[capacity];
            count = 0;
        }
        public void AddRoom(DataBase dataBase) //add shape to the array with error handling
        {
            try
            {
                if (dataBase == null)
                {
                    throw new Exception("Cannot add null shape.");
                }

                if (count >= data.Length)
                {
                    throw new Exception("Shape array is full.");
                }
                //count=0 -> shapes[0] = s 
                data[count++] = dataBase;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Add operation finished.\n");
            }
        }
        public void DeleteRoom()
        {
            if(count == 0)
            {
                Console.WriteLine("no rooms to delete");
                return;
            }
            data[--count] = null;

        }
        public void ClearRooms()
        {
            for (int i = 0; i < count; i++)
            {
                data[i] = null;
            }
            count = 0;
        }
        public void SelectedRoomDelete(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            data[index] = null;
        }

        public void RemoveRoom(int index) //remove shape at specific index
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            //{c1,r1,s1,T1,R1,null,null,null}

            //{c1,r1,T1,R1,null,null,null,null}
            //removeindex = 2  -> s1

            for (int i = index; i < count - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[count - 1] = null;
            count--;
        }

        public void DisplayAll() //display info about all shapes in the array
        {
            for (int i = 0; i < count; i++)
            {
                data[i].ShowInfo();
            }
        }

        // 🔹 Sort by Area (Bubble Sort)
        //{c1,r1,s1,T1,R1,null,null,null}
        //{32,12,62,21,9,null,null,null}
        //i=1 , j=0   until 4  
        //{12,32,21,9,62,n,n,n}
       /* public void SortByName() //Bubble Sort
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (data[j].Area() > data[j + 1].Area())
                    {
                        DataBase temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
       */
        //{32,12,62,21,9,null,null,null}
        public void SortByID() //Selection Sort
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (data[i].GetId() > data[j].GetId())
                    {
                        DataBase temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

        }
        // 🔹 Sort by Name
        public void SortByName() //Bubble Sort
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    //a<b
                    if (string.Compare(data[j].GetName(), data[j + 1].GetName()) > 0)
                    {
                        DataBase temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        /*
        public void FilterByArea(double threshold) //display shapes with area greater than threshold
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Area() > threshold)
                {
                    data[i].DescribeShape();
                }
            }
        }
        */
    }
}
