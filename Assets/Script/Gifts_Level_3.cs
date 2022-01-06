using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gifts_Level_3 : MonoBehaviour
{

    public GameObject gift1;
    public GameObject leftPosition;

    public GameObject gift2;
    public GameObject centerPosition;

    public GameObject gift3;
    public GameObject rightPosition;


    private void GiftDrop()
    {
        Instantiate<GameObject>(gift1, leftPosition.transform);      
        
    }

    private void GiftDrop2()
    {
        Instantiate<GameObject>(gift2, centerPosition.transform);

    }

    private void GiftDrop3()
    {
        Instantiate<GameObject>(gift3, rightPosition.transform);

    }

    void Start()
    {
        InvokeRepeating("GiftDrop", 5f, 30f);
        InvokeRepeating("GiftDrop2", 10f, 30f);
        InvokeRepeating("GiftDrop3", 15f, 30f);
    }

   
   
    

}
