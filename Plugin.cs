﻿using System.Linq;
using Base_Mod;
using JetBrains.Annotations;
using UnityEngine;

namespace Smg_Goes_Brrrr {
    [UsedImplicitly]
    public class Plugin : BaseGameMod {
        protected override     string ModName => nameof(Plugin);
        public static readonly GUID   SMG      = GUID.Parse("96048d612ab1ea246b50745a12b9b05e");
        private const          string NEW_NAME = "It Goes Brrrrrrrrrr";
        private const          string NEW_DESC = "Brrrrrrrrrrrrrrrrrrrrrrrr";

        public override void OnInitData() {
            var smg = GameResources.Instance.Items.FirstOrDefault(item => item.AssetId == SMG);
            if (smg is null) {
                Debug.Log("Error: Cannot find SMG item.");
                return;
            }
            ;
            smg.NameLocalization        = new LocalizedString(".", NEW_NAME, ".");
            smg.DescriptionLocalization = new LocalizedString(".", NEW_DESC, ".");
            LocalizationManager.Localize(smg);

            base.OnInitData();
        }
    }
}