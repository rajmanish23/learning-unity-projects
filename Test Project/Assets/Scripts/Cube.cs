using UnityEngine;

public class Cube : MonoBehaviour {
    
    [SerializeField] private MeshRenderer objRenderer;
    
    [SerializeField] private Vector3 rotationAngle;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private bool rotateAtRandomAngle;
    
    [SerializeField] private float objScale;
    
    [SerializeField] private float objOpacity;
    [SerializeField] private float redValue;
    [SerializeField] private float greenValue;
    [SerializeField] private float blueValue;
    [SerializeField] private bool randomizeOpacity;
    [SerializeField] private bool randomizeColors;
    [SerializeField] private bool changeColorOvertime;
    [SerializeField] private float _hueAngle;
    private void Start() {
        transform.localScale = Vector3.one * objScale;
        if (rotateAtRandomAngle) {
            rotationAngle = new Vector3(
                Random.Range(-90,90),
                Random.Range(-90,90),
                Random.Range(-90,90)
            );
        }
        if (randomizeColors) {
            redValue = Random.value;
            greenValue = Random.value;
            blueValue = Random.value;
        }
        if (randomizeOpacity) objOpacity = Random.value;
    }
    
    private void Update() {
        var material = objRenderer.material;
        transform.Rotate(Time.deltaTime * rotationSpeed * rotationAngle);
        if (!changeColorOvertime) {
            material.color = new Color(redValue, greenValue, blueValue, objOpacity);
        } else {
            _hueAngle = Mathf.PingPong(Time.time * 0.1f, 1.0f);
            material.color = Color.HSVToRGB(_hueAngle, 1, 1);
        }
    }
}
