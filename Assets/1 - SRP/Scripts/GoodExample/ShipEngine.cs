using UnityEngine;

namespace Solid.SRP
{
    /// <summary>
    /// Class taking care of moving the ship GameObject by accessing the values provided in the ShipInput system
    /// </summary>
    [RequireComponent(typeof(ShipInput))]
    public class ShipEngine : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 1.0f;
        [SerializeField]
        private float _turnSpeed = 70.0f;

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