/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRCharaCtrl
	{
		// Fields
		private PlayerCharacter owner;
		private int brUnitId;
		private int weaponGlowItemNum;
		private int maxWeaponLevel;
		public bool isBot;
		[CompilerGenerated]
		private int _killCount_k__BackingField;
		private bool needsRecoveryDp;
	
		// Properties
		public int killCount { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public BRCharaCtrl(PlayerCharacter owner);
	
		// Methods
		public void Update();
		public void AddWeaponGlowItem(int value);
		private void SetWeaponGlowItem(int value, bool needSync);
		public void OnReceiveWeaponGlow(CharacterSpecialState recvData);
		public int GetWeaponLevel();
		public bool IsWeaponLevelMax();
		public int GetWeaponGlowItemNum();
		public int GetWeaponGlowItemNextNum(int level);
		public float GetAttackRatio();
		public BattleRoyalUnitElement GetBRUnitElem();
		public static string GetPlayerName(CharacterBase chara);
		public void SendLevelUp(int level);
	}
}
