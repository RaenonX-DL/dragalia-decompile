/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterSkillData
	{
		// Fields
		public const int maxTrans = 3;
		public const int maxChainData = 3;
		public const int maxEnhance = 3;
		public SkillDataElement elem;
		public SkillChainDataElement[] chainData;
		public int srcShareCharaId;
		public int srcShareCharaSkillIndex;
		public int dstBaseId;
		public int originSkillId;
		public int[] enhancedSkillId;
		[CompilerGenerated]
		private int _lastModeChangeSkillId_k__BackingField;
		public int level;
		public bool enableTrans;
		public bool pauseBuff;
		public bool isRunningTransAction;
		public List<PlayerActionElement> skillActions;
		private List<int> transTriggers;
		public EditSkillCharaOffsetElement shareSkillCoefData;
	
		// Properties
		public int lastModeChangeSkillId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum TransCondition
		{
			None = 0,
			HitDamageCollision = 1,
			Cerese = 2
		}
	
		private enum SkillChainCondition
		{
			None = 0,
			EnemyBuffed = 1,
			EnemyBreaking = 2
		}
	
		// Constructors
		public CharacterSkillData();
	
		// Methods
		public SkillDataElement GetTransSkillData(int phase);
		public SkillDataElement GetNextTransSkillData();
		public bool CheckTransSkill(CollisionHitAttribute attr);
		public void TransformSkill();
		public void ReleaseTransSkill(CharacterBase owner);
		public bool IsExistTransSkill();
		public void DisableTrans();
		public bool ChangeMode(int skillId);
		public bool ChangeMode();
		public bool ResetMode();
		public void SetupChainData(SkillChainDataElement data);
		public int IsEnableChain(PlayerCharacter owner, bool isSameIndex);
		private bool IsMatchChainCondition(PlayerCharacter owner, SkillChainDataElement data, bool isSameIndex);
		public bool IsActiveChain();
		public bool IsShareSkill();
	}
}
