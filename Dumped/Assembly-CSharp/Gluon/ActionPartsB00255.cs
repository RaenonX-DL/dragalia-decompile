/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsB00255 : ActionParts
	{
		// Fields
		private readonly B00255Data _partsData;
		private const float BEAM_EXPAN_SEC = 0.15f;
		private const float HIT_EXCEPTION_SEC = 1f;
		private State _state;
		private StoneSatelliteUniqueCtrl _ctrl;
		private HitException _hitException;
		private List<OptionCtrl> _options;
		private float _elapsedSec;
		private float _beamExpanSec;
		private float _rollingSec;
		private EffectObject _ringEffect;
		private AudioPlayback _rollingSeHandle;
		private int _effTrig;
	
		// Nested types
		private enum State
		{
			idle = 0,
			expansion = 1,
			expansionBeam = 2,
			rolling = 3,
			convergence = 4
		}
	
		private class OptionCtrl
		{
			// Fields
			public CharacterBase chara;
			public ActionMove actMove;
			public EffectObject beamEffect;
			public EffectObject effectObject;
			public Vector3 dir;
			public CollisionHitAttribute hitAttribute;
	
			// Constructors
			public OptionCtrl();
	
			// Methods
			public Vector3 GetBeamBasePos(CharacterBase owner);
		}
	
		// Constructors
		public ActionPartsB00255(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override void OnFinish();
		public override void Clear();
		public override void RemoveSelf();
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		public override void OnCollided(GameObject target, bool isPropagation);
	}
}
