using UnityEngine;

namespace Solid.OCP
{
    /// <summary>
    /// This class is respecting the Open-Closed Principle, as we don't need to modify this code everytime we want to add a new type of ammunition.
    /// EG, This class is open for extension, and closed for modification.
    /// </summary>
    [RequireComponent(typeof(ILauncher))]
    public class GoodWeaponSystem : MonoBehaviour
    {
        [SerializeField]
        private SRP.ShipInput _shipInput;

        private ILauncher _launcher;

        private void Awake()
        {
            _launcher = GetComponent<ILauncher>();
        }

        private void OnEnable()
        {
            _shipInput.OnFire += FireWeapon;
        }

        private void OnDisable()
        {
            _shipInput.OnFire -= FireWeapon;
        }

        private void FireWeapon()
        {
            _launcher.Launch(this);
        }
    }
}