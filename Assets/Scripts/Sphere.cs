using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sphere : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
 		transform.Rotate(0, 2f, 0, Space.World);
    }

    void OnTriggerEnter(Collider other) {
        WinText.winText.color = new Color(0, 146, 241, 1); 
		WinText.winText.text = "YOU WON";

		Invoke("ReloadScene", 3);
	}

	void OnTriggerExit(Collider other) {
		//SceneManager.LoadScene("MyLevelScene");
	}

	void ReloadScene(){
		SceneManager.LoadScene("MyLevelScene");
	}
}
