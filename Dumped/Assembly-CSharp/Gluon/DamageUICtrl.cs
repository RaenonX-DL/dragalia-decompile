/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DamageUICtrl
	{
		// Fields
		private DamageNumUI[] _damageNumUIArray;
		private int _damageNumUIIndex;
		private DamageFigUI[] _damageFigUIArray;
		private int _damageFigUIIndex;
		private bool[] _totalDamageUsedIndexArray;
		private Dictionary<CharacterBase, TotalDamageData> _totalDamageDataDic;
		private const int ReserveNum = 20;
	
		// Nested types
		private class TotalDamageData
		{
			// Fields
			private Dictionary<int, Dictionary<int, ActionData>> _skillDataList;
	
			// Nested types
			private class ActionData
			{
				// Fields
				[CompilerGenerated]
				private int _productId_k__BackingField;
				[CompilerGenerated]
				private int _damage_k__BackingField;
	
				// Properties
				public int productId { [CompilerGenerated] get; [CompilerGenerated] private set; }
				public int damage { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
				// Constructors
				private ActionData();
				public ActionData(int productId, int damage, bool isHitCountDamage);
	
				// Methods
				public void Reset();
				public bool AddDamage(int productId, int damage, bool isHitCountDamage);
			}
	
			// Constructors
			private TotalDamageData();
			public TotalDamageData(int skillId, int actionId, int productId, int damage, bool isHitCountDamage);
	
			// Methods
			public void Reset(int skillId);
			public void Reset();
			public void AddDamage(int skillId, int actionId, int productId, int damage, bool isHitCountDamage);
			public int GetDamage(int skillId);
			public bool CheckAliveBullet(CharacterBase chara, int skillId);
		}
	
		// Constructors
		public DamageUICtrl();
	
		// Methods
		public void Initialize(GameObject parent, InGameUICtrl inGameUI);
		public void ShowDamageUI(CharacterBase character, int value, Vector3 position, bool isCritical, bool isDragon, DamageNumUI.DamageType damageType, DamageNumUI.Target target, bool isRaid, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int uniqueBuffIcon, bool isHitCount);
		public void ShowNoDamageUI(Vector3 position, DamageFigUI.NoDamageType noDamageType, Color color);
		public void ShowRecoverHP(int value, Vector3 position);
		public void ShowRecoverSP(int value, Vector3 position);
		public void StopAllDamageUI();
		public void ShowTotalDamage(CharacterBase character, int skillId);
		public void AddTotalDamage(CharacterBase character, int actionId, int skillId, int actionProductId, int damage, bool isHitCountDamage);
		public void ResetTotalDamage(CharacterBase character, int skillId);
		public void ResetTotalDamageData();
	}
}
