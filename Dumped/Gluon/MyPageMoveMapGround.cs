using UnityEngine;

namespace Gluon
{
	public class MyPageMoveMapGround : MonoBehaviour
	{
		[Header("é¢\u00a8è»\u008aã\u0081®å\u009b\u009eè»¢è£\u009cæ­£ä½\u008dç½®ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		public GameObject windmill_moving;

		[Header("å\u009b\u009eè»¢è£\u009cæ­£ã\u0083­ã\u0082±ã\u0083¼ã\u0082¿ã\u0083¼")]
		public GameObject[] locators;

		[Header("ã\u0083­ã\u0082±ã\u0083¼ã\u0082¿ã\u0083¼ã\u0081®å\u009b\u009eè»¢")]
		public Vector3[] locatorRotation;

		[Header("ã\u0083­ã\u0082±ã\u0083¼ã\u0082¿ã\u0083¼ã\u0081\u008cå\u009b\u009eè»¢é\u0096\u008bå§\u008bã\u0081\u0099ã\u0082\u008bå\u009c°é\u009d¢ã\u0081®å\u009b\u009eè»¢")]
		public float[] locatorStart;

		private void Awake()
		{
		}
	}
}
