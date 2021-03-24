/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultRankingPartyMemberCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon charaIcon;
		[SerializeField]
		private Image anotherNameIcon;
		[SerializeField]
		private UnityEngine.UI.Text usernameText;
		[SerializeField]
		private UnityEngine.UI.Text playerLevelText;
		[SerializeField]
		private Image youTextImage;
	
		// Constructors
		public QuestResultRankingPartyMemberCell();
	
		// Methods
		public void SetContent(int charaId, int emblemId, string userName, int level, bool isShowYouImage);
	}
}
