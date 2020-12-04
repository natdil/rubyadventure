﻿public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    public ParticleSystem healthEffect;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            
                controller.PlaySound(collectedClip);
                
                healthEffect.Stop();
            }
        }

    }
}