﻿using UnityEngine;
using UniRx;

namespace Reduxity.Example.PlayerMovement {

    [RequireComponent(typeof(CharacterController))]
    public class MoveCharacter : MonoBehaviour {

        private CharacterController character_;

        private void Awake() {
            character_ = GetComponent<CharacterController>();
        }

        void Start() {
            renderMove();
        }

        void renderMove() {
            // Debug.Log($"App.Store: {App.Store}");
            App.Store
                .Select(CharacterMoverSelector.GetMoveDistance)
                .Subscribe(distance => {
                    // Debug.Log($"going to move character by: {distance}");
                    character_.Move(distance);
                })
                .AddTo(this);
        }
    }
}
