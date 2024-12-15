    public class Solution
    {
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            //Enqueue all classes prioritised by change in pass ratio
            PriorityQueue<double[], double> pq = new();
            foreach (int[] cls in classes)
            {
                double currentRatio = (double)cls[0] / cls[1];
                double newRatio = (double)(cls[0] + 1) / (cls[1] + 1);
                double ratioChange = (double)newRatio - currentRatio;
                pq.Enqueue(new double[] { cls[0], cls[1] }, 0 - ratioChange);
            }
            
            //Add students to classes with the most impact to ratio change
            for (int i = 0; i < extraStudents; i++)
            {
                double[] currentClass = pq.Dequeue();
                int passes = (int)currentClass[0] + 1;
                int totalStudents = (int)currentClass[1] + 1;

                double newRatio = (double)(passes + 1) / (totalStudents + 1);
                double currentRatio = (double)passes / totalStudents;
                double ratioChange = newRatio - currentRatio;
                pq.Enqueue(new double[] { passes, totalStudents }, 0 - ratioChange);
            }

            //Calculate average result
            double result = 0;
            while (pq.Count > 0)
            {
                double[] currentClass = pq.Dequeue();
                int passes = (int)currentClass[0];
                int totalStudents = (int)currentClass[1];
                result += (double) passes / totalStudents;
            }

            return result / classes.Length;
        }
    }
