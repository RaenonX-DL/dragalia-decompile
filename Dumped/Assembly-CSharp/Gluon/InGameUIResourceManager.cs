/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameUIResourceManager : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private static InGameUIResourceManager _instance_k__BackingField;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _shaderSaturationMonochromeValue;
		[SerializeField]
		[Tooltip]
		private float _shaderBrightnessMonochromeValue;
		private Dictionary<int, InGameUICharaResourceData> _charaResourceDic;
		private Dictionary<int, InGameUIDragonResourceData> _dragonResourceDic;
		private InGameUIMatarialData _emptyItemSkillMaterialData;
		private int _shaderSaturationPropertyID;
		private int _shaderBrightnessPropertyID;
	
		// Properties
		public static InGameUIResourceManager instance { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public InGameUIResourceManager();
	
		// Methods
		public void Awake();
		public void OnDestroy();
		public void Initialize();
		private int GetCharaId(CharacterBase chara);
		public bool SetupCharaResource(HumanCharacter human);
		public bool SetupCharaResource(DragonCharacter dragon);
		public bool GetCharaFaceResource(CharacterBase chara, out Material material, out Material materialMono, out Sprite sprite, out Sprite spriteMono);
		public bool GetCharaResourceForPartyButton(CharacterBase chara, out Material material, out Sprite sprite);
		public bool GetCharaBustupResource(CharacterBase chara, out Material material, out Material damageMaterial);
		public bool GetCharaBustupResource(CharacterBase chara, out Material material);
		public bool GetDragonButtonResource(CharacterBase chara, out Material material);
		public bool GetUniqueTransButtonResource(CharacterBase chara, out Material material);
		public bool GetSkillButtonResource(CharacterBase chara, int skillId, out string iconName, out Material material, out Sprite sprite);
		public bool GetEmptyItemSkillButtonResource(out string iconName, out Material material, out Sprite sprite);
		public bool LoadCharaFaceResource(InGameUICharaResourceData resourceData, HumanCharacter human);
		public bool LoadDragonFaceResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon);
		public bool LoadCharaBustupResource(InGameUICharaResourceData resourceData, HumanCharacter human);
		public bool LoadDragonBustupResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon);
		private bool LoadDragonButtonResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon);
		private bool LoadUniqueTransButtonResource(InGameUICharaResourceData resourceData, HumanCharacter human);
		private void LoadSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara);
		private void LoadSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, SkillDataElement sde);
		private void LoadSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, int skillId);
		private void LoadAdvanecedSkillMaterial(InGameUICommonResourceData resourceData, CharacterBase chara, CharacterSkillData data);
		private void LoadBaseIdSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, CharacterSkillData data);
		private void LoadAdvanecedSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara, ActionParts action);
		private void LoadModeChangeSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter chara);
		private void LoadModeChangeSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter chara, CharaModeDataElement cmde);
		private void LoadChainSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter human);
		private void LoadChainSkillButtonResource(InGameUICommonResourceData resourceData, HumanCharacter human, SkillChainDataElement cde);
	}
}
