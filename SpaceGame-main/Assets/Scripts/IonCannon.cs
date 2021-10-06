using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class IonCannon : MonoBehaviour
{
    public Rigidbody bullet;
    public AudioClip fireSound;
    private AudioSource audioSrc;
    private bool canShoot = true;

    public void SetCanShoot(bool canShoot)
    {
        this.canShoot = canShoot;
    }

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (canShoot)
            {
                audioSrc.PlayOneShot(fireSound);
                Rigidbody newBullet = Instantiate(bullet, transform.position, Quaternion.identity) as Rigidbody;
                newBullet.velocity = transform.forward * 100.0f;
            }
        }
    }
}
