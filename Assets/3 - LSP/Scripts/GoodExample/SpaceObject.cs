using UnityEngine;

namespace Solid.LSP
{
    public abstract class SpaceObject : MonoBehaviour
    {
        public abstract void MoveInSpace();

        public abstract void RotateInSpace();
    }
}
