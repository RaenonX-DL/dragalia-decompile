﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	public class MobileInput : VirtualInput
	{
		// Constructors
		public MobileInput();
	
		// Methods
		private void AddButton(string name);
		private void AddAxes(string name);
		public override float GetAxis(string name, bool raw);
		public override void SetButtonDown(string name);
		public override void SetButtonUp(string name);
		public override void SetAxisPositive(string name);
		public override void SetAxisNegative(string name);
		public override void SetAxisZero(string name);
		public override void SetAxis(string name, float value);
		public override bool GetButtonDown(string name);
		public override bool GetButtonUp(string name);
		public override bool GetButton(string name);
		public override Vector3 MousePosition();
	}
}
