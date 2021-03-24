/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleManaPieceObject : GrowthManaCircleDraggable, IPointerClickHandler
	{
		// Fields
		public GrowthManaCircleManaPieceData pieceData;
		public bool isReleased;
		public int circleIndex;
		public int index;
		private bool isFront;
		private const float doubleTouchThreshold = 0.25f;
	
		// Constructors
		public GrowthManaCircleManaPieceObject();
	
		// Methods
		private void Start();
		public void OnPointerClick(PointerEventData eventData);
		public EffectObject PlayReleaseGrowEffect();
		public EffectObject PlayReleaseGrowSimpleEffect(Vector3 offset);
		public EffectObject PlayReleaseLimitEffectFirst(Vector3 offset);
		public EffectObject PlayReleaseLimitEffectSecond(Vector3 targetPosition);
		public void SetIsFront(bool arg);
		public bool IsFront();
		protected override void NotifyDraggingToScene(bool arg);
	}
}
