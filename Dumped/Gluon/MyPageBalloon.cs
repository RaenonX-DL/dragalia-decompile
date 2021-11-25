using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPageBalloon : MonoBehaviour
	{
		public enum TextType
		{
			None,
			Talk_L,
			Talk_R,
			Talk_L_L00,
			Talk_L_L01,
			Talk_L_R00,
			Talk_L_R01
		}

		public enum IconType
		{
			None,
			Question_L,
			Question_R
		}

		public enum MoveMapCharaType
		{
			None = -1,
			TalkPair1,
			TalkPair2,
			Bye,
			Walking,
			RunMap1,
			RunMap2,
			RunMap3,
			RunMap4
		}

		public TextType textType;

		public IconType iconType;

		public MoveMapCharaType moveMapCharaType;

		public MyPageTalkCanvas canvas;

		public int myIndex;

		public bool isEventTalk;

		public MyPageObjectsSettings settings;

		public MyPageMoveMapCharaPosSettings moveMapCharaPosSettings;

		public CanvasGroup canvasGroup;

		public Text characterNameText;

		public Text textText;

		public OutGameCharacterTalkManager.TalkEntity talk;

		public GameObject[] balloons;

		public Text[] characterNames;

		public Text[] texts;

		public float transparentMinZ;

		public float opaqueMinZ;

		public float opaqueMaxZ;

		public float transparentMaxZ;

		private RectTransform rectTransform;

		private Vector3 lastPosition;

		private RectTransform canvasRectTransform;

		private void Awake()
		{
		}

		public void ResetBigTalk()
		{
		}

		public void Setup(IconType iconType, TextType textType, string characterName = "", [Optional] OutGameCharacterTalkManager.TalkEntity talk, MoveMapCharaType moveMapCharaType = MoveMapCharaType.None)
		{
		}

		public void SetCanvasPosition(float x, float y)
		{
		}
	}
}
