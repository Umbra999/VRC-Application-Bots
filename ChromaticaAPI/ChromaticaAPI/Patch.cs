using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChromaticaAPI
{
    public class Patch
    {
        private static readonly HarmonyInstance HInstance = HarmonyInstance.Create("DripPatches");
        public Patch(Type PatchClass, Type YourClass, string Method, string ReplaceMethod, BindingFlags stat = BindingFlags.Static, BindingFlags pub = BindingFlags.NonPublic)
        {
            HInstance.Patch(AccessTools.Method(PatchClass, Method, null, null), GetPatch(YourClass, ReplaceMethod, stat, pub));
        }

        private HarmonyMethod GetPatch(Type YourClass, string MethodName, BindingFlags stat, BindingFlags pub)
        {
            return new HarmonyMethod(YourClass.GetMethod(MethodName, stat | pub));
        }
    }
}
