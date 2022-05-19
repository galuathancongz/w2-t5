using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Transform SpinCirle;
     public float spin=1f;
    float speed=100f;
    public bool[] p = new bool[10] ;
    AudioSource m_audio;
    
    void DownTrend()
    {
        SpinCirle.eulerAngles = new Vector3(0, 0, -spin * 1f) * speed;
        speed--;
    }

    private void Awake()
        {
        
        SpinCirle.eulerAngles = new Vector3(0, 0, 0);
        m_audio = GetComponent<AudioSource>();
    }


    // Start is called before the first frame update
    void Start()
    {
     for(int i = 0; i < p.Length; i++)
        {
            p[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Quay tu nhien
        spin++;
        SpinCirle.eulerAngles = new Vector3(0, 0, -spin * 1f) * 100f;
        // 1 true 10 false
        //for (int i = 1; i < p.Length; i++) {
        //    if (p[i] == true)
        //    {
        //        for (int j = i + 1; j!=i; j++)
        //        {
        //            p[j] = false;
        //            if (j == p.Length - 1) { j = 1; }
        //        }
        //    }
        //}
        //ham dung
        if (Input.GetKeyDown("1")) { p[1] = true; }
        if (p[1] == true){
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 70 * 1f); m_audio.Pause();
                Debug.Log("1 gold");
            }
            
        }
        if (Input.GetKeyDown("2")) p[2] = true;
        if (p[2] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 109 * 1f); m_audio.Pause();
                Debug.Log("2 gold");
            }
        }
        if (Input.GetKeyDown("3")) p[3] = true;
        if (p[3] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 151 * 1f); m_audio.Pause();
                Debug.Log("3 gold");
            }
        }
        if (Input.GetKeyDown("4")) p[4] = true;
        if (p[4] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 195 * 1f); m_audio.Pause();
                Debug.Log("4 gold");
            }
        }
        if (Input.GetKeyDown("5")) p[5] = true;
        if (p[5] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 234 * 1f); m_audio.Pause();
                Debug.Log("5 gold");
            }
        }
        if (Input.GetKeyDown("6")) p[6] = true;
        if (p[6] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 270 * 1f); m_audio.Pause();
                Debug.Log("6 gold");
            }
        }
        if (Input.GetKeyDown("7")) p[7] = true;
        if (p[7] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 320 * 1f); m_audio.Pause();
                Debug.Log("7 gold");
            }
        }
        if (Input.GetKeyDown("8")) p[8] = true;
        if (p[8] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 351 * 1f); m_audio.Pause();
                Debug.Log("8 gold");
            }
        }
        if (Input.GetKeyDown("9")) p[9] = true;
        if (p[9] == true)
        {
            DownTrend();
            if (speed <= 0) { SpinCirle.eulerAngles = new Vector3(0, 0, 23 * 1f); m_audio.Pause(); Debug.Log("9 gold"); }
        }
        //Ham chay tiep
        //if (Input.GetKeyDown("0"))
        //{
        //    p[0] = true;
        //    for(int i = 1; i < p.Length; i++)
        //    {
        //        p[i] = false;
        //    }
        //}

   




    }
}
