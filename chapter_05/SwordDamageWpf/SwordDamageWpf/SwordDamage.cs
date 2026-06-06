namespace SwordDamageWpf
{
    public class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        public int Damage { get; private set; }

        public int Roll { get { return roll; } set { roll = value; CalculateDamage();  } }
        public int roll;

        public bool Flaming { get { return flaming; } set { flaming = value; CalculateDamage(); } }
        public bool flaming;

        public bool Magic { get { return magic; } set { magic = value; CalculateDamage(); } }
        public bool magic;

        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}
