/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ScaleControlUI : MonoBehaviour
	{
		// Fields
		private RectTransform rt;
		private Tweener tweener;
		private Action<ScaleControlUI> func;
		private Vector2 fromScale;
		private Vector2 toScale;
	
		// Constructors
		public ScaleControlUI();
	
		// Methods
		public void Initialize();
		public void Scale(Vector2 startScale, Vector2 endScale, Ease ease, float t, float delay, Action<ScaleControlUI> func = null);
		private void OnUpdateScale(float value);
		private void OnCompleteScale();
	}
}
