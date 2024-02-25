using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicoptercontroller : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int maxSoldiers = 3;

    private int currentSoldiers = 0;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Soldier"))
        {
            if (currentSoldiers < maxSoldiers)
            {
                currentSoldiers++;
                GameManager.Instance.UpdateSoldiersInHelicopter(currentSoldiers);
                AudioManager.Instance.PlayPickupSound();
                Destroy(other.gameObject);
            }
        }
        else if (other.CompareTag("Tree"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
