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
                Vector3 position = transform.position + new Vector3(x * tileSize, y * tileSize);
                grid[x,y] = spawnGem(position, y + x * gridHeight);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    GameObject spawnGem(Vector3 position, int identifier) {
        GameObject go = Instantiate(gem, position, transform.rotation, transform);
        go.name = "Gem" + identifier.ToString();
        return go;
    }
}
