using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadLevel : MonoBehaviour
{    public AudioClip beep;
	AudioSource rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
//     void Update()
//     {
//         if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
//  {
//  RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint((Input.GetTouch (0).position)), Vector2.zero);
//  if(hit.collider != null)
//  { if(hit.collider.tag=="loadlevel"){
//  	Application.LoadLevel(1);
//  	rb.PlayOneShot (beep, 0.7f);
 	
//  }
//     }
// }}
public void ChangeLevel(){
	Application.LoadLevel(1);
	rb.PlayOneShot (beep, 0.7f);

}
}
