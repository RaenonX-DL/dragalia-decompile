/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampCellIngame : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image stampImage;
		[SerializeField]
		private PointerEventHandler peh;
		private UnityAction<int> onIconPressed;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public StampCellIngame __4__this;
			public int stampId;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public StampCellIngame();
	
		// Methods
		public void Initialize(int stampId, UnityAction<int> action);
		public void OnIconPressed(int stampId);
	}
}
