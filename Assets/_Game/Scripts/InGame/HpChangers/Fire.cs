using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private float hpReduceValue;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CloseFire();
        }
    }
    private void CloseFire()
    {
        GameManager.instance.hp -= hpReduceValue * Time.deltaTime;//reduce hp 10 each second
        GameManager.instance.ReduceHpByFire();
    }//do this if close to fire
}
