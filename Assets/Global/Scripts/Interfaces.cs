using UnityEngine;
using System.Collections;

public interface Iinteractable
{
    Sprite image { get; set; }
    string title { get; set; }
    string tooltip { get; set; }

    void doAction();
}
