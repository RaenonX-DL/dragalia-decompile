using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class DefenseEventInfoCtrl
	{
		private class MessageData : IReplicable<MessageData>, ICleanable
		{
			public int id;

			public DefenseEventWindowType windowType;

			public DefenseEventIconType iconType;

			public string iconName;

			public int nextAreaMessage;

			public string msg;

			public void Replicate(MessageData other)
			{
			}

			public void Clean()
			{
			}
		}

		public enum DecorationType
		{
			None = -1,
			FEH
		}

		public enum MoveObjIconType
		{
			None = -1,
			FEH_Platoon,
			FEH_Commander,
			FEH_Bandits,
			FEH_NUM
		}

		public enum SystemInfoType
		{
			FortDamage,
			FortDying,
			FortDead,
			HouseDead,
			NextArea
		}

		private InGameUIConst.DecorationType _decorationType;

		private List<DefenseEventProgressMoveObjUI> _idleMoveObjUIList;

		private Dictionary<int, DefenseEventProgressMoveObjUI> _usedMoveObjUIList;

		private DefenseEventLineMsgUI _lineMsgUI;

		private SimpleQueue<MessageData> _lineMsgQueue;

		private string _displayingLineMsg;

		private DefenseEventSystemInfoElement _systemInfo;

		private Dictionary<string, List<PlayFTU.MaterialInfo>> _ftuEventCutInMaterialDic;

		private bool _isInitialized;

		private const int LineMsgQueueDataMax = 8;

		private const int IconObjectReserveNum = 8;

		private const int CutInMaterialMaxNum = 2;

		private const float NextAreaMessageDisptime = 4.6f;

		private const float LineMsgUIAdjustPositionY = -70f;

		private const int SystemInfoDefaultID = 0;

		public const float SystemMsgUIAdjustPosY = -240f;

		public DefenseEventProgressInfoUI progressInfoUI
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float moveObjEndPointLength
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(GameObject parent, InGameUIConst.DecorationType type)
		{
		}

		private void LoadCutInMaterial()
		{
		}

		private bool IsLoadCutInMaterial(DefenseEventTalkElement talkData, int questId, int questGroupId)
		{
			return default(bool);
		}

		private void SetSystemInfoData()
		{
		}

		public void Update()
		{
		}

		public void SetActive(bool active)
		{
		}

		public void Reset()
		{
		}

		public void AttachMoveObj(EnemyCharacter chara, MoveObjIconType iconType)
		{
		}

		public void RemoveMoveObj(int enemySerialId)
		{
		}

		public void RemoveAllMoveObj()
		{
		}

		public void ChangeMoveObj(EnemyCharacter curChara, EnemyCharacter newChara)
		{
		}

		public void SetMoveObjIcon(EnemyCharacter chara, MoveObjIconType iconType)
		{
		}

		public void ApplyMoveObjPosition(EnemyCharacter chara)
		{
		}

		public void CalcMoveObjPathLineLongestDistance()
		{
		}

		public void ActionMoveObjAppear(EnemyCharacter chara)
		{
		}

		public void ActionMoveObjAttack(EnemyCharacter chara)
		{
		}

		public void ActionMoveObjDisappear(EnemyCharacter chara)
		{
		}

		public void ActionFortObjDamage()
		{
		}

		private void ApplyDrawingOrder(DefenseEventProgressMoveObjUI obj)
		{
		}

		public void SetFortObjHpRate(float rate, bool immediate = false)
		{
		}

		private bool IsLineMsgDisplaying(DefenseEventWindowType windowType)
		{
			return default(bool);
		}

		public void DisplayLineMsg(int id, bool isRegistCheck = false)
		{
		}

		public void DisplayLineMsg(int id, DefenseEventWindowType windowType, DefenseEventIconType iconType, string msg, string iconName, int nextAreaMessage, bool isRegistCheck)
		{
		}

		private void DisplayLineMsgSub(int id, DefenseEventWindowType windowType, DefenseEventIconType iconType, string msg, string iconName, int nextAreaMessage)
		{
		}

		private void OnCompleteLineMessage(DefenseEventIconType type, int nextAreaMessage)
		{
		}

		private bool CanRegistLineMsg(ref string msg)
		{
			return default(bool);
		}

		private bool IsShowMsg()
		{
			return default(bool);
		}

		public bool GetSystemInfoText(SystemInfoType type, out string text)
		{
			return default(bool);
		}
	}
}
