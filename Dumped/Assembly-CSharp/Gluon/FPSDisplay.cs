/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FPSDisplay : MonoBehaviour
	{
		// Fields
		public float updateInterval;
		private float accum;
		private int frames;
		private float timeleft;
		private UnityEngine.UI.Text _text;
		private StringBuilder _stringBuilder;
	
		// Constructors
		public FPSDisplay();
	
		// Methods
		private void Start();
		private void Update();
	}
}
