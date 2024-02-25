using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldiercontroller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Helicopter"))
        {
            Debug.Log("Soldier collided with helicopter!");
            GameManager.Instance.IncrementSoldiersRescued();
            AudioManager.Instance.PlayPickupSound();
            Destroy(gameObject); 
        }
    }
}
