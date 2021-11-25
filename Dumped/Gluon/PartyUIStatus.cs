using System.Collections;
using System.Runtime.InteropServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyUIStatus : MonoBehaviour
	{
		public enum AttributeMatchEffectParentType
		{
			Weapon,
			Dragon,
			Max
		}

		protected const int maxNameFrameStrLength = 10;

		protected const int maxNameFrameEnStrLength = 20;

		public PartyUICanvas canvas;

		public RawImage render3dImage;

		public int myIndex;

		public CanvasGroup activeCanvasGroup;

		public Text lvText;

		public Image elementIcon;

		public Image weaponTypeIcon;

		public Image dragonIcon;

		public Image dragonBlankPlusIcon;

		public Image weaponIcon;

		public Image[] crestIcons;

		public Button[] crestIconButtons;

		public Image[] crestBlankPlusIcons;

		public Image[] crestLockIcons;

		public CommonUnionIcon[] crestUnionIcons;

		public Image charaStatusUIBase;

		public Text equipEditText;

		public Button emptyFrameButton;

		public Text SizeControllText;

		public Text NameText;

		public Image baseImage;

		public Image baseImageEmpty;

		public Text totalPlusText;

		public GameObject skinIconObj;

		public Image skill3Icon;

		public Image skill4Icon;

		[SerializeField]
		protected GameObject emptyEditSkillBaseObject;

		[SerializeField]
		protected GameObject[] crestEmptyMessageObject;

		[SerializeField]
		private GameObject normalModeParent;

		[SerializeField]
		private GameObject crestMode1Parent;

		[SerializeField]
		private GameObject crestMode2Parent;

		private int _curCharaId;

		public GameObject[] rarityIcons;

		public GameObject[] attributeMatchEffects;

		public bool[] isFinishSettingAttributeMatchEffect;

		private FlRoot[] _attributeMatchEffectsFlRoot;

		public const string attributeMatchEffectPathBase = "Prefabs/OutGame/Party/Flash/pf_AttributeMatchEffect";

		protected int curCharaId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void ShowNormalUI()
		{
		}

		public void ShowCrestUI(PartyModel.PartySceneUnitStatusMode statusMode)
		{
		}

		public void Reload()
		{
		}

		protected virtual void SetEmptyStatus()
		{
		}

		public virtual void Reload(int charaId, ulong dragonKeyId, ulong weaponBodyId, int type1Crest1Id, int type1Crest2Id, int type1Crest3Id, int type2Crest1Id, int type2Crest2Id, int type3Crest1Id, int type3Crest2Id, int skill3CharaId = 0, int skill4CharaId = 0)
		{
		}

		protected void SetCrestIconState(Image icon, Image plusIcon, Image lockIcon, Button crestButton, int slotIndex, int baseSlotCount, int maxSlotCount, int unlockedSlotCount)
		{
		}

		private void EquipChangeSetting()
		{
		}

		public virtual void OnEquipChangeButtonPressed()
		{
		}

		public void OnStatusPressed()
		{
		}

		public void DragonEquipIconPressed(int tag)
		{
		}

		public void WeaponEquipIconPressed(int tag)
		{
		}

		public void OnCrestIconPressed(int crestIndex)
		{
		}

		public void OnLockedSlotPressed()
		{
		}

		public void Skill3EquipIconPressed()
		{
		}

		public void Skill4EquipIconPressed()
		{
		}

		public void OnShareSkillPopupEnd()
		{
		}

		public void EmptyFramePressed(int tag)
		{
		}

		public void OnDragonIconLongPressed()
		{
		}

		public void OnWeaponIconLongPressed()
		{
		}

		public void OnCrestIconLongPressed(int crestIndex)
		{
		}

		public void OnSkill3IconLongPressed()
		{
		}

		public void OnSkill4IconLongPressed()
		{
		}

		protected void CreateAttributeMatchEffect(ElementalType elementalType, AttributeMatchEffectParentType parentType, bool isSync, bool isStay)
		{
		}

		private void SetAttributeMatchEffect(AttributeMatchEffectParentType parentType)
		{
		}

		public virtual void SyncAttributeMatchEffect([Optional] AutoPartyConfigData selectData)
		{
		}

		public IEnumerator WaitExistFlRootMotion(UnityAction callback, AttributeMatchEffectParentType parentType, bool withWaitSetAttributeMatchEffect = false)
		{
			return null;
		}

		public FlRoot GetAttributeMatchEffectsFlRoot(AttributeMatchEffectParentType parentType)
		{
			return null;
		}

		protected void DestroyAttributeMatchEffect(AttributeMatchEffectParentType parentType)
		{
		}

		private void OnDestroy()
		{
		}

		public static string GetMotionLabel(AttributeMatchEffectParentType parentType)
		{
			return null;
		}

		public static string GetAttributePathAdder(ElementalType element)
		{
			return null;
		}

		public static void CorrectDisplayAttributeMatchEffect(AttributeMatchEffectParentType parentType, int charaId, int parentTargetId, UnityAction createCallback, UnityAction destroyCallback)
		{
		}

		public static bool IsAutoPartySelectTargetAttributeMatchEffect(AutoPartyConfigData selectData, AttributeMatchEffectParentType parentType)
		{
			return default(bool);
		}
	}
}
