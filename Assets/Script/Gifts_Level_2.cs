using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Gifts_Level_2 : MonoBehaviour
{
    public GameObject[] giftsDrop;
    public Vector3 giftPOsition1 = new Vector3(-9f, 4f, 0f);
    public Vector3 giftPOsition2 = new Vector3(-5f, 4f, 0f);
    public Vector3 giftPOsition3 = new Vector3(0f, 4f, 0f);

    private Color[] colors = new Color[4] {Color.green, Color.yellow, Color.red, Color.magenta};
    private GameObject[] changingColors = new GameObject[10];

    void ColorChange()
    {
        giftsDrop[0].GetComponent<SpriteRenderer>().color = colors[Random.Range(0, 4)];
        
        for (int i = 0; i < changingColors.Length; i++)
        {
            giftsDrop[i].GetComponent<SpriteRenderer>().color = colors[Random.Range(0, 4)];
            
        }
    }

    private void Update()
    {
        if (giftsDrop[0] != null)
        {
            ColorChange();
        }
        
    }

    void Start()
    {
        StartCoroutine(DelayCoroutine());
                
        IEnumerator DelayCoroutine()
        {
            foreach(GameObject go in giftsDrop)
            {
                yield return new WaitForSeconds(5f);        // chrono = 5 secondes [Bomb 1/3]
                giftsDrop[0].SetActive(true);               
                giftsDrop[0].transform.position = giftPOsition1;
                ColorChange();
                yield return new WaitForSeconds(4f);
                giftsDrop[0].SetActive(false);
                
                yield return new WaitForSeconds(1f);        // chrono = 10 secondes [Gift 1/6]
                giftsDrop[1].SetActive(true);               
                giftsDrop[1].transform.position = giftPOsition2;
                
                yield return new WaitForSeconds(5f);        // chrono = 15 secondes [Gift 2/6]
                giftsDrop[2].SetActive(true); 
                giftsDrop[2].transform.position = giftPOsition3;

                yield return new WaitForSeconds(5f);       // chrono = 20 secondes [Dark gift]
                giftsDrop[3].SetActive(true);               
                giftsDrop[3].transform.position = giftPOsition2;
                yield return new WaitForSeconds(3f);
                giftsDrop[3].SetActive(false);
                
                yield return new WaitForSeconds(5f);        // chrono = 28 secondes [Gift 3/6]
                giftsDrop[4].SetActive(true);
                giftsDrop[4].transform.position = giftPOsition2;

                yield return new WaitForSeconds(7f);        // chrono = 35 secondes [Gift 4/6]
                giftsDrop[5].SetActive(true);
                giftsDrop[5].transform.position = giftPOsition1;
                
                yield return new WaitForSeconds(5f);        // chrono = 40 secondes [Bomb 2/3]
                giftsDrop[6].SetActive(true);
                giftsDrop[6].transform.position = giftPOsition2;
                yield return new WaitForSeconds(3f);
                giftsDrop[6].SetActive(false);
                
                yield return new WaitForSeconds(2f);        // chrono =  45 secondes [Gift 6/6] - Will be blocked
                giftsDrop[7].SetActive(true);
                giftsDrop[7].transform.position = giftPOsition1;
                
                yield return new WaitForSeconds(1f);       // chrono = 46 secondes [Bomb 3/3] - Chest Blocker
                giftsDrop[8].SetActive(true);               
                giftsDrop[8].transform.position = giftPOsition3;
                yield return new WaitForSeconds(3f);
                giftsDrop[8].SetActive(false);
                
                yield return new WaitForSeconds(5f);        // chrono =  54 secondes [Gift 6/6] - Will be blocked
                giftsDrop[9].SetActive(true);
                giftsDrop[9].transform.position = giftPOsition1;
                
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