﻿using MasterServer;

namespace BeatTogether.Providers
{
    internal class GameClassInstanceProvider
    {
        public static GameClassInstanceProvider Instance { get; }
            = new GameClassInstanceProvider();

        private GameClassInstanceProvider()
        {
        }

        public UserMessageHandler UserMessageHandler { get; set; }
        public MultiplayerModeSelectionViewController MultiplayerModeSelectionViewController { get; set; }
        public MasterServerQuickPlaySetupModel MasterServerQuickPlaySetupModel { get; set; }
        public QuickPlaySongPacksDropdown QuickPlaySongPacksDropdown { get; set; }

        public MultiplayerModeSelectionFlowCoordinator MultiplayerModeSelectionFlowCoordinator { get; set; }
        public JoinQuickPlayViewController JoinQuickPlayViewController { get; set; }
        public JoiningLobbyViewController JoiningLobbyViewController { get; set; }

    }
}
