/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AndroidStatusBarResume : MonoBehaviour
	{
		// Fields
		public bool isStatusBarOn;
		public bool isNavigationBarOn;
	
		// Constructors
		public AndroidStatusBarResume();
	
		// Methods
		public void InitOnBoot();
		private void OnApplicationPause(bool pause);
	}
}
