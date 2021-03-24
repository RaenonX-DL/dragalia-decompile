/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemGlitter : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Image imageGlitter;
		private RectTransform rectTransform;
		private Tweener tweener;
		private bool isActive;
	
		// Nested types
		public class Parameter
		{
			// Fields
			public Vector3 position;
			public float scale;
			public float time;
	
			// Constructors
			public Parameter();
	
			// Methods
			public void SetValue(Vector3 p, float s, float t);
		}
	
		// Constructors
		public ItemGlitter();
	
		// Methods
		private void Visible(bool b, bool force = false);
		public static ItemGlitter Create(GameObject parent, GameObject prefab);
		private void Initialize();
		public void Release();
		public bool IsVisible();
		public void Display(Parameter param);
		public void DisplayLocal(Parameter param);
		public void Stop();
		private void OnUpdateAnim(float v);
		private void OnCompleteAnim();
	}
}
