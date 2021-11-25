using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PlatinumImageSetting : MonoBehaviour
	{
		public GameObject singleImageViewObject;

		public GameObject charaMoveupObject;

		public GameObject platinumComment;

		public Text platinumText;

		public SummonButton platinumButton;

		public Image topBannerImage;

		public GameObject[] typeMarkList;

		public GameObject[] charaBGList;

		public FlashPlayerManager flashPlayerManager;

		public GameObject drawnMask;

		public Text scheduleText;

		public Text remainCountText;

		public GameObject remainCountBalloon;

		public GameObject[] periodType;

		public Text platinumTextDouble;

		[SerializeField]
		private Image topActivePeriodImage;

		[SerializeField]
		private Text topActivePeriodText;

		[SerializeField]
		[Header("CSSummon")]
		public Button switchSummonButton;

		public Sprite[] switchSummonButtonImages;

		public Action onSwitchSummon;

		private const float charaMoveupRate = 0.625f;

		private int summonId;

		private readonly string[] flashPaths;

		private readonly string[] flashEventPath;

		public void Setup(int index, float canvasHeight, SummonTopItemData data)
		{
		}

		private IEnumerator PlayKira()
		{
			return null;
		}

		private string GenerateScheduleText(int summonGroupId, int summonId)
		{
			return null;
		}

		private string GenerateScheduleText(int summonId)
		{
			return null;
		}

		private string GenerateCommentText(int summonGroupId)
		{
			return null;
		}

		public void OnSwitchSummonPressed()
		{
		}
	}
}
