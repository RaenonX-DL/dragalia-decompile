using Gluon.Event;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartBreakUI : MonoBehaviour
	{
		public enum Type
		{
			PartBreak,
			SecondElements
		}

		public class Param
		{
			public Type displayType;

			public int partNum;

			public int[] partType;

			public string[] partName;

			public float[] partHpRate;

			public bool[] partSecondTime;

			public bool isChangeBoss;

			public void Setup(NotifyCharacter.OpenPartBreakParam param)
			{
			}
		}

		public class ParamSetPlayer
		{
			public int partIndex;

			public int playerNo;
		}

		private class PartInfo
		{
			public int type;

			public RectTransform bg;

			public RectTransform filter;

			public Button button;

			public Text label;

			public SpriteRenderer icon;

			public InGameGaugeUISpriteRenderer gauge;

			public VisibleUIObject iconVisible;

			public VisibleUIObject[] playerIconVisible;
		}

		[SerializeField]
		[Header("component")]
		private GameObject bgTemplate;

		[SerializeField]
		[Header("parameter")]
		private float margin;

		private int numElement;

		private PartInfo[] partInfo;

		private TargetParts eventParts;

		private NotifyCharacter.CharaDialogueNPCParam dialogueParam;

		private int ownPlayerIndex;

		private string announceText;

		private InGameFollowLayout followLayout;

		private Transform buttonBaseTransform;

		private VisibleUIObject rootVisible;

		private float talkTime;

		public const int maxElement = 4;

		private const float talkTimeDefault = 2.4f;

		public static PartBreakUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(Transform parent)
		{
		}

		public void Open(Param param)
		{
		}

		public void Close()
		{
		}

		private void Update()
		{
		}

		public void SetPlayer(int partIndex, int playerNo)
		{
		}

		public void SetHP(int partIndex, float hp, bool immediate, bool secondTime = false)
		{
		}

		public void SetHPForType(int type, float hp, bool immediate, bool secondTime = false)
		{
		}

		public void SetOwnPlayerIndex(int index)
		{
		}

		private void OnClick(int partIndex)
		{
		}

		private void SetTargetParts(int playerIndex, int partsId, int characterId)
		{
		}

		public void OnTargetParts(int playerIndex, int partsId)
		{
		}
	}
}
