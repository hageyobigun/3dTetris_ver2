using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class PlayerBlock : MonoBehaviour {

    [SerializeField] private List<GameObject> playerBlock;
    [SerializeField] private List<Image> block_images;
    [SerializeField] private Transform blockPlace;

    private NextBlock nextBlock;

    private void Start()
    {
        nextBlock = new NextBlock(block_images);
    }

    //ブロック生成
    public GameObject BlockInstance()
    {
        //改善予定
        var block = Instantiate(playerBlock[nextBlock.block_Numbers], new Vector3(StageManeger.Instance.PlayerPos, 19f, StageManeger.Instance.PlayerPos), Quaternion.identity);
        block.transform.SetParent(blockPlace, false);
        nextBlock.RandomBlock();

        return (block);
    }
}
