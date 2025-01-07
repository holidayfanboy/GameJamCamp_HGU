using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int bombCount;
    [SerializeField] TMP_Text Bcounttext;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void bombAdded()
    {
        bombCount++;
        Bcounttext.text = bombCount.ToString();
    }
}
