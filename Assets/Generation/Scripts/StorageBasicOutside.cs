using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class StorageBasicOutside : MonoBehaviour, Iinteractable {

    public Sprite _image;
    public string _title;
    public string _tooltip;
    private Vector3 playerPos;

    public Sprite image
    {
        get { return _image; }
        set { _image = value; }
    }

    public string title
    {
        get { return _title; }
        set {
            _title = value;
            transform.parent.gameObject.GetComponentInChildren<TextMesh>().text = value;
        }
    }

    public string tooltip
    {
        get { return _tooltip; }
        set { _tooltip = value; }
    }

    public void doAction()
    {
        StorageGameController.doorPosition = playerPos;
        SceneManager.LoadSceneAsync( "WarehouseInside" );
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        playerPos = other.transform.position;
    }
}
