using UnityEngine;
using System.Collections;


using UnityEngine.SceneManagement;

public class LevelControl3 : MonoBehaviour {
	
	// Use this for initialization
	
	void OnTriggerEnter2D(Collider2D other)
    {
		//if the object that triggered the event is tagged player
		if (other.CompareTag("Player"))
        {
			//Application.LoadLevel(1);
			SceneManager.LoadScene(3);
		}
		
//		if (other.gameObject.transform.parent) {
//			Destroy (other.gameObject.transform.parent.gameObject);
//			
//		} else {
//			Destroy (other.gameObject);		
//		}
	}
	
}




