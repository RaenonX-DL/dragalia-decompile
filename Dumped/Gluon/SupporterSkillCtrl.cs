using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class SupporterSkillCtrl
	{
		public enum State
		{
			None,
			Active
		}

		public class TextData
		{
			public int type;

			public string text;

			public void Clear()
			{
			}
		}

		private Dictionary<int, TextData> textDic;

		private int _skillId;

		private float _supportEndGameTime;

		private NotifyCharacter.SkillCutInParam _skillCutInParam;

		public State state
		{
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Start()
		{
		}

		public void Update()
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public void EndProcess()
		{
		}

		public void SetText(int type, string text, int groupNo)
		{
		}

		private void DispText(TextData data, CharacterBase player)
		{
		}

		private void SetActivePlayer(bool isVisible)
		{
		}

		private void SetElapsedGameTime(PlayerCharacter supporter)
		{
		}
	}
}
