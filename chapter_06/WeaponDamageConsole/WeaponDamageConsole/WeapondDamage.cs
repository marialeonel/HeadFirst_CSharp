namespace WeaponDamageConsole
{
    public class WeapondDamage
    {
        public int Damage { get; protected set; }
        private int roll;

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        protected virtual void CalculateDamage()
        {
            //subclasses will override this method to calculate damage based on weapon type
        }

        public WeapondDamage(int startingRoll)
        {
            Roll = startingRoll;
            CalculateDamage();
        }
    }
}
