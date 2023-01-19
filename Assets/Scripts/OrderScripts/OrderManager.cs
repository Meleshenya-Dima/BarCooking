using Assets.Scripts.OrderScripts;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    private List<Notes> _orderListOpenNow;

    private List<Order> _compliteOrderList;

    public Image firstImage;
    public Image secondImage;
    public Image threedImage;

    void Start()
    {
        _orderListOpenNow = new List<Notes>()
        {
            new Notes {imageNotes = firstImage, IsFree = true },
            new Notes {imageNotes = secondImage, IsFree = true},
            new Notes {imageNotes = threedImage, IsFree = true}
        };

        _compliteOrderList = new List<Order>()
        {
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
            new Order{ OrderText = "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi"},
        };
    }

    public bool AddOrderList(string orderText)
    {
        bool isAdd = false;
        foreach (var notes in _orderListOpenNow)
        {
            if (notes.IsFree)
            {
                notes.imageNotes.GetComponentInChildren<Text>().text = orderText;
                notes.imageNotes.GetComponent<Animator>().SetBool("IsOpen", true);

                notes.IsFree = false;
                return !isAdd;
            }
        }
        return isAdd;
    }

    public void RemoveOrderList()
    {

    }
}
