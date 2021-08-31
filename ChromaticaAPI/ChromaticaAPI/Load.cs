using ChromaticaAPI.ApplicationBot;
using ExitGames.Client.Photon;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRCSDK2.Validation.Performance;

namespace ChromaticaAPI
{
    public class Load : MelonMod
    {
        public static List<VRCModule> Modules = new List<VRCModule>();
        public static AppBots UI;
        public static Config config = new Config();

        public override void OnApplicationStart()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\ChromaticaAPI"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\ChromaticaAPI");
            MelonLogger.Log("ChromaticaAPI loaded.");
            Bot bot = new Bot();
            bot.OnStart();
        }

        public static void InitPatches()
        {

            new List<string>() {
                "Method_Public_Static_IEnumerator_String_GameObject_AvatarPerformanceStats_0",
                "Method_Public_Static_IEnumerator_GameObject_AvatarPerformanceStats_PerformanceRating_MulticastDelegateNPublicSealedVoUnique_0",
                "Method_Public_Static_Void_String_GameObject_AvatarPerformanceStats_PDM_0",
            }.ForEach((methodName) =>
            {
                new Patch(
                    typeof(AvatarPerformance),
                    typeof(Load),
                    methodName,
                    "calculatePerformance");
            });
            InitOnPlayerJoinLeavePatch();
            InitAntiEmojisPatch();
            //InitAntiEmojiVRCEventPatch(); // Dont initialize because the OnVRCEvent method is only for application bots
        }

        public static void InitOnPlayerJoinLeavePatch()
        {
            var OnPlayerLeftJoinMethod = typeof(NetworkManager).GetMethods().Where(m =>
                m.Name.Contains("Method_Public_Void_Player_") &&
                !m.Name.Contains("PDM")
            ).ToArray();

            new Patch( // Creating a new instance of the Patch class
                typeof(NetworkManager), // Providing the class of the method we wanna patch [1]
                typeof(Load), // Providing the class of the method we wanna replace [2]
                OnPlayerLeftJoinMethod[1].Name, // Providing the method of the class we wanna patch [1]
                "OnPlayerLeft" // Providing the method of the method we wanna replace [2]
            );

            new Patch(
                typeof(NetworkManager),
                typeof(Load),
                OnPlayerLeftJoinMethod[0].Name,
                "OnPlayerJoined"
            );

            new Patch(
                typeof(NetworkManager),
                typeof(Load),
                $"Method_Public_Virtual_Final_New_Void_EventData_0",
                "OnEvent"
            );
        }

        private static bool calculatePerformance()
            => !Bot.IsApplicationBot;

        public static void InitAntiEmojiVRCEventPatch()
        {
            return;
            new Patch(
                typeof(VRC_EventDispatcherRFC),
                typeof(Load),
                "Method_Public_Void_Player_VrcEvent_VrcBroadcastType_Int32_Single_0",
                "OnVRCEvent"
            );
        }

        public static void InitAntiEmojisPatch()
        {
            new Patch(
                typeof(VRCPlayer),
                typeof(Load),
                "SpawnEmojiRPC",
                "OnSpawnEmojiRPC"
            );
        }

        private static bool OnEvent(ref EventData __0)
        {
            if (Bot.IsApplicationBot && __0.Code == 6)
                return false;
            return true;
        }

        private static bool OnSpawnEmojiRPC(ref int __0, ref Player __1)
        {
            return !(Bot.IsApplicationBot && (__0 < 0 || __0 > 57));
        }

        private static bool OnVRCEvent(ref Player __0, ref VRC_EventHandler.VrcEvent __1, ref VRC_EventHandler.VrcBroadcastType __2, ref int __3, ref float __4)
        { // only gets patched if ur an application bot...
            try
            {
                if (__0 != null
                    && __1.ParameterString != null
                    && __0.GetAPIUser().id != APIUser.CurrentUser.id
                    && __1.ParameterString.Contains("Emoji"))
                    return false;
            } catch { return false; }
            return true;
        }

        private static bool OnPlayerJoined(ref Player __0)
        {
            if (!Bot.IsApplicationBot)
            {
                if (!UI.PlayerListBox.Items.Contains(__0.GetName()))
                    UI.PlayerListBox.Items.Add(__0.GetName());
                return true;
            }
            __0.SetVolume(0f);
            return true;
        }

        private static bool OnPlayerLeft(ref Player __0)
        {
            if (!Bot.IsApplicationBot)
                if (UI.PlayerListBox.Items.Contains(__0.GetName()))
                    UI.PlayerListBox.Items.Remove(__0.GetName());
            return true;
        }

        public override void VRChat_OnUiManagerInit() => Modules.ForEach((mod) => mod.VRChat_OnUiManagerInit());
        public override void OnApplicationQuit() => Process.GetCurrentProcess().Kill();
        public override void OnLevelWasLoaded(int level) => Modules.ForEach((mod) => mod.OnLevelWasLoaded(level));

        public override void OnUpdate() {
            Modules.ForEach((mod) => mod.OnUpdate());
            if (config.ClickTP && Input.GetKeyDown(KeyCode.T))
            {
                Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                if (Physics.Raycast(ray, out RaycastHit hit))
                    if (hit.transform != null)
                        SocketConnection.SendCommandToClients($"ClickTP {hit.point.x}:{hit.point.y}:{hit.point.z}");
            }
        }
    }
}