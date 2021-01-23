/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlObject : FlObjectBase
	{
		// Fields
		private FlObjectParameter _objParam;
		private FlMotion _childMotion;
		private bool _existChildMotion;
	
		// Properties
		public FlObjectParameter ObjectParameter { get; }
		public FlMotion ChildMotion { get; set; }
		public bool ExistChildMotion { get; }
	
		// Constructors
		public FlObject(GameObject gameObject);
	
		// Methods
		public override void _CreateEditorData(FlObjectParameterBase parameter, FlMotion parentMotion);
		public override void _ApplyData(FlObjectParameterBase parameter, FlMotion parentMotion);
		public override void _CreateData();
		public override void _FixData();
		public override void _Update();
		public override void _UpdateForce();
		protected override void _UpdateColor();
		protected override void _UpdateTransform();
		public override void _UpdateStencilRef(bool children);
		protected override void _SetGrayscaleBase(bool enable);
		public override void _ResetTime();
		public override void SetSortOffset(int sortOffset);
		public override void SetSortLayer(string sortLayerName);
		public override void SetTimeModeType(FlTimeModeTypes timeModeType, bool affectChildren);
		public override void SetMotionSpeed(float speed, bool affectChildren);
		public override void SetColliderThrough(bool through, bool affectChildren);
		public override void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren);
		public override void _UpdateColliderThickness(bool affectChildren);
		public override void SetEnableCollider(bool enable, bool affectChildren);
		public override void SetSubCollider(Collider subCollider, bool affectChildren);
		public override void SetBlurQuality(int blurQuality, int blurPrecision, bool affectChildren);
		public override void SetBlurValue(Vector2 blurValue, bool affectChildren);
	}
}
