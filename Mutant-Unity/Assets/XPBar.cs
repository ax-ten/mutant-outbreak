using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBar : MonoBehaviour
{
    public int currentLevel;
    public int maxSplice;

    public GameObject xpBarOre, xpBarOoze, xpBarPlant;
    int barHeight = 28;


    public void setSplice(int spliceType, int expAmount)
    {
        switch (spliceType)
        {
            case 0:
                xpBarOre.GetComponent<RectTransform>().sizeDelta = new Vector2(expAmount, barHeight);
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }
    public void increaseSplice(int spliceType, int expAmount)
    {
        switch (spliceType)
        {
            case 0:
                float currentSize = xpBarOre.GetComponent<RectTransform>().sizeDelta.x;
                xpBarOre.GetComponent<RectTransform>().sizeDelta = new Vector2(currentSize + expAmount, barHeight);
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //increaseSplice(0, 20);

    }

    // Update is called once per frame
    void Update()
    {
        RectTransform xpBarOreTransform = xpBarOre.GetComponent<RectTransform>();
        RectTransform xpBarOozeTransform = xpBarOoze.GetComponent<RectTransform>();
        RectTransform xpBarPlantTransform = xpBarPlant.GetComponent<RectTransform>();

        //BarPosition = previousBarPosition + (previousBarSize / 2) + (currentBarSize / 2)
        //SET (2nd bar) TO DESIRED POSITION
        xpBarOoze.transform.position = new Vector2(xpBarOreTransform.position.x + (xpBarOreTransform.sizeDelta.x / 2) + (xpBarOozeTransform.sizeDelta.x / 2), xpBarOreTransform.position.y);
        //SET (3rd bar) TO DESIRED POSITION
        xpBarPlant.transform.position = new Vector2(xpBarOozeTransform.position.x + (xpBarOozeTransform.sizeDelta.x / 2) + (xpBarPlantTransform.sizeDelta.x / 2), xpBarOozeTransform.position.y);

    }


}
