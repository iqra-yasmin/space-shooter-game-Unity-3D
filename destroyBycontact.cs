using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class destroyBycontact : MonoBehaviour

{
	//public GameObject gameoverprefabs;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "boundary")
		{
			return;
		}
		if (other.tag == "Player")
		{
			Destroy(other.gameObject);
			SceneManager.LoadScene(5);
			//gameoverprefabs.SetActive(true);
			Debug.Log("iqea");


		}
		else
		{
			Destroy(this.gameObject);
			//gameoverprefabs.SetActive(false);
			scoremanager.instance.AddPoint();
		}

	}
};