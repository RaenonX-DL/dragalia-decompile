/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlHealBlock : CUGCtrlBase
	{
		// Fields
		[CompilerGenerated]
		private State _state_k__BackingField;
		private string _effName;
		private const int EFF_TRIG = 8;
		private EffectObject _effectObject;
	
		// Properties
		public State state { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override bool active { get; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			Running = 1
		}
	
		// Constructors
		public CtrlHealBlock();
	
		// Methods
		public void Setup(CharacterSelector selector, string eff_name = "");
		public override void Abort();
		public void Start();
		public override void Update(CharacterBase src);
		public override void PlayEffect();
		public override void StopEffect();
		public void DeleteEffect();
	}
}
