using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixedRobotText : MonoBehaviour
{
    public Text FixedRobotText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText(int fixedRobots)
    {
        FixedRobotText.text = "Robots are fixed yo";
    }
}
