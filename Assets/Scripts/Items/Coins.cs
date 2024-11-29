using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public string name_coins;
    public int value_coins;
    LayerMask mask;

    public int n_coins;
    public Coins_Points points;

    public void RandomValue()
    {
        value_coins = Random.Range(0, 20);
    }

    public int getCoins()
    {
        return value_coins;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Movement_Player>() != null)
        {

            points.Sumar_Coins();


            Destroy(gameObject);

        }
            

        
    }
}
