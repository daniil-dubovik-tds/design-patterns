using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField]
        private Cells cells;
        
        private void Start()
        {
            cells.Promenumize(1);
        }
    }
}
