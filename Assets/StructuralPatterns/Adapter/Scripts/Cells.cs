using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class Cells : MonoBehaviour
    {
        [SerializeField]
        private Cell[] cells;
        
        public void Promenumize(int startNumber)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i].SetNumber(startNumber + i);
            }
        }
    }
}
