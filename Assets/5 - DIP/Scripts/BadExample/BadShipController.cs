using UnityEngine;

namespace Solid.DIP
{
    /// <summary>
    /// First DIP Statement fulfilled: The High Level module, which doesn't depends on the low level classes, but whether on the abstraction (= IShipInputReader)
    /// </summary>
    public class BadShipController : MonoBehaviour
    {
        [SerializeField]
        private float _moveSpeed = 5.0f;

        [SerializeField]
        private float _turnSpeed = 70.0f;

        private BadShipInputReader _shipInput;

        private void Awake()
        {
            _shipInput = new BadShipInputReader();
        }

        void Update()
        {
            _shipInput.UpdateInput();

            transform.position += Time.deltaTime * _shipInput.Thrust * transform.forward * _moveSpeed;
            transform.Rotate(transform.up * _shipInput.Rotation * _turnSpeed * Time.deltaTime);
        }
    }
}