using UnityEngine;

namespace Solid.LSP
{
    /// <summary>
    /// This class is here to fix the broken LSP from the Bad Example: 
    /// A FlyingObject can indeed move in space and rotate in space (like a spaceship), so it can extend this class
    /// and an Asteroid can do so as well, so it can extend this class instead of the FlyingObject base class.
    /// </summary>
    public abstract class SpaceObject : MonoBehaviour
    {
        protected virtual void Update()
        {
            MoveInSpace();
            RotateInSpace();
        }

        public abstract void MoveInSpace();

        public abstract void RotateInSpace();
    }
}
