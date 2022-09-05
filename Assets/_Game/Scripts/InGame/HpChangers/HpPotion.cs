using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HpPotion : MonoBehaviour
{
    [SerializeField] private float hpGainValue;
    [SerializeField] private GameObject collectParticle;
    [SerializeField] private AudioSource collectSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HpPotionCollected();
            Instantiate(collectParticle, other.transform.position+Vector3.up*3, Quaternion.identity);//instantiate particle on the player
        }
    }   
    private void HpPotionCollected()
    {
        GameManager.instance.AddHp(hpGainValue);
        collectSound.Play();
        gameObject.SetActive(false);
    }//do this when player takes hp potion
}