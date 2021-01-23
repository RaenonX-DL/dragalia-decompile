/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UICommonAutoPartAnimation : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Type type;
		public bool executeOnAwake;
	
		// Nested types
		public enum Type
		{
			None = 0,
			NewIcon = 1
		}
	
		// Constructors
		public UICommonAutoPartAnimation();
	
		// Methods
		public void Awake();
		public void DoAnimation();
		public void DoNewIconFlashingAnimation();
	}
}
