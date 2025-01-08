using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{ //안기훈 교수님
    [SerializeField] int mapx = 50;
    [SerializeField] int mapy = 50;
    [SerializeField] GameObject backPrefab;
    [SerializeField] GameObject wallPrefab;

    enum Team
    {
        none, red, blue, green, yellow, orange
    }

    private Color[] colorlist = new Color[]
    {
        Color.gray, 
        new Color(0.9575471f,0.319f,0.3884389f),   
        new Color(0.03239589f,0.6663342f,0.9811321f),  
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
                Instantiate(backPrefab, spawn, Quaternion.Euler(0, 0, 0));
                if (i == 0) //위
                {
                    Vector2 wallspawn = new Vector2(transform.position.x + j * 0.5f + 0.25f, transform.position.y + 0.5f);
                    Instantiate(wallPrefab, wallspawn, Quaternion.Euler(0,0,90));
                }
                if (j == 0) //왼
                {
                    Instantiate(wallPrefab, new Vector2(transform.position.x - 0.5f, transform.position.y - (i + 1) * 0.5f), Quaternion.Euler(0,0,180));
                }
                if (j == mapx-1) //오
                {
                    Instantiate(wallPrefab, new Vector2(transform.position.x + j * 0.5f + 0.25f, transform.position.y - (i + 1) * 0.5f), Quaternion.Euler(0,0,0));
                }
                if (i == mapy-1)//아래
                {
                    Instantiate(wallPrefab, new Vector2(transform.position.x + j * 0.5f + 0.25f, transform.position.y - i*0.5f - 0.5f), Quaternion.Euler(0,0,-90));
                }
            }
        }
    }
}
