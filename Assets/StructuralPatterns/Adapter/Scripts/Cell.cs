using UnityEngine;
using UnityEngine.UI;

namespace Learning.Patterns.Adapter
{
    public class Cell : MonoBehaviour
    {
        [SerializeField]
        private Text text;

        public void SetNumber(int number)
        {
            text.text = number.ToString();
        }
    }
}
