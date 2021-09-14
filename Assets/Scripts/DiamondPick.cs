using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondPick : MonoBehaviour
{
    public AudioClip diamondSound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            CharMoveController.numberOfDiamond += 1;
            Debug.Log("DIAMOND:" + CharMoveController.numberOfDiamond);
            AudioSource.PlayClipAtPoint(diamondSound, transform.position);
            Destroy(gameObject);
        }
    }
}
