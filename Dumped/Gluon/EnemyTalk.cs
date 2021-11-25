using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class EnemyTalk
	{
		private delegate void deleWatchTrigger();

		private EnemyCharacter _owner;

		private NotifyCharacter.CharaDialogueNPCParam _dialogueParam;

		private List<EnemyTalkDataElement> _datas;

		private List<int> _candidates;

		private List<int> _finished;

		private static int TriggerNum;

		private deleWatchTrigger[] _watchTrigger;

		public bool NoTalk => default(bool);

		public void Initialize(EnemyCharacter owner)
		{
		}

		public void Reset()
		{
		}

		private void RegistryDelegate()
		{
		}

		public bool WatchTrigger(EnemyTalkTrigger trig)
		{
			return default(bool);
		}

		private void Talk(int id, bool clearAndPlay)
		{
		}

		private void FuncTrigger_EntryTiming()
		{
		}

		private void FuncTrigger_DeadTiming()
		{
		}

		private void FuncTrigger_HpRate()
		{
		}

		private void FuncTrigger_BreakHpRate()
		{
		}

		private void FuncTrigger_EventSkill_Satan01()
		{
		}

		private void FuncTrigger_EventSkill_Satan02()
		{
		}
	}
}
