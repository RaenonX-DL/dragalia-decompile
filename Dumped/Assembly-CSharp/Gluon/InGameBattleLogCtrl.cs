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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameBattleLogCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _adjustRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _buttonRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _logRt;
		[SerializeField]
		[Tooltip]
		private Button _button;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _buttonImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private int _logDisplayNum;
		[SerializeField]
		[Tooltip]
		private float _questStartWaitTime;
		[SerializeField]
		[Tooltip]
		private float _logHistoryCheckTime;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] _buttonImageList;
		private VisibleUIObject _rootVisible;
		private VisibleUIObject _logVisible;
		private List<InGameBattleLogUI> _logUIList;
		private List<InGameBattleLogUI> _workLogUIList;
		private List<InGameBattleLogUI> _displayLogUIList;
		private List<LogData> _workLogDataList;
		private List<LogData> _standbyLogDataList;
		private List<LogData> _displayLogDataList;
		private List<LogData> _removeLogDataList;
		private bool _isLeft;
		private bool _isShow;
		private bool _isEnable;
		private bool _isQuestStartWait;
		private float _questStartWaitRemain;
		private Dictionary<CharacterBase, List<RegistData>> _skillBuffRegistList;
		private Dictionary<CharacterBase, List<RegistData>> _abilityBuffRegistList;
		private Dictionary<CharacterBase, List<RegistData>> _abilityFirstApplyIgnoreList;
		private Canvas _buttonCanvas;
		private Dictionary<int, OtherCharaImage> _otherCharaImageList;
		private Dictionary<CharacterBase, CharaBuffTypeCount> _charaBuffCountList;
		[CompilerGenerated]
		private bool _LogDisplayFast_k__BackingField;
		private const int LogUIListReserveNum = 8;
		private const int LogDataListReserveNum = 64;
		private const int RegistDataListReserveNum = 8;
		private const float SystemMessageDisplayTime = 2f;
		private static readonly int[] HunterHornActionIds;
	
		// Properties
		private int LogMaxNum { get; }
		private int LogDisplayNum { get; }
		public bool LogDisplayFast { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private class OtherCharaImage
		{
			// Fields
			public Sprite sprite;
			public Material material;
	
			// Constructors
			public OtherCharaImage();
		}
	
		private class CharaBuffTypeCount
		{
			// Fields
			public int prevCount;
			public int curCount;
	
			// Constructors
			public CharaBuffTypeCount();
			public CharaBuffTypeCount(int prevCount, int curCount);
		}
	
		private enum ButtonImageType
		{
			On = 0,
			On_L = 1,
			Off = 2
		}
	
		public enum LogType
		{
			None = 0,
			Buff = 1,
			AbilityBuff = 2,
			Ability = 3,
			EnemyAbility = 4,
			EnemyBuff = 5,
			Abnormal = 6,
			SimpleText = 7
		}
	
		public enum ButtonSortingOrderType
		{
			Default = 0,
			ContinueCamera = 1
		}
	
		public class LogData
		{
			// Fields
			public CharacterBase chara;
			public LogType logType;
			public AbilityDataElement ade;
			public ActionTargetGroup targetGroup;
			public int id;
			public int subId;
			public int subId2;
			public int subId3;
			public int actionId;
			public string title;
			public string detail;
			public string detail2;
			public ElementalType detailElementType;
			public CharacterBuffType buffType;
			public AbilityConst.Type abilityType;
			public int abilitySubType;
			public int abilityIndex;
			public int abilityIcon;
			public int uniqueBuffIcon;
			public float value;
			public bool isRegene;
			public bool isSlip;
			public bool isEnhanced;
			public bool isSkillConnect;
			public bool isHunterHornAction;
			public bool isSyncData;
			public bool isForceIdCheck;
			public bool isDisplayed;
			public float historyCheckTime;
			public const int AbilityIconDefaultID = -1;
			public const int AbilityIconHiddenID = -2;
	
			// Constructors
			public LogData();
	
			// Methods
			public void Setup([IsReadOnly] in LogData data);
			public void Reset();
			public bool IsDisplayText();
			public bool IsInvalidQuestStartWait();
			public bool IsEnableDetailText();
			public bool IsMatchWithoutId([IsReadOnly] in LogData data);
		}
	
		private class RegistData
		{
			// Fields
			[CompilerGenerated]
			private int _Id_k__BackingField;
			[CompilerGenerated]
			private int _SubId_k__BackingField;
			[CompilerGenerated]
			private int _SubId2_k__BackingField;
			[CompilerGenerated]
			private int _SubId3_k__BackingField;
			[CompilerGenerated]
			private CharacterBuffType _BuffType_k__BackingField;
			[CompilerGenerated]
			private int _UniqueBuffIcon_k__BackingField;
			[CompilerGenerated]
			private float _Value_k__BackingField;
			[CompilerGenerated]
			private ActionTargetGroup _TargetGroup_k__BackingField;
	
			// Properties
			public int Id { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int SubId { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int SubId2 { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int SubId3 { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public CharacterBuffType BuffType { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int UniqueBuffIcon { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float Value { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public ActionTargetGroup TargetGroup { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public RegistData();
			public RegistData([IsReadOnly] in LogData data);
	
			// Methods
			public void Setup([IsReadOnly] in LogData data);
			public void Reset();
			public bool IsMatch([IsReadOnly] in LogData data);
		}
	
		// Constructors
		public InGameBattleLogCtrl();
		static InGameBattleLogCtrl();
	
		// Methods
		public static InGameBattleLogCtrl Create(GameObject parent, int siblingIndex = -1, bool isStartImmediate = false);
		private void Initialize(bool isStartImmediate);
		public override void FastUpdate();
		private bool CheckEnable();
		public void Show();
		public void Hide();
		public void SetLogEnable(bool enable);
		public void OnClickLog();
		private void SetVisibleLog(bool visible, bool force = false);
		private void ChangeButtonImage(bool on);
		private bool IsEnableButtonInput();
		public bool AddLog([IsReadOnly] in LogData data, out bool isAdd, out bool isRegistered, bool isSkipRegister = false);
		private void RegistDisplayLogDataList([IsReadOnly] in LogData data);
		private void RemoveDisplayLogDataList();
		private void DisplayLog([IsReadOnly] in LogData data, ref List<InGameBattleLogUI> list);
		private void SortHiddenLogUIByLogUIList([IsReadOnly] in InGameBattleLogUI hiddenLogUI);
		private void ResetRegistData(ref Dictionary<CharacterBase, List<RegistData>> list, LogData data);
		private void ResetLog();
		public bool IsDisplayableUI(bool ignoreInside = false);
		private void SetDisplayFast([IsReadOnly] in List<InGameBattleLogUI> list);
		private void GetDisplayLogUIList(ref List<InGameBattleLogUI> list);
		private InGameBattleLogUI GetHiddenLogUI();
		public void SetLayout(bool isLeft, bool force = false);
		private bool CheckTargetEnable([IsReadOnly] in LogData data);
		public static bool IsBattleLogDisplayEnableByAbility(AbilityDataElement ade, int idx);
		private static bool IsBattleLogDisplayEnableByAbilityCondition(AbilityDataElement ade);
		public static float GetAbilityValue(AbilityDataElement ade, int idx, int count);
		public static string GetAbilityVariousString(AbilityDataElement ade, AbilityConst.Type targetType);
		public static int GetAbilityIconType(AbilityDataElement ade, int idx, float value);
		private bool CheckRegistList(ref Dictionary<CharacterBase, List<RegistData>> registList, [IsReadOnly] in LogData data);
		public void AddOtherCharaImage(int charaBaseId, int subId);
		public bool GetOtherCharaImage(int charaBaseId, int subId, out Sprite sprite, out Material material);
		public void SetCharaBuffTypeCount(CharacterBase owner, int prevCount, int curCount);
		public bool GetCharaBuffTypeCount(CharacterBase owner, out int prevCount, out int curCount);
		public static bool GetSkillDataElementFromActionId(CharacterBase chara, int actionId, out SkillDataElement sde);
		public static bool GetPrevTransSkillDataElementFromActionId(CharacterBase chara, int actionId, out SkillDataElement sde);
		public static bool GetCollisionHitAttrFromActionId(CharacterBase chara, int actionId, int conditionId, out CollisionHitAttribute collisionHitAttr, out PlayerActionHitAttributeElement playerHitAttr);
		public static float GetValueByAbility(AbilityDataElement ade, int idx, float value, CharacterParameter.FluctuationParameter param);
		public static int GetAbilityIdFromSkillDataElement(CharacterBase chara, int index);
		public static string GetCharaName(CharacterBase chara);
		public static EnemyAbilityElement GetEnemyAbilityFromConditionId(int conditionId);
		public static string GetEnemyAbilityDetailText(CharacterBase chara, CharacterBuffType buffType, int conditionId);
		public void SetButtonSortingOrder(ButtonSortingOrderType type);
	}
}
