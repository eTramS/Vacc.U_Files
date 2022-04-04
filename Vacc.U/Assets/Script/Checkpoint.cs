using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    public Sprite bushSpriteActivated;
    [SerializeField] private AudioSource bushSFX;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = bushSpriteActivated;
            bushSFX.Play();
            gm.lastCheckPointPos = transform.position;
            
        }
    }
}
