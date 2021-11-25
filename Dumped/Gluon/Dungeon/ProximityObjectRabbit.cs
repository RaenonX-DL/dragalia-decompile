using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class ProximityObjectRabbit : FastUpdateMonoBehaviour
	{
		private enum State
		{
			Idle,
			Surprise,
			MoveAway,
			MoveWaiting,
			MoveReturn
		}

		[SerializeField]
		[Tooltip("è¿\u0091ã\u0081¥ã\u0081\u0084ã\u0081\u009fã\u0082\u0089é©\u009aã\u0081\u008fè·\u009dé\u009b¢")]
		private float SurpriseDistance;

		[SerializeField]
		[Tooltip("è¿\u0091ã\u0081¥ã\u0081\u0084ã\u0081\u009fã\u0082\u0089é\u0080\u0083ã\u0081\u0092ã\u0082\u008bè·\u009dé\u009b¢")]
		private float AwayDistance;

		[SerializeField]
		[Tooltip("é\u0080\u0083ã\u0081\u0092ã\u0081\u009fã\u0081\u0082ã\u0081\u00a8å¾\u0085æ©\u009fã\u0081\u0099ã\u0082\u008bæ\u0099\u0082é\u0096\u0093(ç§\u0092)")]
		private float WaitTimeSecond;

		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095ç\u009b®æ\u00a8\u0099å\u009c°ç\u0082¹ã\u0082\u0092ã\u0080\u0081ã\u0081\u0093ã\u0081®ã\u0083\u008eã\u0083¼ã\u0083\u0089ã\u0081®å­\u0090ã\u0081®TargetMovePosã\u0081§æ\u008c\u0087å®\u009a")]
		private Transform targetTransform;

		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095é\u0080\u009fåº¦")]
		private float speed;

		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095çµ\u0082äº\u0086ã\u0081®ä½\u0095ç§\u0092å\u0089\u008dã\u0081\u008bã\u0082\u0089ã\u0080\u0081æ­©ã\u0081\u008dçµ\u0082äº\u0086ã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081\u00b8ç§»è¡\u008cã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
		private float MoveEndTime;

		private Animator anim;

		private int hashMoveEnd;

		private int hashMoveIn;

		private int hashSurprise;

		private Vector3 initialPos;

		private Vector3 startPos;

		private Vector3 targetPos;

		private float moveWaitingTimer;

		private State state;

		private void Start()
		{
		}

		public override void FastUpdate()
		{
		}

		private void StartMove(Vector3 spos, Vector3 epos)
		{
		}

		private void OnSurpriseDistance()
		{
		}

		private void OnMoveStartDistance()
		{
		}

		private void OnDistanceExit()
		{
		}
	}
}
