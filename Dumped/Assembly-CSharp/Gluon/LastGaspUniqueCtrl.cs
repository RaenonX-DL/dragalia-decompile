/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.CharacterUniqueGimmick;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LastGaspUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private int _receivedFatalAttackCount;
		private int _actionId;
		private int _takedownActionId;
		private bool checkLastGaspOver;
		public bool isLastGaspOver;
		private bool holyLightEnemySet;
		private bool _isActionReserved;
		private bool _isTakedownActionReserved;
	
		// Properties
		public bool active { get; }
		private CtrlHolyLight holyLight { get; }
	
		// Constructors
		public LastGaspUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public override void FastUpdate();
		public void Setup(int actionId, int takedownActionId);
		public bool OnFatalAttacked(bool isQuestSkill, CharacterBase attacker);
		public void OnTakeDown();
		public override void OnChangeState(CharacterState state);
	}
}
