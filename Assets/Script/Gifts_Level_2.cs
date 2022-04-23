using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gifts_Level_2 : MonoBehaviour
{
    public GameObject[] giftsDrop;
   
    void Start()
    {
        StartCoroutine(DelayCoroutine());
                
        IEnumerator DelayCoroutine()
        {
            foreach(GameObject go in giftsDrop)
            {
                yield return new WaitForSeconds(5f);
                giftsDrop[0].SetActive(true);               // chrono = 5 secondes
                yield return new WaitForSeconds(3f);
                giftsDrop[0].SetActive(false);
                
                
                yield return new WaitForSeconds(2f);
                giftsDrop[1].SetActive(true);               // chrono = 10 secondes

                yield return new WaitForSeconds(5f);
                giftsDrop[2].SetActive(true);               // chrono = 15 secondes

                yield return new WaitForSeconds(10f);
                giftsDrop[3].SetActive(true);               // chrono = 20 secondes
                giftsDrop[3].transform.position += new Vector3(4f, 0f, 0f);
                yield return new WaitForSeconds(3f);
                giftsDrop[3].SetActive(false);
                
                yield return new WaitForSeconds(2f);
                giftsDrop[4].SetActive(true);               // chrono = 30 secondes

                yield return new WaitForSeconds(5f);
                giftsDrop[5].SetActive(true);               // chrono = 35 secondes
                
                yield return new WaitForSeconds(10f);
                giftsDrop[6].SetActive(true);               // chrono = 40 secondes
                
                yield return new WaitForSeconds(3f);
                giftsDrop[6].SetActive(false);
                
                break;
            } 

        }

    }

    


}


/*
 
    public GameObject gift1;
    public GameObject gift2;
    public GameObject gift3;

    public GameObject gift4;
    public GameObject gift5;
    public GameObject gift6;
 
     void Start()
    {        
        Invoke("GiftDrop", 10f);
        Invoke("GiftDrop2", 15f);
        Invoke("GiftDrop3", 20f);
        Invoke("GiftDrop4", 30f);
        Invoke("GiftDrop5", 35f);
        Invoke("GiftDrop6", 45f);
    }   


     private void GiftDrop()
        {
            gift1.SetActive(true);
        }
    
    private void GiftDrop2()
        {
            gift2.SetActive(true);
        }

    private void GiftDrop()
        {
            gift3.SetActive(true);
        }

    private void GiftDrop()
        {
            gift4.SetActive(true);
        }    

    private void GiftDrop()
        {
            gift5.SetActive(true);
        }

    private void GiftDrop()
        {
            gift6.SetActive(true);
        }

 */