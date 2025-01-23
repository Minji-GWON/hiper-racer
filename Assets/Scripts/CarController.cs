using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CarController : MonoBehaviour
{
    [FormerlySerializedAs("_gas")] [SerializeField] private int gas = 100;
    [SerializeField] private float moveSpeed = 1f;
    
    public int Gas { get => gas; }  //Gas 정보

    void Start()
    {
        StartCoroutine(GasCoroutine());
    }

    IEnumerator GasCoroutine()
    {
        while (true)
        {
            gas -= 10;
            if (gas <= 0) break;
            yield return new WaitForSeconds(1f);
        }
        //Todo: 게임 종료 -> Todo는 나중에 몰아 볼 수 있음
    }
    
    /// <summary>
    /// 자동차 이동 메서드
    /// </summary>
    /// <param name="direction"></param>
    public void Move(float direction)
    {
        transform.Translate(Vector3.right * (direction * moveSpeed * Time.deltaTime));
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-2.0f, 2.0f), 0, transform.position.z);
    }

    /// <summary>
    /// 가스 아이템 획득시 호출되는 메서드
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gas"))
        {
            gas += 30;
            
            // Todo: 가스아이템 제거
        }
    }
}
