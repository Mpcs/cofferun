using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000005 RID: 5
public class movement : MonoBehaviour
{
	// Token: 0x06000008 RID: 8 RVA: 0x000020F0 File Offset: 0x000002F0
	public void Update()
	{
		if (this.rb.velocity.x < (float)(this.speed + this.points * 2))
		{
			this.rb.AddForce(new Vector2((float)(this.speed + this.points * 2), 0f));
		}
		this.tlo.position = new Vector3(this.player.position.x + 9.675805f, 6.7f, 13f);
		if (this.player.position.y > 10f)
		{
			Physics2D.gravity = new Vector3(0f, -2f, 0f);
			this.c.position = new Vector3(this.player.position.x + (float)this.offset, this.player.position.y, -13f);
		}
		else
		{
			Physics2D.gravity = new Vector3(0f, -9.81f, 0f);
			this.c.position = new Vector3(this.player.position.x + (float)this.offset, 0f, -13f);
		}
		if (this.player.position.x > 1170f)
		{
			this.player.position = new Vector3(-20f, this.player.position.y, 0f);
			this.ES.GetComponent<randomSpawn>().RandomSpawn();
		}
		this.dirt.position = new Vector3(this.c.position.x, -4.66f, this.dirt.position.z);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000022EE File Offset: 0x000004EE
	public void jump()
	{
		if (this.colliding)
		{
			this.colliding = false;
			this.rb.AddForce(new Vector2(0f, (float)(this.pow + this.points / 2)));
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002327 File Offset: 0x00000527
	public void down()
	{
		if (this.colliding)
		{
			this.colliding = false;
			this.rb.AddForce(new Vector2(0f, (float)(-(float)this.pow - this.points / 3)));
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002364 File Offset: 0x00000564
	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.name == "dirt")
		{
			if (this.player.rotation.z > 30f || this.player.rotation.z < -30f)
			{
				this.rb.AddForce(new Vector2(0f, 2f));
				this.player.Rotate(new Vector3(0f, 0f, 0f));
			}
			this.rb.velocity = Vector3.zero;
		}
		if (col.collider.name == "tramp")
		{
			this.rb.AddForce(new Vector3(0f, (float)this.pow * 2.8f, 0f));
		}
		if (col.collider.name == "kawa(Clone)")
		{
			UnityEngine.Object.Destroy(col.gameObject);
			this.points++;
			this.ptxt.text = this.points.ToString();
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000024A8 File Offset: 0x000006A8
	public void OnCollisionStay2D(Collision2D col)
	{
		if (col.collider.name != "tramp")
		{
			this.colliding = true;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000024CC File Offset: 0x000006CC
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "night")
		{
			this.anim.Play("playerReverse");
		}
		if (col.gameObject.tag == "day")
		{
			this.anim.Play("Player");
		}
	}

	// Token: 0x04000001 RID: 1
	public Rigidbody2D rb;

	// Token: 0x04000002 RID: 2
	public int pow = 5;

	// Token: 0x04000003 RID: 3
	public int speed = 10;

	// Token: 0x04000004 RID: 4
	public Transform c;

	// Token: 0x04000005 RID: 5
	public int offset;

	// Token: 0x04000006 RID: 6
	public Transform player;

	// Token: 0x04000007 RID: 7
	private bool colliding = true;

	// Token: 0x04000008 RID: 8
	public Transform tlo;

	// Token: 0x04000009 RID: 9
	public Transform dirt;

	// Token: 0x0400000A RID: 10
	public Animator anim;

	// Token: 0x0400000B RID: 11
	public GameObject ES;

	// Token: 0x0400000C RID: 12
	public int points;

	// Token: 0x0400000D RID: 13
	public Text ptxt;
}
