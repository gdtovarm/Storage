using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StorageGameController : MonoBehaviour {

    // Use this for initialization
    public int id;
    public static Vector3 doorPosition;
    public Scene overworld;

	void Awake () {
        DontDestroyOnLoad(gameObject);
	}

    void Start()
    {
        SceneManager.LoadScene(1);
        SceneManager.sceneLoaded += sceneUnloaded;
        doorPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(1);
        }
	}

    void sceneUnloaded(Scene sc, LoadSceneMode lsm) {
        Debug.Log("scene loaded.");
        GameObject player = GameObject.FindWithTag("Player");
        if(sc.buildIndex == 1 )player.transform.position = doorPosition;
    }
}
