namespace BeehiveManagementSystemWPF
{
    public class EggCare : Bee
    {
        public EggCare(Queen _queen) : base("Egg Care")
        {
            queen = _queen;
        }

        private Queen queen;

        const float CARE_PROGRESS_PER_SHIFT = 0.15f;
        public override float CostPerShift { get { return 1.35f; } }
        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
