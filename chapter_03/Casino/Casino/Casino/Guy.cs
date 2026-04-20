namespace Casino
{
    public class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Writes my name and how much cash I have to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }

        /// <summary>
        /// Removes the specified amount of cash from the current instance and returns the amount given.
        /// </summary>
        /// <param name="amount">The amount of cash to give. Must be zero or greater and not exceed the available cash.</param>
        /// <returns>The amount of cash actually given. Returns 0 if the requested amount is negative or exceeds the available
        /// cash.</returns>
        public int GiveCash(int amount)
        {
            if (amount < 0) {
                Console.WriteLine($"{Name} says: ${amount} isn't a valid amount of cash to give.");
                return 0;
            }

            if ( amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enough cash to give you ${amount}.");
            }

            Cash-= amount;
            return amount;
        }

        /// <summary>
        /// Adds the specified amount of cash to the current balance.
        /// </summary>
        /// <param name="amount">The amount of cash to add. Must be zero or greater.</param>
        public void ReceiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine($"{Name} says: ${amount} isn't a valid amount of cash to give.");
            }

            else
            {
                Cash += amount;
            }
        }
    }
}
