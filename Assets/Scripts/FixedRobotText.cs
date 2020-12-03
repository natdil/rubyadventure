using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixedRobotText : MonoBehaviour
{
    public Text FixedText;
    public int fixedRobots;
    // Start is called before the first frame update
    void Start()
    {
        fixedRobots = 0;
    }

    // Update is called once per frame
    void Update()
    {
        FixedText.text = "Robots are fixed yo " + fixedRobots;   
    }
}
