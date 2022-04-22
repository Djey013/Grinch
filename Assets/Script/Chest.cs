using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public MyScriptableObject persistent;
    public Text board2;
    public Animator _animator;


    private void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    public void Update()
    {
        //ChestBoard();
    }
    

    public void ChestBoard()
    {
        board2.text = " " + persistent.chested;
    }

    

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            _animator.SetTrigger("IsOpen");

        }

    }
    
    
}
