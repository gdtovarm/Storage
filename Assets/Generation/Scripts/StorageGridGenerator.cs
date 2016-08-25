using UnityEngine;
using System.Collections;

public class StorageGridGenerator : MonoBehaviour {

    public GameObject warehouse;
    public GameObject floorPrefab;
    // Use this for initialization
    void Start() {
        System.Random rng = new System.Random(Time.time.ToString().GetHashCode());
        int rows = rng.Next(5, 7);
        int cols = rng.Next(5, 7);

        float rowsMultiplier = 16.5f;
        float colsMultiplier = 32.0f;

        float colMaxSize = (cols + 1) * colsMultiplier;
        float rowMaxSize = (rows + 1) * rowsMultiplier;

        Iinteractable storageData = warehouse.GetComponentInChildren<Iinteractable>();
        TextMesh StorageTitleOutside = warehouse.GetComponentInChildren<TextMesh>(); 

        GameObject floor;
        floor = Instantiate(floorPrefab) as GameObject;
        floor.transform.localScale = new Vector3( colMaxSize, rowMaxSize, 1);
        floor.transform.position = new Vector3( (colMaxSize - 2*colsMultiplier)/2, 0, (rowMaxSize - 2*rowsMultiplier) / 2);
        int number = 0;
        
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                number = (i * cols) + j;
                storageData.title = "Storage " + number;

                GameObject wasuwasol = Instantiate(warehouse.transform, transform.position + new Vector3(i * colsMultiplier, 0, j * rowsMultiplier), transform.rotation) as GameObject;
                //Debug.Log(wasuwasol.gameObject);
            }
        }
    }
}
