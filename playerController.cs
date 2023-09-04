using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class playerController : MonoBehaviour
{
    public float speed;
    public Boundary boundary;
    public float tilt;
    public int power;
    public GameObject shot;
    //public Transform shotspawn;
    public float fire1;
    public float nextFire;

    public float fireRate;

    public AudioSource audioSource;
    [SerializeField] AudioClip boltClip;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        power = PlayerPrefs.GetInt("pow");
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, transform.position, transform.rotation);
            audioSource.clip = boltClip;
            audioSource.Play();
        }
        else if (power == 1)
        {

            Instantiate(shot, transform.position, Quaternion.Euler(new Vector3(0, -20, 0)));
            //yield return new WaitForSeconds(2);
            Instantiate(shot, transform.position, Quaternion.Euler(new Vector3(0, 20, 0)));
            //yield return new WaitForSeconds (2);
            Instantiate(shot, transform.position, Quaternion.Euler(new Vector3(0, -10, 0)));
            Instantiate(shot, transform.position, Quaternion.Euler(new Vector3(0, 10, 0)));
            Instantiate(shot, transform.position, transform.rotation);
            PlayerPrefs.SetInt("pow", 0);
        }


    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;
        GetComponent<Rigidbody>().position = new Vector3
            (Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
           Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
           );

    }
}