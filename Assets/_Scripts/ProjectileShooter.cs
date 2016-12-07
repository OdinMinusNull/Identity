using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {

    public GameObject projectile;
    public float projectileSpeed;

    private bool time = false;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Buffer());
	
	}
	
	// Update is called once per frame
	void Update () {

        if (time == false)
        {
            FireProjectile();
            Buffer();
        }
    }

    public void FireProjectile ()
    {
        GameObject Clone;

        Clone = (Instantiate(projectile, transform.position, transform.rotation)) as GameObject;
        Clone.AddComponent<PolygonCollider2D>();
        rb = Clone.AddComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * projectileSpeed);

        time = true;
    }

    IEnumerator Buffer()
    {
        yield return new WaitForSecondsRealtime(2);
        time = false;
    }
}
