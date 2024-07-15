using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    public int myScore;
    public AudioSource audi;
    public AudioClip efx;
void Start()
{
    myScore = 0;
}


 private void OnCollisionEnter(Collision collision)
 {
    if(collision.gameObject.tag == "Body_Blue")
    {
        audi.clip = efx;
        Destroy(collision.gameObject);
        myScore += 1;
        print(myScore);
        audi.Play();
    }
 }
}
