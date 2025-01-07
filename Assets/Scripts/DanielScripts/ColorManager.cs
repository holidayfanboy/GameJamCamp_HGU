using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] int mapx = 50;
    [SerializeField] int mapy = 50;
    [SerializeField] GameObject backPrefab;

    enum Team
    {
        none, red, blue, green, yellow, orange
    }

    private Color[] colorlist = new Color[]
    {
        Color.gray, 
        Color.red,   
        Color.blue,  
        Color.green,
        Color.yellow,
        new Color(1f, 0.5f, 0f) 
    };

    void Awake()
    {
        MakeMap();
    }

    void Update()
    {
        
    }

    public Color GiveColor(int a)
    {
        return colorlist[a];
    }

    void MakeMap()
    {
        for (int i = 0; i < mapy; i++)
        {
            for (int j = 0; j < mapx; j++)
            {

                Vector2 spawn = new Vector2(transform.position.x + j * 0.5f, transform.position.y - i*0.5f);
                backPrefab = Instantiate(backPrefab, spawn, Quaternion.Euler(0, 0, 0));
            }
        }
    }
}
