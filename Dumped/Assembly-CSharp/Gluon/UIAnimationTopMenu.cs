/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UIAnimationTopMenu : UIAnimationBase
	{
		// Fields
		protected Vector3 startRotation;
		protected Vector3 vanishingPointInCanvas;
		protected float exitVanishingT;
		protected float enterScale;
		protected float enterOffsetScale;
		protected float exitScale;
		protected float enterShakePostOverrunExtension;
		protected Vector3 enterShakeRotationStart;
	
		// Properties
		protected float enterVanishingT { get; }
	
		// Constructors
		public UIAnimationTopMenu();
	
		// Methods
		protected override void Awake();
		public override void RecordCurrentStateAsDefault();
		public override void ResetUIAnimations();
		public Vector3 GetWorldVanishingPoint();
		public Vector3 GetWorldRectTransformCenter();
		public Vector3 GetWorldEnterPosition(Vector3 worldVanishingPoint, Vector3 centerStartWorldPos);
		public Vector3 GetWorldExitPosition(Vector3 worldVanishingPoint, Vector3 centerStartWorldPos);
		private void ReCalculateVanishingPoint();
		protected override void OnReadyToCalculatePosition();
		protected override void JoinEnterAnimation();
		protected override void JoinExitCanvasGroupAnimation();
		protected override float AppendExtraToEnterAnimation();
	}
}
