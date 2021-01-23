/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortTotalCropDisplay : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text text;
		[SerializeField]
		private float moveDistanceY;
		[SerializeField]
		private float duration;
		private int _totalCropNum;
		private Vector3 initialLocalPos;
	
		// Properties
		public int totalCropNum { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public CircleOutline textOutLine;
			public FortTotalCropDisplay __4__this;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal Color _PlayPopupAnim_b__0();
			internal void _PlayPopupAnim_b__1(Color color);
			internal void _PlayPopupAnim_b__2();
			internal Color _PlayPopupAnim_b__3();
			internal void _PlayPopupAnim_b__4(Color color);
		}
	
		// Constructors
		public FortTotalCropDisplay();
	
		// Methods
		public void Reset();
		public void AddTotalCropNum(int num, long currentNum, bool isItem);
		public void DispFortStoredTotalCrop();
		public void DispFortTotalCrop(int additionalNum);
		public float GetPopupAnimTotalDuration();
		public void PlayPopupAnim();
	}
}
