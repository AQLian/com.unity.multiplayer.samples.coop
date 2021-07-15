using System;
using MLAPI;
using MLAPI.NetworkVariable;
using UnityEngine;

namespace BossRoom
{
    public enum WinState
    {
        Invalid,
        Win,
        Loss
    }

    /// <summary>
    /// MonoBehaviour containing only one NetworkVariableBool to represent the game session's win state.
    /// </summary>
    public class NetworkWinState : NetworkBehaviour
    {
        public NetworkVariable<WinState> winState = new NetworkVariable<WinState>(WinState.Invalid);
    }
}
