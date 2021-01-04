using UnityEngine;

namespace Solid.SRP
{
    [RequireComponent(typeof(ShipInput))]
    public class ShipEngine : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 1.0f;
        [SerializeField]
        private float _turnSpeed = 5.0f;

        private ShipInput _shipInput;

        private void Awake()
        {
            _shipInput = GetComponent<ShipInput>();
        }

        private void Update()
        {
            transform.position += Time.deltaTime * _shipInput.Vertical * transform.forward * _speed;
            transform.Rotate(transform.up * _shipInput.Horizontal * _turnSpeed * Time.deltaTime);
        }
    }
}