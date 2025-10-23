using UnityEngine;

[RequireComponent(typeof(Collider))]
public class HoopTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;
    public string ballTag = "Basketball";

    private void Reset()
    {
        var c = GetComponent<Collider>();
        if (c) c.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(ballTag) && scoreManager)
            scoreManager.AddScore(scoreManager.pointsPerGoal);
    }
}