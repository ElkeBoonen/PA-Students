namespace PAStudents
{
    class Stack
    {
        string[] array;
        int index;
        public Stack(int size)
        {
            array = new string[size];
            index = 0;
        }

        public void Push(string data)
        {
            Console.WriteLine(index);
            if (index < array.Length)
            {
                array[index] = data;
                index++;
            }
            else throw new Exception("Overflow!");
        }

        public void Pop()
        {
            Console.WriteLine(index);
            if (array[0] == "" && index == 0)
            {
                throw new Exception("Underflow!");
            }
            else if (index == array.Length)
            {
                index--;
            }
            array[index] = "";
            index--;
            
        }

        public override string ToString()
        {
            string print = "";
            foreach (string element in array)
            {
                print += element + " | ";
            }
            return print;
        }
    }
}