/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsMultiEffect : ActionPartsEffect
	{
		// Fields
		private readonly MultiEffectData _partsData;
		private List<EffectObject> effecObjects;
		private float _delayTime;
		private int _generateCnt;
		private Vector3 _originPos;
		private float _forwardRot;
	
		// Constructors
		public ActionPartsMultiEffect(ActionParts resource);
	
		// Methods
		protected override void OnFinish();
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private bool CreateEffect();
	}
}
