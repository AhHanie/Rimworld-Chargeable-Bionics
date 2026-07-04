using Verse;

namespace Chargeable_Bionics
{
    internal static class ProstheticPatchController
    {
        private const string RechargeableCompPropertiesFullName =
            "Chargeable_Hediffs_Framework.HediffCompProperties_Rechargeable";

        private static readonly string[] ProstheticHediffDefNames =
        {
            // Core industrial prosthetics
            "SimpleProstheticLeg",
            "SimpleProstheticArm",
            "SimpleProstheticHeart",
            "CochlearImplant",
            "PowerClaw",
            "Joywire",
            "Painstopper",

            // Royalty prosthetics/implants
            "DrillArm",
            "FieldHand",
            "Mindscrew",
            "HandTalon",
            "ElbowBlade",
            "KneeSpike",
            "VenomFangs",
            "VenomTalon",
        };

        internal static void RemoveProstheticRechargeableComps()
        {
            foreach (string defName in ProstheticHediffDefNames)
            {
                HediffDef def = DefDatabase<HediffDef>.GetNamedSilentFail(defName);
                if (def?.comps == null)
                {
                    continue;
                }

                int removed = def.comps.RemoveAll(props =>
                    props?.GetType().FullName == RechargeableCompPropertiesFullName);

                if (def.comps.Count == 0)
                {
                    def.comps = null;
                }

                if (removed > 0)
                {
                    Logger.Message($"Disabled rechargeable prosthetic patch for {defName}.");
                }
            }
        }
    }
}
