using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    public TextMeshProUGUI scoreText;
    public GameObject cubePrefab;
    private int count = 0;

    public void ProduceCube() {
        count++;
        scoreText.text = "Cubes : " + count;

        // Animation simple : fait grossir le texte un court instant
        scoreText.transform.localScale = Vector3.one * 1.5f; 

        // Apparition d'un cube physique
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newCube.transform.position = new Vector3(Random.Range(-2, 2), 10, Random.Range(-2, 2));
        newCube.AddComponent<Rigidbody>(); // Il tombe physiquement
    }

    void Update() {
        // Retour à la taille normale (animation fluide)
        scoreText.transform.localScale = Vector3.Lerp(scoreText.transform.localScale, Vector3.one, Time.deltaTime * 5f);
    }
}