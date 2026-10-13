using Verse;

namespace Chargeable_Bionics
{
    public class ModSettings : Verse.ModSettings
    {
        public static bool enableProstheticPatches = false;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref enableProstheticPatches, "enableProstheticPatches", false);
            base.ExposeData();
        }
    }
}
