using System.Runtime.InteropServices;
using FLATOUT.Main;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestFlashPopup : CommonPopup
	{
		public static readonly string questFlashPopupPath;

		private FlRoot flashRoot;

		private FlText flText;

		private FlPlane flPlane;

		private Image elementImage;

		private Text nameText;

		private FlText flDetailText;

		private Text detailText;

		private const string seGroupName = "OUT_COMMON";

		private const string seName = "SE_OUT_COMMON_0058";

		public static QuestFlashPopup Create(string flashPath, [Optional] UnityAction<FlRoot> action)
		{
			return null;
		}

		public void SetContent(string flashPath, [Optional] UnityAction<FlRoot> action)
		{
		}

		public static QuestFlashPopup CreateQuestWallComplete(string flashPath, ElementalType elementType, string name, string detail)
		{
			return null;
		}

		public void SetContent(string flashPath, ElementalType elementType, string name, string detail)
		{
		}

		private void Update()
		{
		}

		public void OnInAnimation()
		{
		}

		public void OnOutAnimation()
		{
		}

		public void OnClose()
		{
		}
	}
}
