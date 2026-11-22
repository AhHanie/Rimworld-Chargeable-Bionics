using Chargeable_Hediffs_Framework;
using RimWorld;
using Verse;

namespace Chargeable_Bionics
{
    public sealed class ColonyChargeActivationWorker : RechargeableActivationWorker
    {
        public override bool IsActiveFor(Pawn pawn)
        {
            if (!Mod.ColonyPawnsOnly)
                return true;
            if (pawn?.Faction?.IsPlayer != true || pawn.IsPrisoner || pawn.HostFaction != null)
                return false;

            return Current.Game?.questManager == null || !pawn.IsQuestLodger();
        }
    }
}
