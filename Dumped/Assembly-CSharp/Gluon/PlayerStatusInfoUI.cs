/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStatusInfoUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		protected RectTransform _infoRt;
		[Header]
		[SerializeField]
		[Tooltip]
		protected int _horizontalIconNum;
		[SerializeField]
		[Tooltip]
		protected int _verticalIconNum;
		protected CharacterBase _character;
		protected int _pageIndex;
		protected int _pageMax;
		protected float _listCollectInterval;
		protected List<CharaStatusInfoUI> _infoList;
		protected List<CharacterBuffCoolDownController.CoolDownData> _workCoolDownList;
		protected static GameObject _originStatusInfoUI;
		public const float ListCollectIntervalTime = 0.16666667f;
	
		// Properties
		protected int PageIconNum { get; }
	
		// Constructors
		public PlayerStatusInfoUI();
		static PlayerStatusInfoUI();
	
		// Methods
		protected void Awake();
		protected void OnDestroy();
		public void SetCharacter(CharacterBase chara);
		public override void FastUpdate();
		public void OnChangePage();
		protected virtual void CollectStatusInfo();
		protected void CollectStatusInfoByEnemyAbility(EnemyCharacter enemy, int startIndex, int endIndex, ref int index, ref int uiIndex);
		protected int GetDisplayStartIndex();
		protected int GetDisplayEndIndex();
		protected void SetPageIndex(int num);
		protected bool CheckDispRange(int startIndex, int endIndex, int index);
		protected virtual CharaStatusInfoUI CreateStatusInfoUI();
		protected CharaStatusInfoUI GetStatusInfoUI();
		protected CharaStatusInfoUI GetStatusInfoUI(InGameBuffUI.BuffIconType type, int index);
		protected CharaStatusInfoUI GetStatusInfoUI(InGameBuffUI.UniqueBuffIconType type, int index);
		protected CharaStatusInfoUI GetStatusInfoUI(AbnormalStatusType type);
		protected CharaStatusInfoUI GetStatusInfoUI(EnemyAbilityType type);
	}
}
