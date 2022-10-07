using System.Collections;
using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField]
        private Cube cube;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (cube == null)
                {
                    return;
                }
                
                StartCoroutine(DisposeCube());
            }
        }

        private IEnumerator DisposeCube()
        {
            // Create adapter to dispose some GameObject by `using` operator.
            using (new GameObjectDisposer(cube.gameObject))
            {
                cube.ChangeColor(Color.green);
                yield return new WaitForSeconds(2);
                cube.ChangeColor(Color.yellow);
                yield return new WaitForSeconds(2);
                cube.ChangeColor(Color.red);
                yield return new WaitForSeconds(2);
            }
        }
    }
}
