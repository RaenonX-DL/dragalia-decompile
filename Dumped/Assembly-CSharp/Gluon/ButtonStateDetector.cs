/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ButtonStateDetector : MonoBehaviour
	{
		// Fields
		public bool needSetColorWhenDisiable;
		public bool isAlphaA8;
		public bool isSetEnableColorWithChildren;
		public bool isPreIn;
		private Button button;
		private bool isDisabled;
		private bool isInitialSet;
		public List<GameObject> ignoreSetColorChildren;
		public GameObject[] disableStateObject;
	
		// Constructors
		public ButtonStateDetector();
	
		// Methods
		private void Awake();
		public void OnNormalStateChanged();
		public void OnDisableStateChanged();
		public void SetState(bool toDisable, bool force);
	}
}
