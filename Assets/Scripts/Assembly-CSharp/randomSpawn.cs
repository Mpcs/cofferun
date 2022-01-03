using System;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class randomSpawn : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x00002548 File Offset: 0x00000748
	public void RandomSpawn()
	{
		foreach (GameObject gameObject in UnityEngine.Object.FindObjectsOfType<GameObject>())
		{
			if (gameObject.name.Contains("(Clone)"))
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this.oldIC = this.bricks;
		int num = 0;
		while ((float)num < (float)this.ile * 2.6f)
		{
			this.IC = UnityEngine.Object.Instantiate<GameObject>(this.bricks, new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f), this.parent);
			this.IC.GetComponent<SpriteRenderer>().size = new Vector2((float)this.rnd.Next(1, 10), (float)this.rnd.Next(1, 16));
			if (this.rnd.Next(10) != 0)
			{
				this.IC.transform.position = new Vector3(this.oldIC.transform.position.x + this.oldIC.GetComponent<SpriteRenderer>().size.x / 2f + this.IC.GetComponent<SpriteRenderer>().size.x / 2f + (float)this.rnd.Next(1, 5), this.IC.GetComponent<SpriteRenderer>().size.y / 2f - 4.66f, 0f);
			}
			else
			{
				this.IC.transform.position = new Vector3(this.oldIC.transform.position.x + this.oldIC.GetComponent<SpriteRenderer>().size.x / 2f + this.IC.GetComponent<SpriteRenderer>().size.x / 2f + (float)this.rnd.Next(1, 5), this.IC.GetComponent<SpriteRenderer>().size.y / 2f - 4.66f + (float)this.rnd.Next(1, 5), 0f);
			}
			if (this.IC.transform.position.x > 1150f)
			{
				break;
			}
			this.oldIC = this.IC;
			num++;
		}
		this.oldIC = this.stone;
		for (int j = 0; j < 5; j++)
		{
			for (int k = 0; k < this.ile; k++)
			{
				this.wynik = this.rnd.Next(2, 8);
				this.IC = UnityEngine.Object.Instantiate<GameObject>(this.stone, new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f), this.parent);
				this.IC.GetComponent<SpriteRenderer>().size = new Vector2((float)this.wynik, (float)this.wynik);
				this.IC.transform.position = new Vector3(this.oldIC.transform.position.x + this.oldIC.GetComponent<SpriteRenderer>().size.x / 2f + this.IC.GetComponent<SpriteRenderer>().size.x / 2f + (float)this.rnd.Next(1, 30), this.IC.GetComponent<SpriteRenderer>().size.y / 2f + (float)this.rnd.Next(1, 50) + 18f, 0f);
				this.oldIC = this.IC;
				if (this.IC.transform.position.x > 1150f)
				{
					break;
				}
			}
			this.IC.transform.position = new Vector3(0f, this.IC.transform.position.y + 40f, 0f);
			this.oldIC = this.IC;
		}
		for (int l = 0; l < 200; l++)
		{
			this.IC = UnityEngine.Object.Instantiate<GameObject>(this.coffe, new Vector3((float)this.rnd.Next(10, 1150), (float)this.rnd.Next(0, 60), 1f), new Quaternion(0f, 0f, 0f, 0f), this.parent);
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002A3B File Offset: 0x00000C3B
	private void Start()
	{
		this.RandomSpawn();
	}

	// Token: 0x0400000E RID: 14
	public GameObject bricks;

	// Token: 0x0400000F RID: 15
	public Transform parent;

	// Token: 0x04000010 RID: 16
	public GameObject stone;

	// Token: 0x04000011 RID: 17
	private System.Random rnd = new System.Random();

	// Token: 0x04000012 RID: 18
	private GameObject IC;

	// Token: 0x04000013 RID: 19
	private GameObject oldIC;

	// Token: 0x04000014 RID: 20
	public int ile = 5;

	// Token: 0x04000015 RID: 21
	private int wynik;

	// Token: 0x04000016 RID: 22
	public GameObject coffe;
}
