using UnityEngine;

namespace Solid.DIP
{
    /// <summary>
    /// First DIP Statement fulfilled: The High Level module doesn't depend upon the low level class, but whether on the abstraction (= IShipInputReader).
    /// 
    /// Second DIP Statement fulfilled: The abstraction (IShipInputReader) does not depend upon details (GoodShipInputReader OR GoodShipAI), but the details depends on the abstraction.
    /// This means that if the details change (ie. we want to use the Keyboard Input instead of the AI, and Vice Versa), we won't have to change the abstraction level (ie. the interface).
    /// </summary>
    public class GoodDipShipController : MonoBehaviour
    {
        [SerializeField]
        private float _moveSpeed = 5.0f;

        [SerializeField]
        private float _turnSpeed = 70.0f;

        [SerializeField]
        private bool _useAI;

        private IShipInputReader _shipInput;

        private void Awake()
        {
            _shipInput = _useAI ? new GoodDipShipAI() as IShipInputReader : new GoodDipShipInputReader();
        }

        void Update()
        {
            _shipInput.UpdateInput();

            transform.position += Time.deltaTime * _shipInput.Thrust * transform.forward * _moveSpeed;
            transform.Rotate(transform.up * _shipInput.Rotation * _turnSpeed * Time.deltaTime);
        }
    }
}