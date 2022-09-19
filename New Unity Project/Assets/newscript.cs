using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newscript : MonoBehaviour
{

    public GameObject p2healthGO;
    public int p2hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        p2healthGO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = p2hp + "";
    }

    public void dealdamage(int currenthp, int damageAmount, int accuracy)
    {
        int ran = Random.Range(0, 101);
        if(ran <= accuracy) { 
        p2hp = currenthp -= damageAmount;
        }
    }
    
    public void P1LowKick()
    {
       
        dealdamage(p2hp, 7, 50);
    }

}
