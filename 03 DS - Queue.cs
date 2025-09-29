namespace PAStudents
{
    class Queue
    {
        LinkedList list;
        public Queue()
        {
            list = new LinkedList();
        }

        public void Enqueue(string data)
        {
            list.Insert(data);
        }

        public void Dequeue()
        {
            list.Delete(list.Head.Data);
        }

        public override string ToString()
        {
            return list.ToString();
        }
    }
}