using DesignPatterns.StrategyPatternFactoryMethod;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace DesignPatterns.StrategyPatternFactoryMethod
{
    public class StrategyPatternUIController : MonoBehaviour
    {
        [SerializeField] private UIDocument _UIDocument;
        [SerializeField] private SortingDiceController _sortingDiceController;
        private VisualElement _container;

        private void Start()
        {
            _container = _UIDocument.rootVisualElement.Q<VisualElement>("Container");
            _container.Q<Button>(nameof(InsertionSort)).RegisterCallback<ClickEvent>(ev => _sortingDiceController.StartSorting(typeof(InsertionSort)));
            _container.Q<Button>(nameof(BubbleSort)).RegisterCallback<ClickEvent>(ev => _sortingDiceController.StartSorting(typeof(BubbleSort)));
            _container.Q<Button>(nameof(QuickSort)).RegisterCallback<ClickEvent>(ev => _sortingDiceController.StartSorting(typeof(QuickSort)));
            _container.Q<Button>(nameof(SelectionSort)).RegisterCallback<ClickEvent>(ev => _sortingDiceController.StartSorting(typeof(SelectionSort)));
            _container.Q<Button>("Reset").RegisterCallback<ClickEvent>(ev => SceneManager.LoadScene(SceneManager.GetActiveScene().name));
        }
    }
}