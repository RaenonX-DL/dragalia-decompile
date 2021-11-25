using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class TutorialCtrl : MonoBehaviour
	{
		private enum DialogState
		{
			Select,
			Ok,
			Cancel
		}

		private const float SystemMsgTutorialUIAdjustPosY = 100f;

		private const float SystemMsgDisplayTimeLength = 6f;

		private const int WALK_FRAME = 45;

		private const int BUTTON_PRIORITY_OFFSET = 10;

		private const float MOVE_TUTORIAL_FINISH_POS_Z = 12f;

		private SysMessageUI sysMessage;

		private FingerUI finger;

		private Color backgroundColor;

		private int startCurrentArea;

		private const int fontSize = 24;

		private bool isPopEnemy;

		private string dialogTitle;

		private bool isOpenDualWindow;

		private Canvas dualWindowCanvas;

		private InGameUICtrl inGameUICtrl;

		private Coroutine tutorialJudgeCoroutine;

		private bool isChangeSysMessagePos;

		private const int TUTORIAL_FLT_HEAD = 31;

		private const int TUTORIAL_FLT_LAST = 38;

		private const int TUTORIAL_FLT_MAX = 8;

		private const int TUTORIAL_FLASH_REACT_MAX = 3;

		private float[] anime_react_frame;

		private const float SKILL_DRAGON_FINGER_SHOWFRAME = 35f;

		private const float FLASH_ANIM_CREATED_RATE = 30f;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void EventPopEnemy()
		{
		}

		private IEnumerator TutorialArea1()
		{
			return null;
		}

		private IEnumerator TutorialArea2()
		{
			return null;
		}

		private IEnumerator TutorialArea3()
		{
			return null;
		}

		private IEnumerator PlayScript(string scriptName)
		{
			return null;
		}

		private IEnumerator WaitStartTutorial()
		{
			return null;
		}

		private IEnumerator WaitSysMessage()
		{
			return null;
		}

		private void PauseInGame(bool pause)
		{
		}

		private void OpenDualWindow(int[] key)
		{
		}

		private void OnCompleteDualWindow()
		{
		}

		private IEnumerator WaitDualWindow()
		{
			return null;
		}

		private string GetGuideWindowText(int key)
		{
			return null;
		}

		public bool IsOpenWindow()
		{
			return default(bool);
		}

		private IEnumerator MoveAttackTutorialCoroutine()
		{
			return null;
		}

		private IEnumerator AvoidTutorialCoroutine()
		{
			return null;
		}

		private void AddSkillButtonOrderInLayer(int add)
		{
		}

		private void SetSkillButtonEnableTap(bool enable)
		{
		}

		private void AddDragonButtonOrderInLayer(int add)
		{
		}

		private void ChangeSystemMessagePos()
		{
		}

		private void CloseSystemMessage()
		{
		}
	}
}
