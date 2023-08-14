using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace DesignPatterns.StatePattern
{
    public class StatePatternUIController : MonoBehaviour
    {
        [SerializeField] private UIDocument _UIDocument;
        [SerializeField] private PlayerStateController _playerStateController;
        private VisualElement _container;
        private Label _stateLabel;

        private void Start()
        {
            _container = _UIDocument.rootVisualElement.Q<VisualElement>("Container");
            _stateLabel = _container.Q<Label>("CurrentState");
        }
        private void Update()
        {
            _stateLabel.text = $"Current state: {_playerStateController.CurrentState.GetType()}";
        }
    }
}