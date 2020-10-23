using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
	public static Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText = GetComponent<Text>();

		// start text off as completely transparent black
		winText.color = new Color(0, 146, 241, 0);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
