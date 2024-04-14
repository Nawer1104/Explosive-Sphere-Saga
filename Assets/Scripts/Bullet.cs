using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    public int bulletId;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);

        if (collision != null && collision.gameObject.CompareTag("Wood"))
        {
            collision.gameObject.SetActive(false);
        }

        if (collision != null && collision.gameObject.CompareTag("Big"))
        {
            if (collision.gameObject.GetComponent<BigBall>().ballId == bulletId)
            {
                collision.gameObject.GetComponent<BigBall>().GetHit();
            }
        }

        Destroy(gameObject);
    }
}