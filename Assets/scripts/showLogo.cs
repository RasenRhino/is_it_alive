using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showLogo : MonoBehaviour
{   public Sprite[] images;
public Image imageContainer;
 int num;
public int ck;
int temp;
float time;
AudioSource rb;
	public AudioClip changeSound;
    // Start is called before the first frame update
    void Start()
    {   rb = GetComponent<AudioSource> ();
        num=Random.Range(0,100);
		ck=num%2;
         imageContainer.sprite = images[ck];
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if(time>10f){
        	time=0f;
        num=Random.Range(0,100);
        temp=ck;
        ck=num%2;
        if(ck!=temp){
        rb.PlayOneShot (changeSound, 0.7f);
        }
         imageContainer.sprite = images[ck];
        }
        }
    }

