using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour {

    Iinteractable nearbyInteractable = null;

    public Collider current;
    public UIInfoManager infoUI;
    public Canvas canvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (nearbyInteractable != null && Input.GetKeyDown(KeyCode.E))
        {
            nearbyInteractable.doAction();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Iinteractable>() != null)
        {
            nearbyInteractable = other.gameObject.GetComponent<Iinteractable>();
            infoUI.addInteractable(nearbyInteractable);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Iinteractable>() != null && other.gameObject.GetComponent<Iinteractable>() == nearbyInteractable)
        {
            infoUI.removeInteractable(nearbyInteractable);
            nearbyInteractable = null;
        }
    }
}
