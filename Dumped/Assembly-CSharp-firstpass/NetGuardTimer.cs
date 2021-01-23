/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class NetGuardTimer
{
	// Fields
	public const int TimeoutInMilliseconds = 3000;
	private Timer _timer;
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation Timeout;

	// Events
	public event SysPost.StdMulticastDelegation Timeout {
		add;
		remove;
	}

	// Constructors
	public NetGuardTimer();

	// Methods
	public void Activate();
	public void Deactivate();
	private void OnTimeout(object sender, ElapsedEventArgs e);
}

