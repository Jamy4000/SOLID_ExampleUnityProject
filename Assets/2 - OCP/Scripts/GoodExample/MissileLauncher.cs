using UnityEngine;

namespace Solid.OCP
{
    /// <summary>
    /// This will be use by the GoodWeaponSystem to launch a auto-guided missile. 
    /// The only thing we need to do is to make this class extend the ILauncher interface, and place it on the same GameObject as the GoodWeaponSystem.
    /// </summary>
    public class MissileLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField]
        private Missile _missilePrefab;

        public void Launch(GoodWeaponSystem weapon)
        {
            Transform target = GameObject.FindGameObjectWithTag("Ennemy")?.transform;
            Missile missile = Instantiate(_missilePrefab, transform.position, Quaternion.identity);
            missile.SetTarget(target);
        }
    }
}
