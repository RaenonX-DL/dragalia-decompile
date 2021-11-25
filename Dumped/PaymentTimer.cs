using System;
using UnityEngine;

public class PaymentTimer : MonoBehaviour
{
	private float intervalTime;

	private float startTime;

	private bool isTimeout;

	private Action timeOutEvent;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static PaymentTimer StartCounting(float time, Action timeOutEvent)
	{
		return null;
	}

	public static void StopCounting(PaymentTimer timer)
	{
	}
}
