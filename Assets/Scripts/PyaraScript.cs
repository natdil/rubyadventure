using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PyaraScript : MonoBehaviour
{
    public AudioClip missionComplete;
    public ParticleSystem love;
    public GameObject kissingBooth;
    
    
  
    
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
}
