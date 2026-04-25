namespace AbilityScore
{
    public class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DividedBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            double divided = RollResult / DividedBy;
            int added = AddAmount + (int)divided;
            if (added < Minimum)
                Score = Minimum;
            else
                Score = added;
        }
    }
}

