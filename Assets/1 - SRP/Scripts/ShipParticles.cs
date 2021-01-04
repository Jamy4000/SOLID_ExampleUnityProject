using System;
using UnityEngine;

namespace Solid.SRP
{
    public class ShipParticles : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem[] _thrusterParticles;
        [SerializeField]
        private GameObject _deathParticleSystemPrefab;

        public event Action<float> ThrustChanged = delegate { };

        private ShipInput _shipInput;

        private void Awake()
        {
            var shipHealth = GetComponent<ShipHealth>();
            if (shipHealth)
                shipHealth.OnDie += HandleShipDeath;

            _shipInput = GetComponent<ShipInput>();
            if (!_shipInput)
                this.enabled = false;
        }

        private void Update()
        {
            foreach (var particleSystem in _thrusterParticles)
            {
                if (_shipInput.Vertical > 0.0f)
                {
                    if (!particleSystem.isPlaying)
                        particleSystem.Play();
                }
                else if (particleSystem.isPlaying)
                {
                    particleSystem.Stop();
                }
            }
        }

        private void HandleShipDeath()
        {
            Transform _deathParticles = Instantiate(_deathParticleSystemPrefab).transform;
            _deathParticles.position = transform.position;
        }
    }
}