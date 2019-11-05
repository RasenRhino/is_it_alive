using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pauseGame : MonoBehaviour
{   public bool pause=false;
	public GameObject pausePanel;
	public GameObject maintrigger;
	public GameObject pbutton;
    // Start is called before the first frame update
    void Start()
    {
	  pausePanel=GameObject.Find("PausePanel");
	  maintrigger=GameObject.Find("clickOnObject");
 	  pbutton=GameObject.Find("PauseButton");	
	 
	  pausePanel.SetActive(false);

      
      // StartCoroutine(pauseG());   
    }

public void Startpause(){

	if(pause==false){
		maintrigger.SetActive(false);
		pbutton.SetActive(false);
		pause=true;
 Time.timeScale=0f;
 pausePanel.SetActive(true);}
 else if(pause==true){
 	maintrigger.SetActive(true);
 	pbutton.SetActive(true);
 	pause=false;
 	Time.timeScale=1f;
 pausePanel.SetActive(false);

 }

}

public void exit(){
	 Application.Quit();
}
public void restart(){
 	Application.LoadLevel(2);
 }


// IEnumerator pauseG(){
// if(Input.GetKeyDown(KeyCode.A) && pause==false){
//          resButton.SetActive(true);
//          pause=true;
//          Startpause();

//         }
// else if(Input.GetKeyDown(KeyCode.A) && pause==true){
// 	pause=false;
//     resButton.SetActive(false);
//    //  float time=Time.realtimeSinceStartup+5;
//    // 	float number3 = Time.realtimeSinceStartup + 1; // 10 + 1 = 11
//    //       float number2 = Time.realtimeSinceStartup + 2; // 10 + 2 = 12
//    //       float number1 = Time.realtimeSinceStartup + 3; // 10 + 3 = 13
//    //       float go = Time.realtimeSinceStartup + 4; // 10 + 3 = 13
//    // 	 cimg.enabled=true;

   	  
//    // 	while(Time.realtimeSinceStartup<time){
//  		// if(Time.realtimeSinceStartup <= number3)  {
//    //      cimg.sprite=counter[3];
//    // 	  }
//    // 	  else if(Time.realtimeSinceStartup <= number2)  {
//    //      cimg.sprite=counter[2];
//    // 	  }
//    // 	  else if(Time.realtimeSinceStartup <= number1)  {
//    //      cimg.sprite=counter[1];
//    // 	  }
//    // 	  else if(Time.realtimeSinceStartup <= go)  {
//    //      cimg.sprite=counter[0];
//    // 	  }
 		
//    // 	}
// 	EndPause();


// }
//  yield return null;
//   StartCoroutine(pauseG());   
// }
    
}
