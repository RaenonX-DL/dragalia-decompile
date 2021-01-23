/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSlider : Slider
	{
		// Fields
		public UnityEvent onPointerUp;
		[CompilerGenerated]
		private bool _isOnDown_k__BackingField;
	
		// Properties
		public bool isOnDown { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public CommonSlider();
	
		// Methods
		protected override void Awake();
		public override void OnPointerUp(PointerEventData eventData);
		public override void OnPointerDown(PointerEventData eventData);
		public override void OnDrag(PointerEventData eventData);
	}
}
