using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public GameObject HPBarHolder, HPBarHealth;
    RectTransform HolderTransform, HealthTransform;
    float health = 100;
    int maxHealthAmount = 100;
    float barHeight, maxHealthWidth;

    // Start is called before the first frame update
    void Start()
    {
        HolderTransform = HPBarHolder.GetComponent<RectTransform>();
        HealthTransform = HPBarHealth.GetComponent<RectTransform>();

        barHeight = HolderTransform.sizeDelta.y - 6;
        maxHealthWidth = (HolderTransform.sizeDelta.x - 10);
    }

    // Update is called once per frame
    void Update()
    {
        //+++MOVE BAR+++
        HPBarHealth.transform.position = new Vector2(HolderTransform.position.x + 5, HolderTransform.position.y);
        
        if(health <= 0)
        {
            Debug.Log("MORTO 💀💀💀💀💀");
            //TODO: trigger "buy ability"
        }

        //+++RESIZE BARS+++
        HealthTransform.sizeDelta = new Vector2(((health / maxHealthAmount) * maxHealthWidth) , barHeight);
        
    }
}
