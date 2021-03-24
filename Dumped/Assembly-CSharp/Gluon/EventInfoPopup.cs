/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventInfoPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text closeButtonText;
		[SerializeField]
		private UnityEngine.UI.Text helpButtonText;
		[SerializeField]
		private Button helpButton;
		[SerializeField]
		private PageViewBase pageView;
		public int imageCount;
		[CompilerGenerated]
		private QuestEventGroupElement _groupElement_k__BackingField;
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
	
		// Properties
		public QuestEventGroupElement groupElement { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public EventInfoPopup();
		static EventInfoPopup();
	
		// Methods
		public static EventInfoPopup Create(QuestEventGroupElement groupElement, bool isEventQuestScene, Transform parentTransform = null);
		public static EventInfoPopup CreateWithTemplate(int eventId, string imageTemplate, int pageCount);
		public void SetContent(int eventId, string imageTemplate, int pageCount);
		public void SetContent(QuestEventGroupElement groupElement);
		protected override void Start();
		public void OnHelpButtonTouched();
		[CompilerGenerated]
		private void _Start_b__22_0(GameObject page, int index);
		[CompilerGenerated]
		private void _OnHelpButtonTouched_b__23_0();
	}
}
