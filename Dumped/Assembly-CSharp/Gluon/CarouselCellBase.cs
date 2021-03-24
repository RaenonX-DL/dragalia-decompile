/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CarouselCellBase : MonoBehaviour
	{
		// Fields
		private float baseRot;
		private float wheelRot;
		private float wheelWidth;
		private RectTransform rectTransForm;
		private int index;
		[SerializeField]
		protected List<GameObject> cells;
		protected float elementsScale;
		[SerializeField]
		private Image[] centerFrame;
	
		// Nested types
		public enum WheelChapterSize
		{
			Front = 0,
			Middle = 1,
			Back = 2,
			Max = 3
		}
	
		// Constructors
		public CarouselCellBase();
	
		// Methods
		public virtual void Initialize<T>(int index, T data, float carouselWidth);
		public void SetBaseRot(float rot);
		public float GetBaseRot();
		public float GetWheelRot();
		public RectTransform GetRectTransForm();
		public int GetIndex();
		public void SetScale(float scale);
		public Vector3 SetWheelRot(float rot);
		public void SetSize(WheelChapterSize size);
	}
}
