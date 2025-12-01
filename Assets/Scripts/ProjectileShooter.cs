using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject projectilePrefab;
    public Transform spawnPoint;
    private Vector3 direction;

    public void SetDirection (Vector3 newDirection)
    {
        direction = newDirection;
    }

    public void fire()
    {
        GameObject newProjectile = Instantiate(projectilePrefab) as GameObject;

        newProjectile.transform.position = spawnPoint.position;

        ProjectileController newProjectileController = newProjectile.GetComponent<ProjectileController>();

        if (newProjectileController != null)
        {
            newProjectileController.Setup(direction);
        }
        else
        {
            Debug.Log ("No Projectile");
        }
    }
}
