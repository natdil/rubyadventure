using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyaraScript : MonoBehaviour
{
    public AudioClip missionComplet;
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
