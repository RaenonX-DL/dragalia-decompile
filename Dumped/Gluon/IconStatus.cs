using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class IconStatus : MonoBehaviour
	{
		[SerializeField]
		private Image charaIcon;

		[SerializeField]
		private Button button;

		public UnityAction<int, int, int> onClickCallback;

		private int index;

		private int iconId;

		private int iconType;

		private PointerEventHandler peh;

		public void Awake()
		{
		}

		public void Initialize(int index, int id, EnumIconType type = EnumIconType.Chara)
		{
		}

		public void BlankIcon(EnumIconType type = EnumIconType.Chara)
		{
		}

		private void OnIconButtonPressed()
		{
		}
	}
}
