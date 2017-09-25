using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {
	public float speed;
    public Text countText;
	private Rigidbody rb;
    private int count;
    public Text winText;
    public AudioSource rollAudio;
    public AudioSource crashAudio;
	public AudioSource hitAudio;
    public float timeDuration;
    public GameObject panel;
	public int pickUpCount;
    
	void Start()
	{
        panel.gameObject.SetActive(false);
		rb = GetComponent<Rigidbody> ();
        count = 0;
        
        winText.text = "";
    }

    /*void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}*/

	void Update()
	{
		timeDuration++;
		if (timeDuration > 200) {
			panel.gameObject.SetActive (true);
		}
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            crashAudio.Play();
            other.gameObject.SetActive(false);
            count++;
            setCountText();
		
        }
		/*if(other.gameObject.CompareTag("Wall"))
		{
			hitAudio.Play();
			other.gameObject.SetActive(false);
			crashWall ();
		}*/
        

    }

    void setCountText()
    {
        countText.text = "Score: " + count.ToString();
		countText.fontSize = 35;
		if (count == pickUpCount)
        {
			winText.fontSize = 50;
            winText.text = "You Win!";
        }
       
    }
	/*void crashWall()
	{
		float timer = 0;
		timer++;
		Debug.Log(timer);
		if (timer > 200) 
		{
			panel.gameObject.SetActive (true);
			Debug.Log("if"+timer);
		}
			
	}*/
    

    public void jump(float x, float y)
    {
		Handheld.Vibrate ();
        rollAudio.Play();
        timeDuration = 0;
        Vector3 movement = new Vector3(x, 0.0f, y);
        rb.AddForce(movement * speed);

        Debug.Log("mve");


     }

    
}
