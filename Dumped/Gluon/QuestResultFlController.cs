using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class QuestResultFlController
	{
		private FlashPlayer _flashPlayer;

		private FlMotion rootMotion;

		private FlMotion _effectTriggerMotion;

		private FlMotion numberTargetMotion;

		private int flashNumberValue;

		private List<FlMotion> effectFlMotionList;

		public FlashPlayer flashPlayer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isInit
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FlMotion effectTriggerMotion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private FlMotion GetMotion(string motionName)
		{
			return null;
		}

		private void SetEffectFlMotion(string trigger, string[] effects)
		{
		}

		public bool LoadFlashPrefab(string path, Transform parent, string triggerName, string[] effects, int numberValue, string numberTargetName, int numberTargetValue, int sortingOrder)
		{
			return default(bool);
		}

		public void FlEnter()
		{
		}

		public void FlExit()
		{
		}

		public void FlEffectStart()
		{
		}

		public void FlEffectReset()
		{
		}
	}
}
