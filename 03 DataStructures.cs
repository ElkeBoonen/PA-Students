namespace PAStudents
{
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            return Data + " --> ";
        }
    }

    class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(string data)
        {
            Head = new Node(data);
        }

        public void Insert(string data) //insert achteraan
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(data);
            }
        }

        public bool Delete(string data)
        { }

        public override string ToString()
        {
            string print = "";
            Node current = Head;
            while (current != null)
            {
                print += current;
                current = current.Next;
            }
            return print;
        }
    }

}