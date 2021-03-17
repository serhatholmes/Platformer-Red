using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{

    [SerializeField] AudioClip coinPickUpSFX;
    [SerializeField] int pointsForCoinPickUp = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickUp);
        AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position, .3f);
        Destroy(gameObject);
    }

}
