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

            // Alpha Implants animal prosthetics (1.6)
            "AI_AnimalDenture",
            "AI_AnimalProstheticLeg",
            "AI_AnimalProstheticArm",
            "AI_AnimalProstheticTail",
            "AI_AnimalProstheticJaw",
            "AI_AnimalProstheticHeart",
            "AI_AnimalProstheticSpine",
            "AI_AnimalProstheticStomach",
            "AI_AnimalProstheticLung",
            "AI_AnimalProstheticKidney",
            "AI_AnimalProstheticLiver",
            "AI_AnimalPowerClaw",
            "AI_AnimalProstheticBeak",
            "AI_AnimalProstheticTentacle",
            "AI_AnimalProstheticBuoyancy",
            "AI_AnimalProstheticWing",
            "AI_AnimalProstheticBlade",
            "AI_AnimalProstheticStinger",
            "AI_AnimalProstheticHorn",
            "AI_AnimalPainstopper",
            "AI_AnimalController",
            "AI_AnimalJump",
            "AI_AnimalThermoregulator",
            "AI_AnimalChemfuelNodules",
            "AI_AnimalSkinHardener",
            "AI_AnimalVenomFangs",
            "AI_AnimalVacSkinGland",
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
