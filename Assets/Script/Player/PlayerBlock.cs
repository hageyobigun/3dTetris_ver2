using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlock : MonoBehaviour {

    [SerializeField] private List<GameObject> playerBlock;
    [SerializeField] private Transform blockPlace;

    //ブロック生成
    public GameObject BlockInstance()
    {
        var BlockNumbers = Random.Range(0, 7);
        //改善予定
        var player = Instantiate(playerBlock[BlockNumbers], new Vector3(Block.PlayerPos, 19f, Block.PlayerPos), Quaternion.identity);
        player.transform.SetParent(blockPlace, false);
        return (player);
    }
}
