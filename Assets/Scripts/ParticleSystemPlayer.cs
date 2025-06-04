using UnityEngine;

public class ParticleSystemPlayer : MonoBehaviour
{
    [SerializeField] private ParticleSystem jumpParticles;
    [SerializeField] private ParticleSystem fallParticles;

    private void Start()
    {
        jumpParticles.Stop();
        fallParticles.Stop();
    }

    public void PlayJumpParticles()
    {
        fallParticles.Stop();
        jumpParticles.Play();
    }

    public void PlayFallParticles()
    {
        jumpParticles.Stop();
        fallParticles.Play();
    }
}
