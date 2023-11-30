using UnityEngine;
using UnityEngine.UI;

namespace SoVariableTool.ScriptableVariable.Demo
{
    public class VariableSliderBind : MonoBehaviour
    {
        [SerializeField] private IntVariableObject _intVariableObject;
        [SerializeField] private Slider _slider;

        private void Start()
        {
            _slider.value = _intVariableObject.Value;
            _slider.onValueChanged.AddListener(OnSliderValueChanged);
        }

        private void OnSliderValueChanged(float value)
        {
            _intVariableObject.Value = (int) (value * 100);
        }
    }
}