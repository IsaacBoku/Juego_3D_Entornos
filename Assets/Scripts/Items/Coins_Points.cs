using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins_Points : MonoBehaviour
{
    [Header("UI_Coins")]
    TextMeshProUGUI number_coins;

    [Header("Coins")]
    public Coins[] coins;
    public int n_coins;
    public LayerMask layerPlayer;

    private void Start()
    {
        ContadorCoins();
    }
    private void Update()
    {
        
    }
    private void ContadorCoins()
    {

        int n_random = Random.Range(0, coins.Length);
        Instantiate(coins[n_random]);

        for(int i = 0; i < coins.Length; i++)
        {
            var coinsInstanciate = Instantiate(coins[i]);

            coinsInstanciate.GetComponent<Coins>().RandomValue();

            if(coinsInstanciate.GetComponent<Coins>().getCoins() > 10)
            {
                coinsInstanciate.transform.position += new Vector3(0, 3f, 0);
            }
        }

    }

    private void Sumar_Coins()
    {
        string point_Coins = n_coins.ToString();

        number_coins.text = point_Coins;

        


    }


}
