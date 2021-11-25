using System.Collections;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleAbilityReleaseSkillMaterialPopup : CommonPopup, ICustomMessage
	{
		public enum PopupType
		{
			None,
			Skill,
			Ability,
			ExAbility,
			BurstAttack
		}

		public Text subTitle1;

		public Text subTitle2;

		public Text label2;

		public Text requiredMpNum;

		public Text currentMPNum;

		public Text afterMPNum;

		public Text warningText;

		public Image manaIcon;

		public Image dewIcon;

		public Image iconImage;

		public GameObject burstAttackIcon;

		public Text nameText;

		public Text detailText;

		public CommonIconListSortDeco iconDeco;

		public ScrollRect detailScrollRect;

		public CommonIcon[] icons;

		public Image[] requiredLabels;

		public Text[] requiredNumText;

		public Image[] havingLabels;

		public Text[] havingNumText;

		public Text[] havingText;

		public Image[] tradeIcons;

		public GameObject bottomHalf;

		public GameObject[] items;

		public Image[] itemIconImages;

		public CommonIconListSortDeco[] itemIconDeco;

		public Text[] itemDetailText;

		public GameObject burstAttackBaseObj;

		public GameObject statusUpBaseObj;

		public Text statusText;

		public Text statusLabel;

		public Text beforeText;

		public Text afterText;

		public GameObject manaOrdewRequiredObj;

		public GameObject materialObj;

		private readonly Color insufficientTextColor;

		private readonly Color insufficientRequiredColor;

		private readonly Color insufficientHavingColor;

		private readonly Color sufficientRequiredColor;

		private readonly Color sufficientHavingColor;

		private GrowthManaCircleModel model;

		private GrowthManaCircleManaPieceData pieceData;

		private int currentMP;

		private WeaponType weaponType;

		private bool isCircleReleased;

		private bool isReleasePrevPiece;

		public bool isUpdateMaterial
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static GrowthManaCircleAbilityReleaseSkillMaterialPopup Create(ManaPieceType type)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetParameters(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData, int currentMP, WeaponType weaponType, bool isCircleReleased = true, bool isReleasePrevPiece = true)
		{
		}

		private void UpdateMaterials()
		{
		}

		public static MaterialDataElement GetRequiredLimitReleaseMaterial(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return null;
		}

		public static MaterialDataElement GetRequiredLimitReleaseGrowMaterial(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return null;
		}

		public static MaterialDataElement GetRequiredLimitReleaseUniqueMaterial(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return null;
		}

		public static int GetHavingLimitReleaseMaterialNum(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return default(int);
		}

		public static int GetHavingLimitReleaseGrowMaterialNum(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return default(int);
		}

		public static int GetHavingLimitReleaseUniqueMaterialNum(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return default(int);
		}

		public static int GetRequiredLimitReleaseMaterialNum(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return default(int);
		}

		public static int GetRequiredLimitReleaseGrowMaterialNum(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return default(int);
		}

		public static int GetRequiredLimitReleaseUniqueMaterialNum(GrowthManaCircleManaPieceData pieceData, int index)
		{
			return default(int);
		}

		private void SetSkill(GrowthManaCircleManaPieceData pieceData)
		{
		}

		private void SetAbility(GrowthManaCircleManaPieceData pieceData)
		{
		}

		private void SetExAbility(GrowthManaCircleManaPieceData pieceData)
		{
		}

		private void SetBurstAttack(GrowthManaCircleManaPieceData pieceData, WeaponType weaponType)
		{
		}

		private void SetComboLevelUp(GrowthManaCircleManaPieceData pieceData)
		{
		}

		private void SetMaxLevelUp(GrowthManaCircleManaPieceData pieceData)
		{
		}

		public void SetItem(GrowthManaCircleManaPieceData pieceData)
		{
		}

		public void SetIconImage(PopupType type, int masterId, int level)
		{
		}

		public void SetNameText(string name, ElementalType type = ElementalType.NONE)
		{
		}

		public void SetDetailText(string detail, ElementalType type = ElementalType.NONE)
		{
		}

		private IEnumerator SetScrollRectMovementType()
		{
			return null;
		}

		public void SetLevelText(int level, bool isMax = false)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
