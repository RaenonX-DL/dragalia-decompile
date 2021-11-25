using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class WinningProduction : ProductionBase
	{
		private int winNum;

		private float[] winAnimStartTime;

		private int winStep;

		private string winCueName;

		private string winSeName;

		private string winJingleName;

		private bool isPlayWinVoice;

		private bool endPlay;

		public const float Length = 4.7f;

		public const float UI_START_TIME = 2.2f;

		private List<CharacterBase> characterList;

		private List<Vector3> positionList;

		private List<Quaternion> rotationList;

		private int cameraNo;

		public float winTime
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

		public bool isPlayQuestClear
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsPlaying => default(bool);

		public void Initialize()
		{
		}

		public void InitializeCharacter()
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		public void PauseCameraAnimation()
		{
		}

		private void OnSkip()
		{
		}
	}
}
