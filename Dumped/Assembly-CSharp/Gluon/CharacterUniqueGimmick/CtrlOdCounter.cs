/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlOdCounter : CUGCtrlBase
	{
		// Fields
		private List<CounteredData> _counteredList;
		private List<ActionInfo> _actionsInSkill;
	
		// Properties
		public override bool active { get; }
	
		// Nested types
		public enum Type
		{
			None = 0,
			HitDamage = 1,
			TotalScore = 2
		}
	
		public struct CounteredData
		{
			// Fields
			public int type;
			public int bonus;
			public EnemyCharacter target;
			public int hitCount;
		}
	
		public struct ActionInfo
		{
			// Fields
			public int actionId;
			public int productId;
		}
	
		// Constructors
		public CtrlOdCounter();
	
		// Methods
		public void Setup(CharacterBase owner);
		public void Reset();
		public void AddActionInSkill(int actionId_, int productId_);
		public bool Contain(EnemyCharacter target_);
		public void Register(EnemyCharacter enemy, CollisionHitAttribute attr);
		public bool CalcDamage(EnemyCharacter enemy, int damage, CollisionHitAttribute hitAttr, ref int od_dmg);
		private void SendOverDriveCounter(CharacterBase target);
		public static void OnRecieveOverDriveCounter(OverDriveCounter recvEvent);
	}
}
