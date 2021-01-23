/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsSound : ActionParts
	{
		// Fields
		private readonly SoundData _partsData;
		private AudioPlayback playback;
		private Transform _emitterTransform;
		private GameObject goEmitter;
		private bool _isOffset;
	
		// Constructors
		public ActionPartsSound(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnFinish();
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		public void ForceStop();
		private Vector3 CalcGeneratePos();
	}
}
