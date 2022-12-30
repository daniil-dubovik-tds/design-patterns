using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField]
        private Cells cells;
        
        private void Start()
        {
            cells.Numerate(1);
        }
    }
}
