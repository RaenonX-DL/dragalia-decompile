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
	public class InGameFollowLayout : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public float height;
		[HideInInspector]
		public int priority;
		[HideInInspector]
		public bool valid;
		[HideInInspector]
		public Action attachFunc;
		[HideInInspector]
		public Action<InGameFollowLayout, bool> validFunc;
		private RectTransform rt;
		private Vector2 pos;
		private bool initialized;
	
		// Constructors
		public InGameFollowLayout();
	
		// Methods
		public void Initialize();
		public void OnAttached();
		public void Valid(bool v);
		public void SetOffset(float y);
	}
}
