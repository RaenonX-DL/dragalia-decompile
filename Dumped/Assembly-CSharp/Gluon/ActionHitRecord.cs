/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionHitRecord
	{
		// Fields
		private bool _isHitTargetRecording;
		private int _targetActionId;
		private List<CharacterBase> _actionHitOrGuardedTargetRecordList;
		private List<CharacterBase> _actionHitTargetRecordList;
		private int _hitOrGuardedTargetHitCounter;
	
		// Constructors
		public ActionHitRecord();
	
		// Methods
		public void BeginRecordTarget(int actionId);
		public void EndRecordTarget();
		public void Clear();
		public bool IsContainsInTargetRecord(CharacterBase target, CollisionHitAttribute hitAttr);
		public void OnGuarded(CharacterBase target, CollisionHitAttribute hitAttr);
		public void OnHit(CharacterBase target, CollisionHitAttribute hitAttr);
		public static bool IsRecordTargetGroup(ActionTargetGroup targetGroup);
		public int GetHitOrGuardedTargetNum();
		public int GetHitOrGuardedHitCounterNum();
		public void AddHitOrGuardedTargetNumCounter(int addCount, CollisionHitAttribute httr);
	}
}
