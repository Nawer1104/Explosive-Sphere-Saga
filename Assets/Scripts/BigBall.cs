using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBall : MonoBehaviour
{
    public int ballId;

    public int health;

    public void GetHit()
    {
        health -= 1;

        if (health <= 0)
        {
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameobjects.Remove(gameObject);
            GameManager.Instance.CheckLevelUp();
            gameObject.SetActive(false);
        }
    }

}
