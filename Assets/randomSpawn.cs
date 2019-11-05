using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawn : MonoBehaviour
{   public GameObject[] objects;
	int length;
	public float time=0f;
	public bool put=true;
	GameObject t;
	public bool destroy=false;
	public GameObject missedUpdate;
	public GameObject logo;
    public float rand;

    // Start is called before the first frame update
    void Start()
    {   missedUpdate=GameObject.Find("timer");
        logo=GameObject.FindGameObjectWithTag("imgDisp");
        length=objects.Length;

    }

    // Update is called once per frame
    void Update()
    {   int num=Random.Range(0,length);
    	int y=logo.GetComponent<showLogo>().ck;
        time+=Time.deltaTime;
        rand=Random.Range(0f,1f);
        if(put==true){
        	if(time>(2f+rand)){
        		time=0f;
         t=(GameObject)Instantiate(objects[num],transform.position,Quaternion.identity);
         t.transform.parent=gameObject.transform;
        put=false;
    	}}
    	else if(time>=3f && destroy==false){
    		time=0f;
    		put=true;
    		Destroy(t);
    		if(y==0 && t.gameObject.tag=="abio"){
    		missedUpdate.GetComponent<timer>().missed+=1;
		}
		else if(y==1 && t.gameObject.tag=="bio"){

			missedUpdate.GetComponent<timer>().missed+=1;
		}
    	}
    	if(destroy==true){
    		Destroy(t);
    		
    			destroy=false;
    			time=0f;
    		    put=true;


    		

    	}
    	

    }
}
