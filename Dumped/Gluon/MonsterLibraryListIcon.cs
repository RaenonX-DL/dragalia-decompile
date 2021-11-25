using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MonsterLibraryListIcon : TableViewCell<MonsterLibraryListData>
	{
		public Image newIcon;

		public Image monsterIcon;

		public Image elementIcon;

		public Image completeIcon;

		public Text pieceCount;

		[SerializeField]
		public StampListButtonEvent buttonPressed;

		public override void UpdateContent(MonsterLibraryListData data)
		{
		}

		public void OnButtonPressed()
		{
		}
	}
}
