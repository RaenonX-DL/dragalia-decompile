using System;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestAdvancedDragonAllClearPopup : PopupBase
	{
		[SerializeField]
		[Header("Content")]
		public Transform flashNode;

		public Transform cancelButtonNode;

		public Transform okButtonNode;

		[SerializeField]
		private Canvas okMarkCanvas;

		[SerializeField]
		private Canvas cancelMarkCanvas;

		public const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/QuestAdvancedDragonAllClearPopup";

		public const string flashPath = "Prefabs/OutGame/QuestSelect/Popup/pf_advanced_dragon_complete";

		private const string seName = "SE_OUT_COMMON_0059";

		private Action onGoStory;

		private TouchGuardObject touchGuardObj;

		private FlRoot root;

		private Text clearText;

		private FlText flClearText;

		private FlObject flOkButton;

		private FlObject flCancelButton;

		private CanvasGroup okButtonCanvasGroup;

		private CanvasGroup cancelButtonCanvasGroup;

		public static QuestAdvancedDragonAllClearPopup Create(Action onGoStory)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnOKButtonPressed()
		{
		}

		private void Update()
		{
		}
	}
}
