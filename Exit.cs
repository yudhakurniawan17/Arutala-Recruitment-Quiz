﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{

	public void exit()
	{
		Debug.Log("Telah keluar dari aplikasi");
		Application.Quit();
	}
}
