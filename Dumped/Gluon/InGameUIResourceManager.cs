using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using Cute.UI;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class InGameUIResourceManager : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080ã\u0083¼ ã\u0083¢ã\u0083\u008eã\u0082\u00afã\u0083­ã\u0081®å½©åº¦å\u0080¤")]
		private float _shaderSaturationMonochromeValue;

		[SerializeField]
		[Tooltip("ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080ã\u0083¼ ã\u0083¢ã\u0083\u008eã\u0082\u00afã\u0083­ã\u0081®æ\u0098\u008eåº¦å\u0080¤")]
		private float _shaderBrightnessMonochromeValue;

		private Dictionary<int, InGameUICharaResourceData> _charaResourceDic;

		private Dictionary<int, InGameUIDragonResourceData> _dragonResourceDic;

		private InGameUIMatarialData _emptyItemSkillMaterialData;

		private AtlasReference _atlasRefData;

		private Dictionary<string, Sprite> _iconNameResourceDic;

		private Dictionary<string, Sprite> _buffIconNameResourceDic;

		private Dictionary<AbnormalStatusType, Sprite> _abnormalStatusTypeIconResourceDic;

		private Dictionary<EnemyAbilityType, Sprite> _enemyAbilityTypeIconResourceDic;

		private Dictionary<int, Sprite> _usedBuffIconIdResourceDic;

		private int _shaderSaturationPropertyID;

		private int _shaderBrightnessPropertyID;

		private static readonly Dictionary<AbnormalStatusType, string> AbnormalStatusIconNameDic;

		private static readonly Dictionary<EnemyAbilityType, string> EnemyAbilityIconNameDic;

		public static InGameUIResourceManager instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void Initialize()
		{
		}

		private void AddIconSprite(Sprite sprite)
		{
		}

		private void AddIconSpriteForBuff(Sprite sprite)
		{
		}

		private void AddIconSpriteForAbnormalStatus(Sprite sprite)
		{
		}

		private void AddIconSpriteForEnemyAbility(Sprite sprite)
		{
		}

		private int GetCharaId(CharacterBase chara)
		{
			return default(int);
		}

		public bool SetupCharaResource(HumanCharacter human)
		{
			return default(bool);
		}

		public bool SetupCharaResource(DragonCharacter dragon)
		{
			return default(bool);
		}

		public bool GetCharaFaceResource(CharacterBase chara, out Material material, out Material materialMono, out Sprite sprite, out Sprite spriteMono)
		{
			return default(bool);
		}

		public bool GetCharaResourceForPartyButton(CharacterBase chara, out Material material, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetCharaBustupResource(CharacterBase chara, out Material material, out Material damageMaterial)
		{
			return default(bool);
		}

		public bool GetCharaBustupResource(CharacterBase chara, out Material material)
		{
			return default(bool);
		}

		public bool GetDragonButtonResource(CharacterBase chara, out Material material)
		{
			return default(bool);
		}

		public bool GetUniqueTransButtonResource(CharacterBase chara, out Material material)
		{
			return default(bool);
		}

		public bool GetSkillButtonResource(CharacterBase chara, int skillId, out string iconName, out Material material, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetEmptyItemSkillButtonResource(out string iconName, out Material material, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetIconResource(string name, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetBuffIconResource(int id, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetAbnormalStatusIconResource(AbnormalStatusType type, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetEnemyAbilityTypeIconResource(EnemyAbilityType type, out Sprite sprite)
		{
			return default(bool);
		}

		public bool LoadCharaFaceResource(InGameUICharaResourceData resourceData, HumanCharacter human)
		{
			return default(bool);
		}

		public bool LoadDragonFaceResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon)
		{
			return default(bool);
		}

		public bool LoadCharaBustupResource(InGameUICharaResourceData resourceData, HumanCharacter human)
		{
			return default(bool);
		}

		public bool LoadDragonBustupResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon)
		{
			return default(bool);
		}

		private bool LoadDragonButtonResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon)
		{
			return default(bool);
		}

		private bool LoadUniqueTransButtonResource(InGameUICharaResourceData resourceData, HumanCharacter human)
		{
			return default(bool);
		}

		private void LoadSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara)
		{
		}

		private void LoadSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, SkillDataElement sde)
		{
		}

		private void LoadSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, int skillId)
		{
		}

		private void LoadAdvanecedSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, CharacterSkillData data)
		{
		}

		private void LoadBaseIdSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, CharacterSkillData data)
		{
		}

		private void LoadAdvanecedSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, ActionParts action)
		{
		}

		private void LoadModeChangeSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter chara)
		{
		}

		private void LoadModeChangeSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter chara, CharaModeDataElement cmde)
		{
		}

		private void LoadChainSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter human)
		{
		}

		private void LoadChainSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter human, SkillChainDataElement cde)
		{
		}

		private void LoadOverChargeSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, CharacterSkillData data)
		{
		}
	}
}
