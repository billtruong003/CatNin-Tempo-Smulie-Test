using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class PlatformBuild : MonoBehaviour
{

    [SerializeField] private List<Sprite> platformSprites;
    [SerializeField] private GameObject Brick;
    [SerializeField] private GameObject SeparateBlock;
    [SerializeField] private GameObject ContainerBlock;
    private float spacing = 0.7f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    [Button]
    private void BuildPlatform()
    {

        Init(Random.Range(4, 10));
    }
    private void Init(int numBrick)
    {
        GameObject newBrick = Instantiate(Brick);
        for (int i = 0; i < numBrick; i++)
        {
            int counting = i + 1;

            GameObject newBlock = Instantiate(SeparateBlock, ContainerBlock.transform);
            newBlock.transform.position = new Vector2(0, -(counting * spacing));

            SpriteRenderer blockSprite = newBlock.GetComponent<SpriteRenderer>();
            blockSprite.sprite = RandomSprite();
            blockSprite.sortingOrder = counting;
        }
    }
    private Sprite RandomSprite()
    {
        int randNum = Random.Range(0, platformSprites.Count);
        return platformSprites[randNum];
    }
}
