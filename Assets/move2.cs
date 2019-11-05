using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move2 : MonoBehaviour
{
    public int n;
    public Image[] healthImg;
	public GameObject check;
	public int health=3;
	public GameObject timeobj;
	public GameObject loosePanel;
	AudioSource rb;
	public AudioClip correct;
	public AudioClip wrong;




void Start(){
check=GameObject.FindGameObjectWithTag("imgDisp");
timeobj=GameObject.Find("timer");
loosePanel=GameObject.Find("loose");
loosePanel.SetActive(false);
 rb = GetComponent<AudioSource> ();

}
void Update(){
	
	if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
 {
 RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint((Input.GetTouch (0).position)), Vector2.zero);
 if(hit.collider != null)
 { 
 	n=check.GetComponent<showLogo>().ck;
 		if(n==0 && hit.collider.tag=="abio" ){

	// Gameobject child=hit.collider.gameObject;
	// Gameobject parent=child.transform.parent.gameObject;
	

		GameObject target = hit.collider.transform.parent.gameObject;
     rb.PlayOneShot (correct, 0.7f);
	target.GetComponent<randomSpawn>().destroy=true;
	timeobj.GetComponent<timer>().time+=1f;
	timeobj.GetComponent<timer>().points+=1;
	

}
      else if(n==0 && hit.collider.tag!="abio"){
      	 GameObject target = hit.collider.transform.parent.gameObject;
      	 health-=1;
      	 target.GetComponent<randomSpawn>().destroy=true;
      	 healthCheck(health);
      	 timeobj.GetComponent<timer>().time-=0.5f;
      	  rb.PlayOneShot (wrong, 0.7f);


      }
else if(n==1 && hit.collider.tag=="bio"){
   GameObject target = hit.collider.transform.parent.gameObject;
   target.GetComponent<randomSpawn>().destroy=true;
   timeobj.GetComponent<timer>().time+=1f;
   timeobj.GetComponent<timer>().points+=1;
    rb.PlayOneShot (correct, 0.7f);
	
}
else if(n==1 && hit.collider.tag!="bio"){
   GameObject target = hit.collider.transform.parent.gameObject;
   target.GetComponent<randomSpawn>().destroy=true;
   timeobj.GetComponent<timer>().time-=0.5f;
    rb.PlayOneShot (wrong, 0.7f);

	health-=1;
	healthCheck(health);
}
}
 }
 }
 void healthCheck(int h){
 	if(h<=0){
 		Time.timeScale=0f;  
 		healthImg[0].enabled=false;
 		loosePanel.SetActive(true);

 		
 	}
 	else{
     healthImg[h].enabled=false;
 	}

 }
}


