/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsEffectStretch : ActionParts
	{
		// Fields
		private readonly EffectStretchData _partsData;
		private State _state;
		private EffectObject _effectObject;
		private float _elapsedSec;
		private float _stretchSec;
		private Vector3 _targetPos;
		private Transform startTransform;
		private Vector3 startPosForNullEffectObject;
	
		// Nested types
		private enum State
		{
			Init = 0,
			Update = 1
		}
	
		// Constructors
		public ActionPartsEffectStretch(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void CalcStartTransfrom(out Vector3 pos, out Vector3 scale);
		private Vector3 CalcTargetPos(Vector3 startPos);
	}
}
