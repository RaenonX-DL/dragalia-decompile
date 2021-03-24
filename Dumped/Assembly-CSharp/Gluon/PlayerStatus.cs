/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStatus : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image readerIcon;
		[SerializeField]
		private Image playerNumberIcon;
		[SerializeField]
		private Image rarityIcon;
		[SerializeField]
		private Image elementalIcon;
		[SerializeField]
		private UnityEngine.UI.Text level;
		[SerializeField]
		private GameObject[] questPrepare;
		[SerializeField]
		private GameObject[] questTypePattern;
		[SerializeField]
		private IconStatus[] fourCharaQuestIcon;
		[SerializeField]
		private IconStatus[] raidQuestIcon;
		[SerializeField]
		private Sprite[] playerAtlas;
		[SerializeField]
		private GameObject roomInObj;
		[SerializeField]
		private GameObject emptyObj;
		public UnityAction<int, int, int, int> onClickCallback;
		private const int doragon = 0;
		private const int weapon = 1;
		private int playerStatusIndex;
	
		// Constructors
		public PlayerStatus();
	
		// Methods
		public void Initialize(int index, MatchingService.Player player, bool isShow16Chara);
		public void SetMatchingReadyState(MatchingReadyState state);
		private void OnIconPressed(int index, int id, int type);
	}
}
