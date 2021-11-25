using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class IconWithCountLabel : MonoBehaviour
	{
		public RawImage iconMaterial;

		[SerializeField]
		private Image needsNode;

		[SerializeField]
		private Image owneNode;

		[SerializeField]
		public Text needCounttext;

		[SerializeField]
		public Text currentCoundtext;

		[SerializeField]
		private Image tradeIcon;

		private bool canTrade;

		private int materialId;

		private readonly Color insufficientTextColor;

		private readonly Color insufficientRequiredColor;

		private readonly Color insufficientHavingColor;

		private readonly Color sufficientRequiredColor;

		private readonly Color sufficientHavingColor;

		private Text[] displayTextList;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetContent(int materialData, int needCount)
		{
		}

		private void SetLabelColor(bool isSufficient)
		{
		}

		public void CreateItemDetailPopup()
		{
		}
	}
}
