using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    
    // 1. 宣告一個欄位用來存放 Audio Source 組件
    private AudioSource audioSource;

    void Start()
    {
        Application.targetFrameRate = 60;
        
        // 2. 在遊戲開始時，自動取得綁在同一個物件上的 Audio Source
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 100; // 賦予旋轉速度
            
            // 3. 當點擊滑鼠時，播放剛剛設定好的音效
            if (audioSource != null)
            {
                audioSource.Play(); 
            }
        }

        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.96f; 
    }
}

