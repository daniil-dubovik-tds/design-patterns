using System;
using UnityEngine;

namespace Learning.Patterns.Adapter
{
    public class GameObjectDisposer : IDisposable
    {
        private readonly GameObject gameObject;

        public GameObjectDisposer(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }

        void IDisposable.Dispose()
        {
            UnityEngine.Object.Destroy(gameObject);
        }
    }
}
