using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class DmodeUsableItemsInGamePopup : PopupBase
	{
		[SerializeField]
		[Header("Mode")]
		private GameObject[] dragonModeGOs;

		[SerializeField]
		private GameObject[] shareSkillModeGOs;

		[SerializeField]
		[Header("Warning")]
		private GameObject uniqueDragonWarningGO;

		[SerializeField]
		[Header("Positioning")]
		private RectTransform baseOffsetHandle;

		[SerializeField]
		[Header("Icons")]
		private DmodeCommonInGameIcon iconTemplate;

		[SerializeField]
		[Header("Publisher")]
		private UIAnimationPublisher publisher;

		private DmodeDungeonItemType mode;

		private List<DmodeCommonInGameIcon> icons;

		private Action<int> onClose;

		private int selectedId;

		private bool disableIcons;

		public static readonly string prefabPath;

		public static DmodeUsableItemsInGamePopup Create(DmodeDungeonItemType mode, Action<int> onClose)
		{
			return null;
		}

		private void Initialize(DmodeDungeonItemType mode, Action<int> onClose)
		{
		}

		public void OnIconPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void ProcessUseCommand()
		{
		}

		public void OnChangeSkillButtonPressed()
		{
		}

		public void ShowSkillSelectPopup([Optional] Action onClose)
		{
		}

		private void UpdateContent([Optional] List<int> ids)
		{
		}

		private void SetupContent([Optional] int[] items)
		{
		}

		public void ShowPopup(bool disableIcons = false)
		{
		}

		public void ClosePopup()
		{
		}

		public void OnClickBGCloseButton()
		{
		}
	}
}
