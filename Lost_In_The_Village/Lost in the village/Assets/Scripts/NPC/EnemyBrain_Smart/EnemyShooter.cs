using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{

    [Header("General")]
    public Transform shootPoint; //Where the raycast starts from
    public Transform gunPoint; //Where the visual trial starts from
    public LayerMask layerMask;

    [Header("Gun")]
    public Vector3 spread = new Vector3(0.06f, 0.06f, 0.06f);
    public TrailRenderer bulletTrail;
    public int ammo = 30;
    private EnemyReferences enemyReferences;
    private int currentAmmo;




    private void Awake()
    {
        enemyReferences = GetComponent<EnemyReferences>();
    }


    public void Shoot()
    {
        if (ShouldReload()) return;

        Vector3 direction = GetDirection();
        if(Physics.Raycast(shootPoint.position,direction,out RaycastHit hit, float.MaxValue,layerMask))
        {
            Debug.DrawLine(shootPoint.position, shootPoint.position + direction * 10f, Color.red, 1f);

            TrailRenderer trial = Instantiate(bulletTrail, gunPoint.position, Quaternion.identity);
            StartCoroutine(SpawnTrial(trial, hit));

            currentAmmo -= 1;
        }
    }


    private Vector3 GetDirection()
    {
        Vector3 direction = transform.forward;

        direction += new Vector3(
            Random.Range(-spread.x,spread.x),
            Random.Range(-spread.y, spread.y),
            Random.Range(-spread.z, spread.z)
            );

        direction.Normalize();
        return direction;
    }


    private IEnumerator SpawnTrial(TrailRenderer trial, RaycastHit hit)
    {

        float time = 0f;

        Vector3 startPosition = trial.transform.position;

        while (time < 1f)
        {
            trial.transform.position = Vector3.Lerp(startPosition, hit.point, time);
            time += Time.deltaTime / trial.time;

            yield return null;
        }

        trial.transform.position = hit.point;

        Destroy(trial.gameObject, trial.time);
    }

    public bool ShouldReload()
    {
        return currentAmmo <= 0;
    }

    public void Reload() {
        currentAmmo = ammo;
    }
    
}