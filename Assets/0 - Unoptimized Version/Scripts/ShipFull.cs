using UnityEngine;

namespace Solid.Unoptimized
{
    public class ShipFull : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 1.0f;
        [SerializeField]
        private GameObject _projecticlePrefab;
        [SerializeField]
        private Transform _weaponMountPoint;
        [SerializeField]
        private float _fireForce = 300.0f;
        [SerializeField]
        private float _turnSpeed = 5.0f;
        [SerializeField]
        private ParticleSystem[] _thrusterParticles;
        [SerializeField]
        private int _maxHealth = 100;
        [SerializeField]
        private GameObject _deathParticleSystemPrefab;

        private int _currentHealth;

        private void Awake()
        {
            _currentHealth = _maxHealth;
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
                FireWeapon();

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            transform.position += Time.deltaTime * vertical * transform.forward * _speed;
            transform.Rotate(transform.up * horizontal * _turnSpeed * Time.deltaTime);

            foreach (var particleSystem in _thrusterParticles)
            {
                if (vertical == 0.0f)
                {
                    if (particleSystem.isPlaying)
                        particleSystem.Stop();
                }
                else if (!particleSystem.isPlaying)
                {
                    particleSystem.Play();
                }
            }
        }

        private void FireWeapon()
        {
            Rigidbody spawnedProjectile = Instantiate(_projecticlePrefab, _weaponMountPoint.position, _weaponMountPoint.rotation).GetComponent<Rigidbody>();
            spawnedProjectile.AddForce(transform.forward * _fireForce);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Projectile projectile = collision.collider.GetComponent<Projectile>();
            if (projectile != null && !projectile.IsPlayerProjectile)
            {
                TakeDamage(projectile.Damage);
                Destroy(projectile.gameObject);
            }
        }

        private void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            if (_currentHealth <= 0)
                Die();
        }

        private void Die()
        {
            Instantiate(_deathParticleSystemPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
