using System.Collections.Generic;
using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class Cells : MonoBehaviour
    {
        private List<Cell> cells = new List<Cell>();

        private void Awake()
        {
            FillCells();
        }

        public void Numerate(int startNumber)
        {
            for (var i = 0; i < cells.Count; i++)
            {
                cells[i].SetNumber(startNumber + i);
            }
        }

        private void FillCells()
        {
            foreach (Transform child in transform)
            {
                var cell = child.GetComponent<Cell>();

                if (cell == null)
                {
                    return;
                }
                
                cells.Add(cell);
            }
        }
    }
}
