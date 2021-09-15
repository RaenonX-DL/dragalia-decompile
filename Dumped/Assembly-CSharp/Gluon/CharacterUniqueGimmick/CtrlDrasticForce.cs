/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlDrasticForce : CUGCtrlBase
	{
		// Fields
		public const int STACK_MAX = 30;
		[CompilerGenerated]
		private List<float> _dmgRate_k__BackingField;
		[CompilerGenerated]
		private int _stackNum_k__BackingField;
		private float _duration;
		private float _timer;
		public const CharaCircleGaugeUI.Type CIRCLE_GAUGE_TYPE = CharaCircleGaugeUI.Type.DrasticForce;
	
		// Properties
		public List<float> dmgRate { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int stackNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override bool active { get; }
		public bool isReady { get; }
		private Transform transform { get; }
	
		// Constructors
		public CtrlDrasticForce();
	
		// Methods
		public void Setup(CharacterSelector selector, float duration, int[] arrayForceRate, int stackSize);
		private void Reset();
		public override void ResetState();
		public override void Update(CharacterBase src);
		public override void OnDead();
		public void AddStack(int value, bool resetTime = false);
		public float GetDamageRate();
	}
}
