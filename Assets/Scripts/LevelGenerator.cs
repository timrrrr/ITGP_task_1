using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelGenerator : MonoBehaviour
{
    public Vector3 _endPoint = new Vector3(0, 0, 0);
    public GameObject LevelPiecePrefab;
    public int _directionIndex = 0;

    public void GenerateLevel()
    {
        for (int i = 0; i < 16; i++)
        {
            float randLength = Random.Range(2.0f, 15.0f);

            //let's compute position and scale of our new piece
            Vector3 whereToPut = _endPoint;
            Vector3 newScale = LevelPiecePrefab.transform.localScale;
            
            if (_directionIndex == 0)
            {
                whereToPut.z += randLength / 2.0f;
                newScale.z = randLength + 2.0f;
                _directionIndex = 1;
                _endPoint.z += randLength;
            }
            else
            {
                whereToPut.x -= randLength / 2.0f;
                newScale.x = randLength + 2.0f;
                _directionIndex = 0;
                _endPoint.x -= randLength;
            }
            GameObject piece = Instantiate(LevelPiecePrefab, whereToPut, Quaternion.identity);
            piece.transform.localScale = newScale;

        }
    }

    public void Awake()
    {
        GenerateLevel();
    }
}
