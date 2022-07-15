using UnityEngine;

public class CubeSpawner : MonoBehaviour {
    
    [SerializeField] private GameObject objToSpawn;
    [SerializeField] private int spawnLimit;
    
    private int _spawnSize;
    private float _x, _y, _z;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && _spawnSize < spawnLimit) {
            _spawnSize += 1;
            _x = Random.Range(10, -40);
            _y = Random.Range(10, -10);
            _z = Random.Range(25, -25);
            Instantiate(objToSpawn, new Vector3(_x,_y,_z), objToSpawn.transform.rotation);
        }
    }
}
