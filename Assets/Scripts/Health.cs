using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3; // Gán mặc định là 3 cho giống mẫu
    private int healthPoint;

    private void Start() => healthPoint = defaultHealthPoint;

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    // Thêm từ khóa 'virtual' ở đây
    protected virtual void Die() 
    {
        // Logic chết mặc định (nếu có)
    }
}