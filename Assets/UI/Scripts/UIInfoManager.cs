using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIInfoManager : MonoBehaviour {

    private bool isHidden;
    private List<Iinteractable> elements;
    private Iinteractable current;

    public Text title;
    public Text tooltip;
    public Image panel;
    public Image icon;

	// Use this for initialization
	void Start () {
        elements = new List<Iinteractable>();
        isHidden = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void addInteractable(Iinteractable interactable)
    {
        setInfo(interactable.title, interactable.tooltip, interactable.image);
        current = interactable;
        if (!elements.Contains(current))
            elements.Add(current);
    }

    public void removeInteractable(Iinteractable interactable)
    {
        elements.Remove(interactable);
        if (current == interactable)
        {
            current = null;
        }
        if (elements.Count == 0)
        {
            hideInfo();
        }
    }

    void hideInfo()
    {
        title.enabled = false;
        tooltip.enabled = false;
        panel.enabled = false;
        icon.enabled = false;
        isHidden = true;
    }

    void showInfo()
    {
        title.enabled = true;
        tooltip.enabled = true;
        panel.enabled = true;
        icon.enabled = true;
        isHidden = false;
    }

    void setInfo(string _title, string _tooltip, Sprite _icon)
    {
        title.text = _title;
        tooltip.text = _tooltip;
        icon.sprite = _icon;

        if (isHidden) showInfo();
    }

}
