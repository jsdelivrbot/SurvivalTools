﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;

namespace SurvivalTools
{
    public static class ModCompatibilityCheck
    {

        public static bool CombatExtended => ModsConfig.ActiveModsInLoadOrder.Any(m => m.Name == "Combat Extended");
        public static bool PickUpAndHaul => ModsConfig.ActiveModsInLoadOrder.Any(m => m.Name == "PickUpAndHaul");
        public static bool MendAndRecycle => ModsConfig.ActiveModsInLoadOrder.Any(m => m.Name == "MendAndRecycle");
        public static bool OtherInventoryModsActive => CombatExtended || PickUpAndHaul;

        public static bool DubsBadHygiene => ModsConfig.ActiveModsInLoadOrder.Any(m => m.Name == "Dubs Bad Hygiene");

    }
}
