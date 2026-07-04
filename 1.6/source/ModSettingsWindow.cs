using UnityEngine;
using Verse;

namespace Chargeable_Bionics
{
    public static class ModSettingsWindow
    {
        public static void Draw(Rect parent)
        {
            Listing_Standard listing = new Listing_Standard();
            listing.Begin(parent);

            listing.CheckboxLabeled(
                "ChargeableBionics.EnableProstheticPatches".Translate(),
                ref ModSettings.enableProstheticPatches,
                "ChargeableBionics.EnableProstheticPatchesTooltip".Translate());

            listing.Gap();
            GUI.color = Color.yellow;
            listing.Label("ChargeableBionics.RestartRequired".Translate());
            GUI.color = Color.white;

            listing.End();
        }
    }
}
