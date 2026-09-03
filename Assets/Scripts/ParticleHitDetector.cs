using UnityEngine;

public class ParticleHitDetector : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particle‚ª“–‚½‚Á‚½I");

        GameManager.Instance.GameOver();
    }
}