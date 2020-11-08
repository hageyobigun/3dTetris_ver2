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
        var block = Instantiate(playerBlock[BlockNumbers], new Vector3(StageManeger.Instance.PlayerPos, 19f, StageManeger.Instance.PlayerPos), Quaternion.identity);
        block.transform.SetParent(blockPlace, false);
        return (block);
    }
}
