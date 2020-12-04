using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyaraScript : MonoBehaviour
{
    public AudioClip missionComplete;
    public ParticleSystem love;
    public GameObject kissingBooth;
    public 
    
    void OnTriggerEnter2D(Collider2D kissingBooth)
    {
        RubyController controller = kissingBooth.GetComponent<RubyController>();

        if (controller != null)
        {
            
        
                Destroy(gameObject);
            
                controller.PlaySound(missionComplete);
                
                love.Stop();
        
        }

    }

     public void ChangeScore(int amount)
    {
        currentScore = currentScore + 1;
    }
}
