/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRankingListPartyMemberCell : MonoBehaviour
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
	
		// Constructors
		public EventRankingListPartyMemberCell();
	
		// Methods
		public void SetContent(int charaId, int emblemId, string userName, int level);
	}
}
