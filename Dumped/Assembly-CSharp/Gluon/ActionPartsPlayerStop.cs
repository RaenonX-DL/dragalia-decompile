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
	public class ActionPartsPlayerStop : ActionParts
	{
		// Fields
		private readonly PlayerStopData _partsData;
		[CompilerGenerated]
		private float _timeCount_k__BackingField;
		private bool _isDone;
	
		// Properties
		public float timeCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum SwitchingType
		{
			OFF = 0,
			ON = 1
		}
	
		public enum StopTypes
		{
			TimeStop = 0,
			ForCutIn = 1,
			ForCutIn2 = 2
		}
	
		// Constructors
		public ActionPartsPlayerStop(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnFinish();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void Procedure(bool isSwitch);
	}
}
