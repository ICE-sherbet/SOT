using UnityEngine;

namespace SoVariableTool.Core.Demo
{
    public class TextChange : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI _text;

        public void ChangeText(string text)
        {
            _text.text = text;
        } 
    }
}