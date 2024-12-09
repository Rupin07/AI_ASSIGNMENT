using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    private Vector3 direction;
    private float speed = 0.8f;

    void Start()
    {
        direction = goal.transform.position - this.transform.position;
      
        // this.transform.Translate(direction);
    }

    private void LateUpdate()
    {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude > 1)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position += velocity;
        }
    }
}