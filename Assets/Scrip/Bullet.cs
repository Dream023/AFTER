using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    bool isDelay = false;
    private void Update()
    {
        if (isDelay)
            return;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StartCoroutine(Delay());
            return;
        }
    }
    void Attack()
    {
        GameObject clone = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
    }
    IEnumerator Delay()
    {
        isDelay = true;
        yield return new WaitForSeconds(0.37f);
        Attack();
        yield return new WaitForSeconds(0.15f);
        isDelay = false;
    }
}
