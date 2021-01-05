using UnityEngine;

namespace Solid.OCP
{
    /// <summary>
    /// A simple type of projectile that just go straigt forward
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : Projectile
    {
        [SerializeField]
        private float _fireForce = 300.0f;

        public void Launch(Vector3 direction)
        {
            GetComponent<Rigidbody>().AddForce(direction * _fireForce);
        }
    }
}