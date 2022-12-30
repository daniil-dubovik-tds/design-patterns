using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class PlaneCell : MonoBehaviour
    {
        [SerializeField]
        private TextMesh text;

        public void SetNumber(int number)
        {
            text.text = number.ToString();
        }
    }
}
