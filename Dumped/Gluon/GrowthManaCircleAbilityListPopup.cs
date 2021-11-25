using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleAbilityListPopup : CommonPopup
	{
		public Text abilityListText;

		public GameObject scrollViewContent;

		public RectTransform scrollViewRect;

		public Text atkText;

		public Text hpText;

		public Text exAbilityText;

		public Text exAbility2Text;

		public Text burstAttackText;

		public Text atkNum;

		public Text hpNum;

		public Text exAbilityNum;

		public Text exAbility2Num;

		public Text burstAttackNum;

		public Text skill1Num;

		public Text skill2Num;

		public Text ability1Num;

		public Text ability2Num;

		public Text ability3Num;

		public Text storyNum;

		public Text itemNum;

		public Text skill1Desc;

		public Text skill2Desc;

		public Text ability1Desc;

		public Text ability2Desc;

		public Text ability3Desc;

		public Text storyDesc;

		public Text itemDesc;

		public Image atkImage;

		public Image hpImage;

		public Image exAbilityImage;

		public Image exAbility2Image;

		public Image burstAttackImage;

		public Image skill1Image;

		public Image skill2Image;

		public Image ability1Image;

		public Image ability2Image;

		public Image ability3Image;

		public Image storyImage;

		public Image itemImage;

		public Text releasePieceText;

		public Text limitReleaseText;

		public Text releasedPieceNum;

		public Text limitReleaseNum;

		public Text hpAtkText;

		public Text comboText;

		public Text lvLimitText;

		public Text hpAtkNum;

		public Text comboNum;

		public Text lvLimitNum;

		public GameObject storyNode;

		public GameObject itemNode;

		public GameObject hpAtkNode;

		public GameObject comboNode;

		public GameObject lvLimitNode;

		[HideInInspector]
		public GrowthManaCircleModel manaCircle2DModel;

		public static GrowthManaCircleAbilityListPopup Create()
		{
			return null;
		}

		public void InitPopup([Optional] GrowthManaCircleModel manaCircle2DModel)
		{
		}
	}
}
