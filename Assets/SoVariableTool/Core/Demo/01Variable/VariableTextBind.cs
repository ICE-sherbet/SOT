using UnityEngine;

namespace SoVariableTool.ScriptableVariable.Demo
{
    public class VariableTextBind : MonoBehaviour
    {
        [SerializeField] private IntVariableObject _intVariableObject;
        [SerializeField] private TMPro.TextMeshProUGUI _text;
        
        private void Start()
        {
            _text.text = _intVariableObject.Value.ToString();
            _intVariableObject.OnValueChanged += OnValueChanged;
        }
        
        private void OnValueChanged(object value)
        {
            _text.text = value.ToString();
        }
    }
}