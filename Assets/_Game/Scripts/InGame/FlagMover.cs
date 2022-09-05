using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagMover : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject winWall;

    private float flagEndPos;
    private float playerStartPos;

    [SerializeField] private Material winColor;

    private void OnTriggerEnter(Collider other)
    {
        playerStartPos = player.transform.position.z;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var positionY = Mathf.InverseLerp(playerStartPos,
                transform.position.z, player.transform.position.z)*4f;
            transform.position = new Vector3(transform.position.x, 1.5f+positionY, transform.position.z);
            CheckGameWin();//check flag pos
        }
    }

    private void CheckGameWin()
    {
        if (transform.position.y>4.5f)
        {
            GetComponent<MeshRenderer>().material = winColor;
            winWall.SetActive(false);
            Destroy(this);//remove flag mover script when reach highest point
        }
    }
}
