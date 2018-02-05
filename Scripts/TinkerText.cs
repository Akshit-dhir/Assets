using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
    
public class TinkerText : MonoBehaviour {
   
   // public Text tinkerText;
    public Stanza stanza;
    // Auto play timing related
    private float startTime;
    private float endTime;
    private float delayTime;
    public GameObject text;
    public Animator wordanimator;
    public Animator iconanimator;
    public Animator graphicanimator;

    public GameObject anim;
    public GameObject anim2;
    public static int nooftaps;


    // Use this for initialization
    void Start () {
        //a = text.GetComponent<Animator>();
        
        //anim = gameObject.GetComponent<Animation>();
        
       // wordanimator = gameObject.GetComponent<TinkerText>().GetComponent<Animator>();
       Debug.Log(wordanimator + "    " + iconanimator);
    }

    // Update is called once per frame
    void Update () {
		
	}
    // Mouse Down Event
    public void OnMouseDown()
    {
        clipPlay();
    }

    public void OnMouseUp()
    {


        Debug.Log("on mouse up" + wordanimator.speed);
        wordanimator.SetTrigger("resume");
        iconanimator.SetTrigger("tapup");
        anim.SetActive(false);
    }
    public void clipPlay()
    {
        anim.SetActive(true);
        //anda visible initially
        if(anim2!=null)
        anim2.SetActive(true);


        Debug.Log("entered clip play");
        AudioSource source = gameObject.GetComponent<AudioSource>();
        delayTime = 0.21f;
        wordanimator.speed = 1 / (delayTime);
        source.Play();
        wordanimator.SetTrigger("tapme");
        iconanimator.SetTrigger("tap");


        if (graphicanimator!=null) { 
        if (nooftaps < 2)
        {
            int i = nooftaps + 1;
            graphicanimator.SetTrigger("crack" + i);
            nooftaps++;
        }
        else {
            graphicanimator.SetTrigger("crack3");
            SceneManager.LoadScene("Scene02");
        } }



        anim.SetActive(true);
    }

}
