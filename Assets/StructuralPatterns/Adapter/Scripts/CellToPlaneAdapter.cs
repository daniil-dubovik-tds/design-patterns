using UnityEngine;
using UnityEngine.UI;

namespace Learning.Patterns.Adapter
{
    public class CellToPlaneAdapter : MonoBehaviour
    {
        [SerializeField]
        private Cell cell;

        [SerializeField]
        private Text cellText;
        
        [SerializeField]
        private Transform planeCellTransform;

        [SerializeField]
        private TextMesh planeCellText;

        private void Start()
        {
            Adapt();
        }

        private void Update()
        {
            UpdatePlaneCellText();
        }

        private void Adapt()
        {
            var position = RectTransformUtility.WorldToScreenPoint(Camera.main, cell.transform.position);
            planeCellTransform.position = position;
            planeCellTransform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }

        private void UpdatePlaneCellText()
        {
            if (cellText.text != planeCellText.text) {
                planeCellText.text = cellText.text;
            }
        }
    }
}
