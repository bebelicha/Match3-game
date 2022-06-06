using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
     private TextMeshProUGUI timerUILabel; 
     private float t_offset = 120f; 
     private int t_minutes;
     private int t_seconds;
     private int t_milliseconds;
     private  GridManager scriptGridManager;
     private void Start()
     {
         scriptGridManager = GetComponent<GridManager>();
     }
     private void Update()
     {
         float t = Time.time - t_offset;
         
 
         t_minutes = ((int)t / 60); 
         t_seconds = ((int)t % 60);
         t_milliseconds = ((int)(t * 100)) % 100; 
         timerUILabel.text = string.Format("{0:00}:{1:00}:{2:00}", t_minutes, t_seconds, t_milliseconds);
         if (t_minutes == 0 && t_seconds == 0 && t_milliseconds == 0)
         {   
             scriptGridManager.GameOver();
            
             
         }
     }
}
