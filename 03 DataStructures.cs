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
        //opstart deze klasse + insert node 
    }

}