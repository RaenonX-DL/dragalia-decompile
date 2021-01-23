/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsSabnackFlameArm : ActionParts
	{
		// Fields
		private float _time;
		private EnemyCharacter _parts;
		private readonly SabnackFlameArmData _partsData;
	
		// Nested types
		public enum FlameType
		{
			Disappear = 0,
			ChangeColor = 1
		}
	
		public enum PartsType
		{
			Left = 0,
			Right = 1,
			Head = 2
		}
	
		// Constructors
		public ActionPartsSabnackFlameArm(ActionParts resource);
	
		// Methods
		protected override void OnFinish();
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void ControlFlame(float ratio);
	}
}
