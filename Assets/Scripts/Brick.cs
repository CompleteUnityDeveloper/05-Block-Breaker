using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
    // config parameters
	[SerializeField] AudioClip crack;
    [SerializeField] Sprite[] hitSprites;
    [SerializeField] GameObject smokeParticles;
    [SerializeField] string runtimeParentName = "Runtime Objects"; 

    // state variables
	int timesHit;

    // cached references
    Level level;
	
	void Start()
    {
        level = FindObjectOfType<Level>();
        CountBreakableBricks();
    }

    private void CountBreakableBricks()
    {
        if (tag == "Breakable")
        {
            level.RegisterBreakableBrick();
        }
    }

    void OnCollisionEnter2D()
    {
		//AudioSource.PlayClipAtPoint(crack, Camera.main.transform.position);
        if (tag == "Breakable")
        {
            HandleHit();
		}
	}
	
	private void HandleHit()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1; // remember we have an unhit sprite in sprite renderer
		if (timesHit >= maxHits)  // why greater than? In case 2 hits in one frame
        {
            DestroyBrick();
        }
        else
        {
			ShowNextHitSprites();
		}
	}

    private void DestroyBrick()
    {
        PuffSmoke();
        level.BrickDestoyed();
        Destroy(gameObject);
    }

    private void PuffSmoke()
    {
		GameObject smokePuff = Instantiate (smokeParticles, transform.position, transform.rotation);
        Destroy(smokePuff, 2f);
        //var mainParticleSystem = smokePuff.GetComponent<ParticleSystem>().main;
        //mainParticleSystem.startColor = gameObject.GetComponent<SpriteRenderer>().color;
	}
	
	void ShowNextHitSprites()
    {
		int spriteIndex = timesHit - 1;
		
		if (hitSprites[spriteIndex] != null)
        {
			GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
        else
        {
			Debug.LogError ("Brick sprite missing");
		}
	}
}
