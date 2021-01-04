using UnityEngine;

namespace Solid.OCP
{
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