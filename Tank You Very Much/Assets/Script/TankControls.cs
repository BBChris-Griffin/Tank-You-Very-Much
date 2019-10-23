using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public Transform bulletSpawn;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.tag == "P1")
        {
            float translationX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float translationY = Input.GetAxis("Vertical") * -speed * Time.deltaTime;
            this.transform.Translate(translationY, translationX, 0);

            if(Input.GetButtonDown("Fire1"))
            {
                // Prevents rapid fire
                nextFire = Time.time + fireRate;
                Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
                audio.Play();
            }
        }
        if (this.tag == "P2")
        {
            float translationX = Input.GetAxis("Horizontal2") * speed * Time.deltaTime;
            float translationY = Input.GetAxis("Vertical2") * speed * Time.deltaTime;
            this.transform.Translate(translationY, translationX, 0);

            if (Input.GetButtonDown("Fire2"))
            {
                // Prevents rapid fire
                nextFire = Time.time + fireRate;
                Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
                audio.Play();

            }
        }
        
    }
}
