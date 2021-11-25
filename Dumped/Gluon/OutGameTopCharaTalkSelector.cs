using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class OutGameTopCharaTalkSelector : MonoBehaviour
	{
		public enum Priority
		{
			None,
			High,
			Low
		}

		public enum Category0
		{
			Growth = 1,
			Fort,
			Shop,
			Record,
			Mypage,
			Album
		}

		public class TalkData
		{
			public int id;

			public int category1;

			public string text;

			public Priority priority;

			public string voiceId;

			public TalkData(int id, string text, Priority priority, string voiceId)
			{
			}
		}

		protected List<TalkData> specialList;

		protected List<TalkData> highList;

		protected List<TalkData> lowList;

		protected Dictionary<int, TalkData> allList;

		protected int maxLastPlayedHighCount;

		protected int maxLastPlayedLowCount;

		protected Queue<int> lastPlayedQueue;

		public virtual void Awake()
		{
		}

		public TalkData SelectTalk()
		{
			return null;
		}

		protected void AddTalkData(int id, string text, Priority priority, string voiceId)
		{
		}

		protected void ShuffleSpecialList()
		{
		}

		protected void ShuffleLowList()
		{
		}

		protected void ShuffleHighList()
		{
		}

		protected void LeftSpecialOne()
		{
		}

		protected void ShuffleList(ref List<TalkData> list)
		{
		}

		protected virtual TalkData SelectFromSpecialList()
		{
			return null;
		}

		protected virtual TalkData SelectFromHighList()
		{
			return null;
		}

		protected virtual TalkData SelectFromLowList()
		{
			return null;
		}

		protected TalkData SelectFromList(List<TalkData> list, int maxLastPlayedCount)
		{
			return null;
		}

		public static MenuTalkGroupElement GetActiveMenuTalkGroupId(Category0 category)
		{
			return null;
		}

		public TalkData GetTalkDataFromLowListById(int id)
		{
			return null;
		}
	}
}
