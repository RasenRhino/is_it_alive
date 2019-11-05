using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startPause : MonoBehaviour
{	float time;
	public Image img;
	public GameObject panel;
	
	public Image count;
	public Sprite[] countText;

    // Start is called before the first frame update
    void Start()
    {
     
     GameObject canvas=GameObject.FindGameObjectWithTag("mainCanvas");
     Transform imgD=canvas.transform.Find("Image");
     panel=GameObject.Find("Panel");
   
     img=imgD.GetComponent<Image>();
     count=panel.transform.Find("count").GetComponent<Image>();

    
    
     StartCoroutine(wait());
      
     
    }

    // Update is called once per frame
   IEnumerator wait(){

   	Time.timeScale=0f;  
   	float time=Time.realtimeSinceStartup+5;
   	float number3 = Time.realtimeSinceStartup + 1; // 10 + 1 = 11
         float number2 = Time.realtimeSinceStartup + 2; // 10 + 2 = 12
         float number1 = Time.realtimeSinceStartup + 3; // 10 + 3 = 13
         float go = Time.realtimeSinceStartup + 4; // 10 + 3 = 13
   	 img.enabled=false;

   	  
   	while(Time.realtimeSinceStartup<time){
 		if(Time.realtimeSinceStartup <= number3)  {
        count.sprite=countText[3];
   	  }
   	  else if(Time.realtimeSinceStartup <= number2)  {
        count.sprite=countText[2];
   	  }
   	  else if(Time.realtimeSinceStartup <= number1)  {
        count.sprite=countText[1];
   	  }
   	  else if(Time.realtimeSinceStartup <= go)  {
        count.sprite=countText[0];
   	  }
 		yield return null;
   	}
   	 img.enabled=true;
   	 panel.SetActive(false);
   Time.timeScale=1f;		
   }
}
