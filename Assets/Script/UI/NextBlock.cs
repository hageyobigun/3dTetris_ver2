using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextBlock{

	public int block_Numbers;
    private List<Image> block_images;


    public NextBlock(List<Image> _block_images)
    {
        block_images = _block_images;
        block_Numbers = 0;                      
    }

    public void RandomBlock()
    {
        block_images[block_Numbers].gameObject.SetActive(false);
        block_Numbers = Random.Range(0, 7);
        block_images[block_Numbers].gameObject.SetActive(true);
    }

}
