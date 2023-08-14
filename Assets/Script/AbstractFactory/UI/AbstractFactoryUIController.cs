using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryUIController : MonoBehaviour
    {
        [SerializeField] private UIDocument _UIDocument;
        [SerializeField] private ClientAnimalsFactory _clientAnimalsFactory;
        private VisualElement _container;
        void Start()
        {
            _container = _UIDocument.rootVisualElement.Q<VisualElement>("Container");
            _container.Q<Button>("WildTwoLegsAnimal").RegisterCallback<ClickEvent>(ev => _clientAnimalsFactory.InstantiateWildAnimal(EAnimalType.TwoLegged));
            _container.Q<Button>("DomesticTwoLegsAnimal").RegisterCallback<ClickEvent>(ev => _clientAnimalsFactory.InstantiateDomesticAnimal(EAnimalType.TwoLegged));
            _container.Q<Button>("WildFourLegsAnimal").RegisterCallback<ClickEvent>(ev => _clientAnimalsFactory.InstantiateWildAnimal(EAnimalType.FourLegged));
            _container.Q<Button>("DomesticFourLegsAnimal").RegisterCallback<ClickEvent>(ev => _clientAnimalsFactory.InstantiateDomesticAnimal(EAnimalType.FourLegged));
        }

    }
}