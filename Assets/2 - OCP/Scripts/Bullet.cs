using UnityEngine;

namespace Solid.OCP
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private float _fireForce = 300.0f;

        public void Launch(Vector3 direction)
        {
            GetComponent<Rigidbody>().AddForce(direction * _fireForce);
        }
    }
}