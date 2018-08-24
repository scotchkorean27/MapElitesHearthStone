namespace MapElitesHS
{
    public class Genome
    {
        private double fitnessPerformance = 0;

        // Maybe move this out of this class and turn Genome into an immutable data structure?
        public double calculateFitnessPerformance()
        {
            return 0;
        }
        public double getFitness()
        {
            return fitnessPerformance;
        }
        public ArrayList getDeck() 
        {
            return null;
        }
        public BehaviorVector convertGenomeToBehaviorVector()
        {
            return null;
        }

        public static Genome returnRandomGenome()
        {
            return null;
        }

        public Genome ReturnChildGenome()//Mutate & Crossover
        {
            return null;
        }

    }
}
