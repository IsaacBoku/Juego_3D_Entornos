using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins_Points : MonoBehaviour
{
    [Header("UI_Coins")]
    [SerializeField] private TextMeshProUGUI number_coins;

    public Coins[] coins;

    public int n_coins;



    private void Start()
    {
        //ContadorCoins();
    }
    private void Update()
    {
        UI_Coins_Points();
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

    public void UI_Coins_Points()
    {
        string point_Coins = n_coins.ToString("Coins: "+ n_coins);

        number_coins.text = point_Coins;
    }

    public int Sumar_Coins()
    {
        return n_coins++;
    }


}
