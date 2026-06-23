using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystemWPF
{
    public static class HoneyVault
    {
        public static string StatusReport {
            get
            {
                string status = $"Honey quantity: {honey} \n Nectar quantity: {nectar}";
                if (honey < LOW_LEVEL_WARNING || nectar < LOW_LEVEL_WARNING)
                {
                    var resource =
                        honey < LOW_LEVEL_WARNING && nectar < LOW_LEVEL_WARNING ? "HONEY AND NECTAR" :
                        honey < LOW_LEVEL_WARNING ? "HONEY" :
                        "NECTAR";

                    return $"{status}\nLOW {resource} - ADD A {resource} MANUFACTURER";
                }

                return status;
            }
        }
        private static float honey = 25f;
        private static float nectar = 100f;

        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;

        public  static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }
        public static void CollectNectar(float amount) {
            if (amount > 0) nectar += amount;
        }
        public static void ConvertNectarToHoney(float amount) 
        {
            if (amount > nectar)
                amount = nectar;

            nectar -= amount;
            honey += amount * NECTAR_CONVERSION_RATIO;
        }

    }
}
