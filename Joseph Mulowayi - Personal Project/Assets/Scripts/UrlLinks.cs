﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UrlLinks : MonoBehaviour
{
    public string url = "https://github.com/JosephMwayi00/B00130551_JosephMulowayi_Final-Project";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadUrl()
    {
        Application.OpenURL(url);
    }
}
