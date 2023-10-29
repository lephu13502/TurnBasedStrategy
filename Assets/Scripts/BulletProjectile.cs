using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Transform bulletHitVfxPrefab;

    private Vector3 targetPosition;

    public void SetUp(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
    private void Update()
    {
        float moveSpeed = 200f;
        Vector3 moveDir = (targetPosition - transform.position).normalized;
        float distanceBeforeMoving = Vector3.Distance(transform.position, targetPosition);
        transform.position += moveDir * Time.deltaTime * moveSpeed;
        float distanceAfterMoving = Vector3.Distance(transform.position, targetPosition);
        if (distanceAfterMoving > distanceBeforeMoving)
        {
            transform.position = targetPosition;
            trailRenderer.transform.parent = null;
            Destroy(gameObject);
            Instantiate(bulletHitVfxPrefab, targetPosition, Quaternion.identity);
        }
    }
}
