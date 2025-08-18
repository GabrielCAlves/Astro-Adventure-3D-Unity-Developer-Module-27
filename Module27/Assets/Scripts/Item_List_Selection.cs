using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_List_Selection : MonoBehaviour
{
    public List<string> list = new List<string> { "Círculo", "Triângulo", "Quadrado", "Pentágono", "Hexágono", "Septágono", "Octógono" };
    private List<string> _listHelper = new List<string>();
    private string _item;
    private int _firstTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_listHelper.Count == list.Count && _firstTime != 0)
            {
                Debug.Log("Todos os itens já foram sorteados!");
            }
            else
            {
                _item = GetItem();

                Debug.Log("Item aleatório sorteado: " + _item);
                
                ++_firstTime;
            }
        }
    }

    private string GetItem()
    {
        return list.GetRandomButNotSame(list[0], _listHelper);
    }
}
