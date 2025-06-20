using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    public float speed = 5f;
    public GameObject coinPrefab;

    void Start()
    {
        float randVal = Random.Range(-10, 10);
        Instantiate(coinPrefab, new Vector3(randVal, 0, 0), Quaternion.identity); //Gebruik de Instantiate methode om de coinPrefab in de scene te zetten.
    }

    void Update()
    {
        // Beweging met pijltjestoetsen links en rechts of A en D
        float input = Input.GetAxis("Horizontal");
        // Vermenigvuldig de richting met de snelheid en de horizontale input waarde
        transform.Translate(Vector3.right * speed * input * Time.deltaTime);
    }
}
