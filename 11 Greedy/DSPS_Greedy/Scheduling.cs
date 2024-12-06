
namespace DSPS_Greedy
{
    internal class Scheduling
    {
        private string[] classes;
        private double[] start;
        private double[] end;

        public Scheduling(string[] classes, double[] start, double[] end)
        {
            this.classes = classes;
            this.start = start;
            this.end = end;
        }

        internal List<string> Run()
        {
            List<string> result = new List<string>();

            result.Add(classes[0]);

            double endtime = end[0];

            for (int i = 1; i < classes.Length; i++)
            {
                if (start[i] >= endtime)
                { 
                    result.Add(classes[i]);
                    endtime = end[i];
                }
            }


            return result;
        }
    }
}