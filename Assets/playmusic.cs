using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmusic : MonoBehaviour
{
    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public AudioClip audio;
    }
    public BgmType bgmItem;
    public BgmType bgmItem2;
    public GameObject textg;
    public GameObject textx;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    public GameObject smoke1;
    public GameObject smoke2;
    public GameObject smoke3;
    private AudioSource BGM;
    private bool isFirst = true;
    private bool isGoing = true;

    // Start is called before the first frame update
    void Start()
    {
        BGM = gameObject.AddComponent<AudioSource>();
        BGM = GetComponent<AudioSource>();
        BGM.clip = bgmItem.audio;
        BGM.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyUp("x") && isFirst)
        {
            isFirst = false;
            BGM.Play();
        }
        if (!isFirst && !BGM.isPlaying && isGoing)
        {
            textg.SetActive(true);
            if (Input.GetKeyUp("x"))
            {
                light1.SetActive(false);
                light2.SetActive(false);
                light3.SetActive(false);
                light4.SetActive(false);
                light5.SetActive(false);
                light6.SetActive(false);
                smoke1.SetActive(true);
                smoke2.SetActive(true);
                smoke3.SetActive(true);
                textg.SetActive(false);
                textx.SetActive(true);
                BGM.clip = bgmItem2.audio;
                BGM.loop = false;
                BGM.Play();
                isGoing = false;
            }
        }
        // Debug.Log(BGM.isPlaying);
    }
}
