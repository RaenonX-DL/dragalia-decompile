using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class QuestSkillTalk
	{
		private delegate void deleWatchTrigger(float paramFloat_1 = 0f, float paraFloat_2 = 0f);

		private NotifyCharacter.CharaDialogueNPCParam _dialogueParam;

		private List<QuestSkillTalkElement> _datas;

		private List<int> _candidates;

		private List<int> _finished;

		private static int TriggerNum;

		private deleWatchTrigger[] _watchTrigger;

		private QuestSkillEnum questSkillType;

		public bool NoTalk => default(bool);

		public QuestSkillTalk(QuestSkillEnum type)
		{
		}

		public void Initialize()
		{
		}

		public void Reset()
		{
		}

		private void RegistryDelegate()
		{
		}

		public bool WatchTrigger(QuestSkillTalkTrigger trig, float paramFloat_1 = 0f, float paramFloat_2 = 0f)
		{
			return default(bool);
		}

		private void Talk(int id)
		{
		}

		private void FuncTrigger_QuestSkill(float paramFloat_1 = 0f, float paramFloat_2 = 0f)
		{
		}

		private void FuncTrigger_RecastRateHiger(float paramFloat_1 = 0f, float paramFloat_2 = 0f)
		{
		}

		private void FuncTrigger_PrayObjectDestory(float paramFloat_1 = 0f, float paramFloat_2 = 0f)
		{
		}

		private void FuncTrigger_MiasmaBegin(float paramFloat_1 = 0f, float paramFloat_2 = 0f)
		{
		}
	}
}
