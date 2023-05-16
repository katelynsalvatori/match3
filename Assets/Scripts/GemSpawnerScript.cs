using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawnerScript : MonoBehaviour
{
    public GameObject gem;
    public int gridHeight = 9;
    public int gridWidth = 9;

    public float tileSize = 0.8f;

    private GameObject[,] grid;
    
    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[gridWidth, gridHeight];

        for (int x = 0; x < gridWidth; x++) {
            for (int y = 0; y < gridHeight; y++) {
                Vector3 position = new Vector3(transform.position.x + x * tileSize, transform.position.y + y * tileSize);
                grid[x,y] = spawnGem(position, y + x * gridHeight);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if (GameObject.FindGameObjectsWithTag("Gem").Length < gridHeight * gridWidth) {
        //     GameObject go = spawnGem(transform.position);
        // }
    }

    GameObject spawnGem(Vector3 position, int identifier) {
        GameObject go = Instantiate(gem, position, transform.rotation);
        go.name = "Gem" + identifier.ToString();
        return go;
    }
}
