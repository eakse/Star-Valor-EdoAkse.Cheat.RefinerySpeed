using BepInEx;
using HarmonyLib;


namespace EdoAkse.Cheat.RefinerySpeed
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Main : BaseUnityPlugin
    {
        public const string pluginGuid = "edoakse.starvalor.cheat.refineryspeed";
        public const string pluginName = "EdoAkse Cheat: Sets refinery speed to 0.01 second.";
        public const string pluginVersion = "1.0.0";


        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(Main));
        }

        [HarmonyPatch(typeof(BuffRefinery))]
        [HarmonyPatch("Begin")]
        [HarmonyPrefix]
        private static void Fix(ref float ___refineTime)
        {
            ___refineTime = 0.01f;
        }
    }
}
