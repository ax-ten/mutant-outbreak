using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBar : MonoBehaviour
{
    public GameObject xpBarHolder, xpBarOre, xpBarOoze, xpBarPlant;
    RectTransform HolderTransform, OreTransform, OozeTransform, PlantTransform;
    //Quantità SLICE 
    float oreAmount = 25, oozeAmount = 25, plantAmount = 50;
    int maxSpliceAmount = 100;
    float barHeight, maxSpliceWidth;

    // Start is called before the first frame update
    void Start()
    {
        HolderTransform = xpBarHolder.GetComponent<RectTransform>();
        OreTransform = xpBarOre.GetComponent<RectTransform>();
        OozeTransform = xpBarOoze.GetComponent<RectTransform>();
        PlantTransform = xpBarPlant.GetComponent<RectTransform>();

        barHeight = HolderTransform.sizeDelta.y - 6;
        maxSpliceWidth = (HolderTransform.sizeDelta.x - 10);
    }

    // Update is called once per frame
    void Update()
    {
        //+++MOVE BARS+++
        //1st bar
        xpBarOre.transform.position = new Vector2(HolderTransform.position.x + 5, HolderTransform.position.y);
        //2nd bar
        xpBarOoze.transform.position = new Vector2(OreTransform.position.x + OreTransform.sizeDelta.x, OreTransform.position.y);
        //3rd bar
        xpBarPlant.transform.position = new Vector2(OozeTransform.position.x + OozeTransform.sizeDelta.x, OozeTransform.position.y);
        
        if(oreAmount + oozeAmount + plantAmount >= 100)
        {
            Debug.Log("Aumento Livello");
            //TODO: trigger "buy ability"
        }

        //+++RESIZE BARS+++
        OreTransform.sizeDelta = new Vector2(((oreAmount / maxSpliceAmount) * maxSpliceWidth) , barHeight);
        OozeTransform.sizeDelta = new Vector2(((oozeAmount / maxSpliceAmount) * maxSpliceWidth) , barHeight);
        PlantTransform.sizeDelta = new Vector2((plantAmount / maxSpliceAmount) * maxSpliceWidth, barHeight);
        
    }
}
