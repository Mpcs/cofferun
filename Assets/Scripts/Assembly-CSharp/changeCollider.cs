using System;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class changeCollider : MonoBehaviour
{
	// Token: 0x06000004 RID: 4 RVA: 0x0000209B File Offset: 0x0000029B
	private void Start()
	{
		base.gameObject.GetComponent<BoxCollider2D>().size = base.gameObject.GetComponent<SpriteRenderer>().size;
	}
}
