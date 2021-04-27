/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DefenseEventInfoCtrl
	{
		// Fields
		private InGameUIConst.DecorationType _decorationType;
		private List<DefenseEventProgressMoveObjUI> _idleMoveObjUIList;
		private Dictionary<int, DefenseEventProgressMoveObjUI> _usedMoveObjUIList;
		private DefenseEventLineMsgUI _lineMsgUI;
		private SimpleQueue<MessageData> _lineMsgQueue;
		private string _displayingLineMsg;
		private DefenseEventSystemInfoElement _systemInfo;
		private Dictionary<string, List<PlayFTU.MaterialInfo>> _ftuEventCutInMaterialDic;
		private bool _isInitialized;
		[CompilerGenerated]
		private DefenseEventProgressInfoUI _progressInfoUI_k__BackingField;
		[CompilerGenerated]
		private float _moveObjEndPointLength_k__BackingField;
		private const int LineMsgQueueDataMax = 8;
		private const int IconObjectReserveNum = 8;
		private const int CutInMaterialMaxNum = 2;
		private const float NextAreaMessageDisptime = 4.6f;
		private const float LineMsgUIAdjustPositionY = -70f;
		private const int SystemInfoDefaultID = 0;
		public const float SystemMsgUIAdjustPosY = -240f;
	
		// Properties
		public DefenseEventProgressInfoUI progressInfoUI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float moveObjEndPointLength { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private class MessageData : IReplicable<MessageData>, ICleanable
		{
			// Fields
			public int id;
			public DefenseEventWindowType windowType;
			public DefenseEventIconType iconType;
			public string iconName;
			public int nextAreaMessage;
			public string msg;
	
			// Constructors
			public MessageData();
	
			// Methods
			public void Replicate(MessageData other);
			public void Clean();
		}
	
		public enum DecorationType
		{
			None = -1,
			FEH = 0
		}
	
		public enum MoveObjIconType
		{
			None = -1,
			FEH_Platoon = 0,
			FEH_Commander = 1,
			FEH_Bandits = 2,
			FEH_NUM = 3
		}
	
		public enum SystemInfoType
		{
			FortDamage = 0,
			FortDying = 1,
			FortDead = 2,
			HouseDead = 3,
			NextArea = 4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<DefenseEventProgressMoveObjUI> __9__46_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _ApplyDrawingOrder_b__46_0(DefenseEventProgressMoveObjUI x, DefenseEventProgressMoveObjUI y);
		}
	
		// Constructors
		public DefenseEventInfoCtrl();
	
		// Methods
		public void Initialize(GameObject parent, InGameUIConst.DecorationType type);
		private void LoadCutInMaterial();
		private bool IsLoadCutInMaterial(DefenseEventTalkElement talkData, int questId, int questGroupId);
		private void SetSystemInfoData();
		public void Update();
		public void SetActive(bool active);
		public void Reset();
		public void AttachMoveObj(EnemyCharacter chara, MoveObjIconType iconType);
		public void RemoveMoveObj(int enemySerialId);
		public void RemoveAllMoveObj();
		public void ChangeMoveObj(EnemyCharacter curChara, EnemyCharacter newChara);
		public void SetMoveObjIcon(EnemyCharacter chara, MoveObjIconType iconType);
		public void ApplyMoveObjPosition(EnemyCharacter chara);
		public void CalcMoveObjPathLineLongestDistance();
		public void ActionMoveObjAppear(EnemyCharacter chara);
		public void ActionMoveObjAttack(EnemyCharacter chara);
		public void ActionMoveObjDisappear(EnemyCharacter chara);
		public void ActionFortObjDamage();
		private void ApplyDrawingOrder(DefenseEventProgressMoveObjUI obj);
		public void SetFortObjHpRate(float rate, bool immediate = false);
		private bool IsLineMsgDisplaying(DefenseEventWindowType windowType);
		public void DisplayLineMsg(int id, bool isRegistCheck = false);
		public void DisplayLineMsg(int id, DefenseEventWindowType windowType, DefenseEventIconType iconType, string msg, string iconName, int nextAreaMessage, bool isRegistCheck);
		private void DisplayLineMsgSub(int id, DefenseEventWindowType windowType, DefenseEventIconType iconType, string msg, string iconName, int nextAreaMessage);
		private void OnCompleteLineMessage(DefenseEventIconType type, int nextAreaMessage);
		private bool CanRegistLineMsg(ref string msg);
		private bool IsShowMsg();
		public bool GetSystemInfoText(SystemInfoType type, out string text);
	}
}
