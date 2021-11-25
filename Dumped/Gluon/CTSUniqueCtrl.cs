using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;

namespace Gluon
{
	public class CTSUniqueCtrl : EnemyUniqueCtrl
	{
		public enum ShapeType
		{
			Circle,
			Triangle,
			Square
		}

		public enum PatternType
		{
			None,
			C_T_S,
			C_S_T,
			T_S_C,
			T_C_S,
			S_C_T,
			S_T_C
		}

		private PatternType _pattern;

		private List<ShapeType> _listAnswer;

		private bool _hasSetup;

		private bool _isValid;

		private int _answerIdx;

		private List<CTSUniqueCtrlForSub> _sametimeDeadCtrlForSubs;

		private int[,] _patternTable;

		public List<ShapeType> ReservedSubDeads
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

		public void ResetInfo()
		{
		}

		public void Setup(PatternType pattern)
		{
		}

		private void Update()
		{
		}

		public bool OnSubDead(CTSUniqueCtrlForSub ctrlSub, ShapeType shape)
		{
			return default(bool);
		}

		public void SendCTSSubDead(ShapeType shape)
		{
		}

		public void SendCTSIncorrect(List<CTSUniqueCtrlForSub> targets)
		{
		}

		public override void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent)
		{
		}
	}
}
