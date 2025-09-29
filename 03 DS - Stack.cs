namespace PAStudents
{
    class Stack
    {
        string[] array;
        int index;
        public Stack(int size)
        {
            array = new string[size];
            index = -1;
        }

        public void Push(string data)
        {
            index++;
            if (index < array.Length)
            {
                array[index] = data;
            }
            else
            {
                //throw new Exception("Overflow!");
                Console.WriteLine("OVERFLOW!!!");
                index = array.Length - 1;
            }
        }

        public void Pop()
        {
            if (index >= 0)
            {
                array[index] = "";
                index--;
            }
            else
            {
                //throw new Exception("Underflow!");
                Console.WriteLine("UNDERFLOW!!!");
                index = -1;
            }
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