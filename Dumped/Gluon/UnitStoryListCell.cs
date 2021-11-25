using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitStoryListCell : TableViewCell<UnitStoryListCellData>
	{
		[SerializeField]
		private Image newIconImage;

		[SerializeField]
		private Shader exchangeShader;

		[SerializeField]
		[Header("ã\u0082­ã\u0083£ã\u0083©ã\u0083»ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0082¹ã\u0083\u0088ã\u0083¼ã\u0083ªã\u0083¼ã\u0082»ã\u0083«")]
		private Button cellButton;

		[SerializeField]
		private GameObject storyCell;

		[SerializeField]
		private CommonIcon unitIcon;

		[SerializeField]
		private Text unitNameText;

		[SerializeField]
		private Text titleNameText;

		[SerializeField]
		private GameObject lockLayer;

		[SerializeField]
		private Text triggerText;

		[SerializeField]
		private GameObject characterCell;

		[SerializeField]
		private CommonIcon characterIconWide;

		[SerializeField]
		private Text characterNameText;

		[SerializeField]
		[Header("ã\u0082­ã\u0083£ã\u0083\u0083ã\u0082¹ã\u0083«ã\u0082¹ã\u0083\u0088ã\u0083¼ã\u0083ªã\u0083¼ã\u0082»ã\u0083«")]
		private Button castleCellButton;

		[SerializeField]
		private Image castleCellBgImage;

		[SerializeField]
		private Text castleTitleNameText;

		[SerializeField]
		private GameObject castleLockLayer;

		[SerializeField]
		private Text castleItemUseNumText;

		[SerializeField]
		private Image castleItemIconImage;

		private UnityAction pressedCallback;

		public override void UpdateContent(UnitStoryListCellData data)
		{
		}

		public void OnCellButtonPressed()
		{
		}
	}
}
