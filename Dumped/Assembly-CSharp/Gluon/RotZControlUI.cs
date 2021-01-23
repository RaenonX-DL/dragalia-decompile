/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RotZControlUI : MonoBehaviour
	{
		// Fields
		private RectTransform rt;
		private Tweener tweener;
		private Action<RotZControlUI> func;
		private bool isLeft;
		private Quaternion leftQuaternion;
	
		// Constructors
		public RotZControlUI();
	
		// Methods
		public void Initialize();
		public void RotateZ(float startZ, float endZ, Ease ease, float t, float delay, Action<RotZControlUI> func = null, bool isLeft = false);
		private void OnUpdateRotate(float value);
		private void OnCompleteRotate();
	}
}
