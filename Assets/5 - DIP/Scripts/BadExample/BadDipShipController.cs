using UnityEngine;

namespace Solid.DIP
{
    /// <summary>
    /// In this example, The first the statement of the Dependency Inversion Principle is not respected for the following reason:
    /// We can consider that this is a High Level class calling, and by extension, depending on, the implementation of a lower level class method : the BadDipShipInputReader.
    /// 
    /// The dependence can be seen if we consider the possibility of creating another input reader for, for example, an AI. 
    /// In this case, we wouldn't be able add an AI Input Reader class without breaking the dependency to the current input reader of this class.
    /// 
    /// In other terms: this class can only be used for a user controlled ship, and thus, depend on the implementation of the BadDipShipInputReader class.
    /// </summary>
    public class BadDipShipController : MonoBehaviour
    {
        [SerializeField]
        private float _moveSpeed = 5.0f;

        [SerializeField]
        private float _turnSpeed = 70.0f;

        private BadDipShipInputReader _shipInput;

        private void Awake()
        {
            _shipInput = new BadDipShipInputReader();
        }

        void Update()
        {
            _shipInput.UpdateInput();

            transform.position += Time.deltaTime * _shipInput.Thrust * transform.forward * _moveSpeed;
            transform.Rotate(transform.up * _shipInput.Rotation * _turnSpeed * Time.deltaTime);
        }
    }
}