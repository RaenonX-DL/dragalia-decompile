using System.Collections;
using System.Runtime.InteropServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyCharacterUIStatus : MonoBehaviour
	{
		public PartyCharacterUICanvas canvas;

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

		public GameObject skinIconObj;

		public Image skill3Icon;

		public Image skill4Icon;

		public Image supportSkillIcon;

		public GameObject[] rarityIcons;

		[SerializeField]
		private ThemeColorImageSwitcher statusImageSwithcer;

		[SerializeField]
		private Text emptyText;

		[SerializeField]
		private Button emptyButton;

		[SerializeField]
		private Image baseImage;

		[SerializeField]
		private Image baseImageEmpty;

		public GameObject emptyEditSkillBaseObject;

		[SerializeField]
		private GameObject disabledImage;

		[SerializeField]
		private GameObject normalModeParent;

		[SerializeField]
		private GameObject crestMode1Parent;

		[SerializeField]
		private GameObject crestMode2Parent;

		[SerializeField]
		private GameObject[] crestEmptyMessageObject;

		public GameObject[] attributeMatchEffects;

		private bool[] isFinishSettingAttributeMatchEffect;

		private FlRoot[] _attributeMatchEffectsFlRoot;

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

		public void Reload(int charaId, ulong dragonKeyId, ulong weaponBodyId, int type1Crest1Id, int type1Crest2Id, int type1Crest3Id, int type2Crest1Id, int type2Crest2Id, int type3Crest1Id, int type3Crest2Id, ulong talismanKeyId, int skill3CharaId = 0, int skill4CharaId = 0)
		{
		}

		private void SetCrestIconState(Image icon, Image plusIcon, Image lockIcon, Button crestButton, int slotIndex, int baseSlotCount, int maxSlotCount, int unlockedSlotCount)
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

		public void OnCrestIconPressed(int index)
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

		private void CreatePartyShareSkillSetNoReaderPopupTitle()
		{
		}

		public void OnSupportSkillIconPressed()
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

		public void OnTalismanIconLongPressed()
		{
		}

		public void OnSkill3IconLongPressed()
		{
		}

		public void OnSkill4IconLongPressed()
		{
		}

		private void SetEquipMode(PartyModel.EquipMode equipMode)
		{
		}

		private void CreateAttributeMatchEffect(ElementalType elementalType, PartyUIStatus.AttributeMatchEffectParentType parentType, bool isSync, bool isStay)
		{
		}

		private void SetAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType)
		{
		}

		public void SyncAttributeMatchEffect([Optional] AutoPartyConfigData selectData)
		{
		}

		public IEnumerator WaitExistFlRootMotion(UnityAction callback, PartyUIStatus.AttributeMatchEffectParentType parentType, bool withWaitSetAttributeMatchEffect = false)
		{
			return null;
		}

		public FlRoot GetAttributeMatchEffectsFlRoot(PartyUIStatus.AttributeMatchEffectParentType parentType)
		{
			return null;
		}

		private void DestroyAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType)
		{
		}

		private void OnDestroy()
		{
		}

		public void SetCrestIcon(int keyId, int slotIndex, IconLoader.Size iconSize, Image iconImage, Image plusIcon, CommonUnionIcon unionIcon)
		{
		}

		private void OneUnitQuestSetting(bool isOneUnit)
		{
		}
	}
}
