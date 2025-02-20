using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt(int damage) {
        health -= damage;
        Debug.Log($"Health: {health}");
    }
}
