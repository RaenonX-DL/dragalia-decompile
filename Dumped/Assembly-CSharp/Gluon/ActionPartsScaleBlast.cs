/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsScaleBlast : ActionParts
	{
		// Fields
		private readonly ScaleBlastData _partsData;
		private State _state;
		private EnemyCharacter _enemy;
		private float _idleTime;
		private float _waiting;
		private int _blastActionId;
		private bool _isPlayDone;
	
		// Nested types
		public enum ChildType
		{
			Black = 0,
			White = 1,
			Both = 2
		}
	
		public enum ChildParam
		{
			Child01Param = 0,
			Child02Param = 1,
			Child03Param = 2
		}
	
		private enum State
		{
			Init = 0,
			Idle = 1,
			Play = 2,
			Wait = 3,
			Attack = 4,
			Fail = 5
		}
	
		// Constructors
		public ActionPartsScaleBlast(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		protected override void OnFinish();
		public override void Clear();
		protected override bool OnUpdate(float delta);
		private bool Play();
		private int GetChildParamId(ChildParam param);
		private void PlayAction(int actionId);
	}
}
