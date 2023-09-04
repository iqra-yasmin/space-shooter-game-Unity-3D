using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroyByboundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            return;
        }
        Destroy(other.gameObject);
    }
}
