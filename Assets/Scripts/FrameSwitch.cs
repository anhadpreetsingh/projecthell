using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSwitch : MonoBehaviour
{
    // Start is called before the first frame update
   	public GameObject frame1;
	public GameObject frame2;
	
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if(frame1.active == true)
		{
			frame1.SetActive(false);
			frame2.SetActive(true);
		}
		else if(frame1.active == false)
		{
			frame1.SetActive(true);
			frame2.SetActive(false);
		}
			
	}
	
}
