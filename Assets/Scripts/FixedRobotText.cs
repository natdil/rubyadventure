using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixedRobotText : MonoBehaviour
{
    public Text FixedText;
    public int fixedRobots = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText()
    {
        fixedRobots = fixedRobots + 1;
        FixedText.text = "Robots are fixed yo" + fixedRobots;
    }
}
