using System;
using System.Collections;
using UnityEngine;
using MelonLoader;

namespace ChromaticaAPI
{
    static class Misc
    {
        public static IEnumerator DelayAction(float delay, Action action)
        {
            yield return new WaitForSeconds(delay);
            action();
            yield break;
        }

        public static void Start(this IEnumerator e) => MelonCoroutines.Start(e);
    }
}
