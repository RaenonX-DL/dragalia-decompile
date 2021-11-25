using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleAbilityReleaseStatusPopup : CommonPopup
	{
		public Text subTitle1;

		public Text label1;

		public Text beforeNum;

		public Text afterNum;

		public Transform statusBase2;

		public Text statusLabel2;

		public Text beforeNum2;

		public Text afterNum2;

		public Text subTitle2;

		public Text label2;

		public Text requiredMpNum;

		public Text currentMPNum;

		public Text afterMPNum;

		public Text warningText;

		public Text newStoryText;

		public Text storyDescText;

		public Image storyIcon;

		public GameObject storyLockLayer;

		public bool isReleaseStory;

		public GameObject manaOrdewRequiredObj;

		public RectTransform manaRequiredRect;

		public RectTransform manaConsumeResultRect;

		public GameObject materialObj;

		public GrowthManaCircleReleaseMaterialIcon[] materialIconList;

		public static GrowthManaCircleAbilityReleaseStatusPopup Create(bool isReleaseStory)
		{
			return null;
		}

		public void SetParameters(GrowthManaCircleManaPieceData pieceData, GrowthManaCircleModel model, int currentMP, bool isCircleReleased = true, bool isReleasePrevPiece = true)
		{
		}
	}
}
