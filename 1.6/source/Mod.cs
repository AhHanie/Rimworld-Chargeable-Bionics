using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace Chargeable_Bionics
{
    public class Mod: Verse.Mod
    {
        public Mod(ModContentPack content) : base(content)
        {
            LongEventHandler.QueueLongEvent(Init, "ChargeableBionics.LoadingLabel", doAsynchronously: true, null);
        }

        private void Init()
        {
            if (!ModSettings.enableProstheticPatches)
            {
                ProstheticPatchController.RemoveProstheticRechargeableComps();
            }
        }

        public override string SettingsCategory()
        {
            return "ChargeableBionics.SettingsTitle".Translate();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            ModSettingsWindow.Draw(inRect);
            base.DoSettingsWindowContents(inRect);
        }
    }
}
