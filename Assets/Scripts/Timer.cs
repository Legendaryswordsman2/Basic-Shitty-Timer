using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
	[SerializeField] float timerLength = 10;
	[SerializeField, ReadOnlyInspector] float timeLeft;
	[SerializeField] TMP_Text timerText;
	[SerializeField] GameObject inputTimeField;

	bool timerGoing = false;

	private void Awake()
	{
		timeLeft = timerLength;
	}

	private void Update()
	{
		if (timerGoing)
		{
			int tempTime = (int)timeLeft;
			timerText.text = tempTime.ToString();
			timeLeft -= Time.deltaTime;

			if(timeLeft <= 0)
			{
				timeLeft = timerLength;
				StopTimer();
			}
		}
	}
	public void SetTimerLength(string time)
	{
		timerLength = Convert.ToInt32(time);
		timeLeft = timerLength;
	}
	public void OnText()
	{
		Debug.Log("TEXT");
	}
	public void StartTimer()
	{
		inputTimeField.SetActive(false);
		timerGoing = true;
	}
	public void StopTimer()
	{
		inputTimeField.SetActive(true);
		timerGoing = false;
	}
}
