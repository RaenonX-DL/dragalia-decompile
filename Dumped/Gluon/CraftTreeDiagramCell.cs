using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftTreeDiagramCell : MonoBehaviour
	{
		public Image weaponIcon;

		public Transform selectBase;

		public Transform targetBase;

		public Text selectText;

		public Text baseText;

		public UnityAction<int> cellPressCallBack;

		public int cellId;

		public GameObject sortDecoAttachNode;

		public Image skillIcon;

		public Image[] abilityIcons;

		public Transform spUpgradeBase;

		private bool isEmpty;

		private bool isBaseData;

		private bool isChildData;

		private int weaponId;

		public void SetTreeIcon(CraftTreeDiagramData data)
		{
		}

		public void SetEmptyIcon()
		{
		}

		public void SetSelectBadge(bool isSelect)
		{
		}

		public void OnCellPressed()
		{
		}

		public void OnCellLongPressed()
		{
		}
	}
}
