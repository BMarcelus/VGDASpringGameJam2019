﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class screenchanger : MonoBehaviour
{
    public void screenchange()
    {
        SceneManager.LoadScene("ScreenSwitchTest");

    }
}
    