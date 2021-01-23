/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class PaymentTimer : MonoBehaviour
{
	// Fields
	private float intervalTime;
	private float startTime;
	private bool isTimeout;
	private Action timeOutEvent;

	// Constructors
	public PaymentTimer();

	// Methods
	private void Start();
	private void Update();
	public static PaymentTimer StartCounting(float time, Action timeOutEvent);
	public static void StopCounting(PaymentTimer timer);
}

