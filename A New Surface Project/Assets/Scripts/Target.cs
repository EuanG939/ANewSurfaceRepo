using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        ScoreKill scoreKillScript = gameObject.GetComponent<ScoreKill>();
        if (scoreKillScript != null)
        {
            Score playerScore = FindObjectOfType<Score>();

            playerScore.AddScore(scoreKillScript.killValue);
        }
        
        Destroy(gameObject);
    }
}
