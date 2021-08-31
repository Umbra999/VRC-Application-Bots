using ChromaticaAPI.ApplicationBot;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRC;

namespace ChromaticaAPI
{
    public partial class AppBots : Form
    {
        public AppBots()
        {
            InitializeComponent();
            // this.ShowInTaskbar = false;
        }

        public ComboBox PlayerListBox => PlayerList;

        private Player GetSelectedPlayer {
            get {
                return PlayerExtensions.GetPlayer((string)PlayerListBox.SelectedItem);
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"JoinWorld {RoomExtensions.Current_World_ID}");
        }

        private void StartBotsButton_Click(object sender, EventArgs e)
        {
            SocketConnection.StartServer();
            int i = 0;
            foreach (int Profile in Bot.LoginAndProfile.Values)
            {
                Misc.DelayAction((float)0 + (i * 7), () => {
                    Bot.MakeBot(Profile);
                }).Start();
                i++;
            }
        }

        private void RC2SelectedButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"SetLagTarget {(!PlayerIsSelected("No player selected, clearing lagger!") ? "" : MenuExtensions.GetSelectedAPIUser().id)}");
        }

        private void OrbitSelectedButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"OrbitSelected {(!PlayerIsSelected("No player selected, clearing orbit!") ? "" : MenuExtensions.GetSelectedAPIUser().id)}");
        }

        private bool PlayerIsSelected(string MSG = "You do not have a player selected!")
        {
            if (MenuExtensions.GetSelectedAPIUser() != null)
                return true;
            MelonLogger.LogWarning(MSG);
            return false;
        }

        private void WorldLaggerToggle_CheckedChanged(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"ToggleWorldLagger {(WorldLaggerToggle.Checked ? "true" : "")}");
        }

        private void PlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetSelectedPlayer == null)
                return;
        }

        private bool BlockedAll = false;
        private void BlockAllButton_Click(object sender, EventArgs e)
        {
            if (GetSelectedPlayer == null)
                return;
            MelonLogger.Log($"{(BlockedAll ? "Unblocking all players" : $"Blocking all players except for {GetSelectedPlayer.GetAPIUser().id}")}");
            SocketConnection.SendCommandToClients($"ToggleBlockAll {(BlockedAll ? "" : GetSelectedPlayer.GetAPIUser().id)}");
            BlockedAll = !BlockedAll;
        }

        private void ClickTPToggle_CheckedChanged(object sender, EventArgs e)
        {
            ChromaticaAPI.Load.config.ClickTP = ClickTPToggle.Checked;
        }

        private void ChangeAvatarButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"SetAvatar {AvatarIDTextbox.Text}");
        }

        private void RotateLeftButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients("RotateY -20");
        }

        private void RotateRightButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients("RotateY 20");
        }

        private void EventCachingDCToggle_CheckedChanged(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"EventCachingDCToggle {(EventCachingDCToggle.Checked ? "true" : "")}");
        }

        private void SpinbotToggle_CheckedChanged(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"SpinbotToggle {(SpinbotToggle.Checked ? "true" : "")}");
        }

        private void SetSpinbotSpeed_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SpinbotSpeedTextbox.Text, out int i))
            {
                SocketConnection.SendCommandToClients($"SpinbotSpeed {i}");
            }
        }

        private void MoveForwardButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"MoveForwards ");
        }

        private void MoveBackwardButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"MoveBackwards ");
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"MoveLeft ");
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"MoveRight ");
        }

        private void SpamInstantiatePrefabToggle_CheckedChanged(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"SpamInstantiate {(SpamInstantiatePrefabToggle.Checked ? PrefabNameTextbox.Text : "")}");
        }

        private void UnmutedToggle_CheckedChanged(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"Unmute {(UnmutedToggle.Checked ? "true" : "")}");
        }

        private void EarrapeMicToggle_CheckedChanged(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"Earrape {(EarrapeMicToggle.Checked ? "true" : "")}");
        }

        private void SetTargetFramerateButton_Click(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"SetTargetFramerate {TargetFramerateTextbox.Text}");
        }

        private void WestCoastLaggerToggle_CheckedChanged(object sender, EventArgs e)
        {
            SocketConnection.SendCommandToClients($"WestCoastLagger {(WestCoastLaggerToggle.Checked ? "true" : "")}");
        }
    }
}