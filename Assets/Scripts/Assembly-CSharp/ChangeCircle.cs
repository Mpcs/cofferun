using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class ChangeCircle : MonoBehaviour
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	private void Start()
	{
		base.gameObject.GetComponent<CircleCollider2D>().radius = base.gameObject.GetComponent<SpriteRenderer>().size.x / 2f;
	}
}
