using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventInfoPopup : PopupBase
	{
		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text closeButtonText;

		[SerializeField]
		private Text helpButtonText;

		[SerializeField]
		private Button helpButton;

		[SerializeField]
		private PageViewBase pageView;

		public int imageCount;

		private string imageTemplate;

		private int eventId;

		private static readonly string eventPrologueName;

		[SerializeField]
		private int voidImageCount;

		[SerializeField]
		private int questWallImageCount;

		[SerializeField]
		private int astralImageCount;

		[SerializeField]
		private int timeAttackImageCount;

		[SerializeField]
		private int walkerImageCount;

		public QuestEventGroupElement groupElement
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static EventInfoPopup Create(QuestEventGroupElement groupElement, bool isEventQuestScene, [Optional] Transform parentTransform)
		{
			return null;
		}

		public static EventInfoPopup CreateWithTemplate(int eventId, string imageTemplate, int pageCount)
		{
			return null;
		}

		public void SetContent(int eventId, string imageTemplate, int pageCount)
		{
		}

		public void SetContent(QuestEventGroupElement groupElement)
		{
		}

		protected override void Start()
		{
		}

		public void OnHelpButtonTouched()
		{
		}
	}
}
