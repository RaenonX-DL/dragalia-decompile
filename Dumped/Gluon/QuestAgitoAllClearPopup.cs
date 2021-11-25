using System;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestAgitoAllClearPopup : PopupBase
	{
		[SerializeField]
		[Header("Content")]
		private Transform flashNode;

		[SerializeField]
		private Transform cancelButtonNode;

		[SerializeField]
		private Transform okButtonNode;

		[SerializeField]
		private Canvas okMarkCanvas;

		[SerializeField]
		private Canvas cancelMarkCanvas;

		private const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/QuestAgitoAllClearPopup";

		private const string flashPath = "Prefabs/OutGame/QuestSelect/Popup/pf_AgitoComplete";

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

		public static QuestAgitoAllClearPopup Create(Action onGoStory)
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
