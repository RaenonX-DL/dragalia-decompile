/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DropCoinGlitter : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private GlitterData[] glitterData;
		private RectTransform rectTransform;
		private Tweener tweener;
		private bool isActive;
	
		// Nested types
		[Serializable]
		public class GlitterData
		{
			// Fields
			public Image image;
			public RectTransform rectTrans;
			private float originPos;
			private float targetPos;
			private float originRot;
			private float targetRot;
			private float originScale;
			private float targetScale;
			private const float movePosY = 32f;
			private Vector3 _vec;
	
			// Constructors
			public GlitterData();
	
			// Methods
			public void Initalize();
			public void SetParam();
			public void OnUpdate(float v);
		}
	
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
		public DropCoinGlitter();
	
		// Methods
		private void Visible(bool b, bool force = false);
		public static DropCoinGlitter Create(GameObject parent, GameObject prefab);
		private void Initialize();
		public void UpdateParam();
		public void Release();
		public bool IsVisible();
		public void Display(Parameter param);
		public void Stop();
		private void OnUpdateAnim(float v);
		private void OnCompleteAnim();
	}
}
