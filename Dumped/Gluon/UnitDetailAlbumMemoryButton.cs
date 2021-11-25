using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitDetailAlbumMemoryButton : MonoBehaviour
	{
		[SerializeField]
		public Button button;

		[SerializeField]
		private Text title;

		[SerializeField]
		private UnitDetailAlbumMemoryPopup.MemoryType memoryType;

		private UnityAction<UnitDetailAlbumMemoryPopup.MemoryType> onButtonPressed;

		private CharaDataElement charaData;

		public void InitContents(CharaDataElement master, UnitDetailAlbumMemoryPopup.MemoryType type, string str, UnityAction<UnitDetailAlbumMemoryPopup.MemoryType> onCallback)
		{
		}

		public bool IsAwakingCondition()
		{
			return default(bool);
		}

		public bool IsAwakingSecondCondition()
		{
			return default(bool);
		}

		public void OnButtonPressed()
		{
		}

		public void IsInteractable(bool interactable)
		{
		}
	}
}
