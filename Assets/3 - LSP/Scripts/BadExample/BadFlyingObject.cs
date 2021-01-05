using UnityEngine;

namespace Solid.LSP
{
    public abstract class BadFlyingObject : MonoBehaviour
    {
        public abstract void MoveInSpace();

        public abstract void RotateInSpace();

        public abstract void Accelerate();
    }
}
