using TMPro;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private float hp;
    [SerializeField] private float wallDamage;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            WallHit();
        }
    }
    private void WallHit()
    {
        GameManager.instance.ReduceHpByWall(wallDamage);
    }//do this when player hits wall
    

}
