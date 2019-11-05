using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{   public Text timeTxt;
	public Text pointTxt;
	public Text missedTxt;
	public float time=100f;
	public GameObject endTimePanel;
	public int points=0;
	public int missed=0;
	public GameObject missedPanel;
	
    // Start is called before the first frame update
    void Start()
    {   endTimePanel=GameObject.Find("EndGame");
       missedPanel=GameObject.Find("missedMuch");
       missedPanel.SetActive(false);
        endTimePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        time-=Time.deltaTime;
        
        timeTxt.text="Time:"+Mathf.RoundToInt(time).ToString();
        pointTxt.text="Points:"+points.ToString();
        missedTxt.text="Missed:"+missed.ToString();
        if(time<=0f){
        	endTimePanel.SetActive(true);

        	Time.timeScale=0f;  
        	

        }
        else if(missed>10){
        	       missedPanel.SetActive(true);
        	Time.timeScale=0f;  

        }
    }
}
