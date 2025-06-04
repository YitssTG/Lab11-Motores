using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    [SerializeField] public float _jumpForce;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _rotationSpeed;
    private float _rotationDirection;
    [SerializeField] private ParticleSystemPlayer playerParticles;
    private void Awake()
    {
        if (playerParticles == null)
        {
            playerParticles = GetComponent<ParticleSystemPlayer>();

            if (playerParticles == null)
            {
                playerParticles = GetComponentInChildren<ParticleSystemPlayer>();
            }
            if (playerParticles == null)
            {
                Debug.LogWarning("PlayerParticles no esta refernciado");
            }
        }
    }
    private void Start()
    {
        UpForce();
    }
    private void FixedUpdate()
    {
        _rigidbody.rotation = _rigidbody.rotation * Quaternion.Euler(Vector3.forward * _rotationDirection * Time.deltaTime);
    }
    public void UpForce()
    {
        _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

        Physics.gravity = new Vector3(0f, -9.18f, 0f);
        _rotationDirection = _rotationSpeed * -1;
        _rigidbody.rotation = Quaternion.Euler(Vector3.forward * 45);

        if (playerParticles != null)
            playerParticles.PlayJumpParticles();
        else
            Debug.LogWarning("PlayerParticles no esta asigndo");
    }
    public void DownForce()
    {
        _rigidbody.AddForce(Vector3.down * _jumpForce, ForceMode.Impulse);

        Physics.gravity = new Vector3(0f, 9.18f, 0f);
        _rotationDirection = _rotationSpeed;
        _rigidbody.rotation = Quaternion.Euler(Vector3.forward * -45);
        playerParticles.PlayFallParticles();
    }
    public void Death()
    {
        if(OnPlayerDeath != null)
        {
            OnPlayerDeath?.Invoke();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("limit"))
        {
            Death();
        }
    }
}
