/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonScrollRect : ScrollRect
	{
		// Fields
		public bool resetPositionOnResume;
		[Header]
		[SerializeField]
		public bool isShowTapEffect;
		private bool isNativeDraggin;
		private float lastValue;
		private bool isForceCancelScroll;
	
		// Constructors
		public CommonScrollRect();
	
		// Methods
		protected override void Start();
		protected override void LateUpdate();
		public override void OnBeginDrag(PointerEventData eventData);
		public override void OnEndDrag(PointerEventData eventData);
		public override void OnDrag(PointerEventData eventData);
		private void OnApplicationPause(bool pause);
		public void StopScroll();
		public void RestartScroll();
	}
}
