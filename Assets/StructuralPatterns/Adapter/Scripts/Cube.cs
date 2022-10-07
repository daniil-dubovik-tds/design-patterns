using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class Cube : MonoBehaviour
    {
        [SerializeField]
        private MeshRenderer meshRenderer;

        public void ChangeColor(Color color)
        {
            meshRenderer.material.color = color;
        }
    }
}
