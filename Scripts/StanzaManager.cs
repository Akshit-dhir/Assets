using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StanzaManager : MonoBehaviour {

    public SManager sceneManager;
    public List<Stanza> stanzas;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tinkerText"></param>
    public void OnMouseDown(TinkerText tinkerText) {
        Debug.Log("stanzamanager"+tinkerText.name);
        if (tinkerText.stanza != null && stanzas.Contains(tinkerText.stanza))
        {
            tinkerText.stanza.OnMouseDown(tinkerText);
        }


    }

    public void OnMouseUp(TinkerText tinkerText)
    {
        if (tinkerText.stanza != null && stanzas.Contains(tinkerText.stanza))
        {
            tinkerText.stanza.OnMouseUp(tinkerText);
        }


    }
}
