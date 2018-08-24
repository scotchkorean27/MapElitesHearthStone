using System;
using System.Collections.Generic;
using System.Linq;

namespace MapElitesHS
{
    class Program
    {

        public int numberOfFeaturesInFeatureSpace = 5;
        public static int generations = 1000;
        public static int numGenomes = 100;


        public static Dictionary<BehaviorVector, Genome> FeatureSpace = new Dictionary<BehaviorVector, Genome>();
        public static Random random = new Random();


        static void Main(string[] args)
        {
            for (int i = 0; i < generations; i++)
            {
                Genome xPrime = new Genome();

                if(i < numGenomes)
                {
                    xPrime = Genome.returnRandomGenome();
                }
                else
                {
                    int chosenEliteIndex = random.Next(FeatureSpace.Count);
                    List<Genome> listGenomes = FeatureSpace.Values.ToList();
                    Genome RandomGenome = listGenomes[chosenEliteIndex];

                    xPrime = RandomGenome.ReturnChildGenome();
                }

                BehaviorVector behaviorVector = xPrime.convertGenomeToBehaviorVector();
                xPrime.fitnessPerformance = calculateFitnessPerformance();

            }
            
        }


    }
}
