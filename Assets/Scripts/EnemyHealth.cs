using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : Health
{
    protected override void Die()
    {
        // Tạo hiệu ứng nổ sử dụng biến explosionPrefab từ lớp cha Health
        if (explosionPrefab != null) {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        base.Die(); 
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}