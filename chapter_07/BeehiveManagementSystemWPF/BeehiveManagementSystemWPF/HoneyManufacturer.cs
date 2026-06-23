namespace BeehiveManagementSystemWPF
{
    public class HoneyManufacturer : Bee
    {
        
        public HoneyManufacturer() : base("Honey Manufacturer")
        {
        }

        const float NECTAR_COLLECTED_PER_SHIFT = 33.15f;
        public override float CostPerShift { get { return 1.7f; } }
        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_COLLECTED_PER_SHIFT);
        }

    }
}
