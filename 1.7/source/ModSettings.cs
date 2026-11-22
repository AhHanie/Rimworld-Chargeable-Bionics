using Verse;

namespace Chargeable_Bionics
{
    public class ModSettings : Verse.ModSettings
    {
        public static bool enableProstheticPatches = false;
        public static bool colonyPawnsOnly = false;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref enableProstheticPatches, "enableProstheticPatches", false);
            Scribe_Values.Look(ref colonyPawnsOnly, "colonyPawnsOnly", false);
            base.ExposeData();
        }
    }
}
