﻿using Redux;
using Redux.Middleware;
using System;

namespace Reduxity.Example.Zenject.NetworkPlayerCreator {
    public class Action {
        /// <summary>
        /// Properties for each type of http request
        /// </summary>
        public class Connect : IAction {}
        public class Disconnect : IAction {}
    }

    public class ActionCreator : IActionCreator {
        /// <summary>
        /// Thunk that connects to Photon Network
        /// </summary>
        /// <returns>ThunkAction for on success or failure handlers</returns>
        public IAction Connect(Action.Connect action) {
            // return thunk to store, which will dispatch new actions upon success or failure
            return new ThunkAction<State> ((dispatch, getState) => {
                // dispatch first action to set state to loading
                // dispatch(new NetworkPlayer.Action.ConnectStart {});

                // connect to PhotonNetworkPlayer. Callbacks are handled by Photon.
				// PhotonNetwork.ConnectUsingSettings(action.settings);
            });
        }

        /// <summary>
        /// Thunk that disconnects from Photon Network
        /// </summary>
        /// <returns>ThunkAction for on success or failure handlers</returns>
        public IAction DisconnectStart(Action.Disconnect action) {
            // return thunk to store, which will dispatch new actions upon success or failure
            return new ThunkAction<State> ((dispatch, getState) => {
                // dispatch first action to set state to loading
                // dispatch(new RoomConnector.Action.JoinStart {});
            });
        }
    }

    [Serializable]
    /// <summary>
    /// </summary>
    public class Settings {
    }
}


