using UnityEngine;
using System.Collections;

public class PowerCollision : MonoBehaviour {
	public static int pow=0;
		void OnTriggerExit (Collider other) 
		{
			if (other.tag == "Player") {
			PlayerPrefs.SetInt("pow",1);
			Destroy (gameObject);
			//audio.Play();

			      
		}
			if(other.tag=="enemy"||other.tag=="asteriods1")
        {
			return;
        }

		}
	}