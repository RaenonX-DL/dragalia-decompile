/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailAbilityScrollRect : DragEventScrollRect
	{
		// Fields
		public DragEventScrollRect pageScrollRect;
		public const int dragThreshold = 15;
		private bool isHorizonalDrag;
	
		// Constructors
		public UnitDetailAbilityScrollRect();
	
		// Methods
		protected override void Start();
		public override void OnBeginDrag(PointerEventData eventData);
		public override void OnDrag(PointerEventData eventData);
		public override void OnEndDrag(PointerEventData eventData);
	}
}
