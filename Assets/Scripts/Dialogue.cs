using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{
    private string Name;
    private string[] sentences;
    void Start()
    {
        Name = PlayerStaticInformation.PlayerName;
        sentences = new string[10]
        {
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
            "asdasdsaakdfSdiLhgfjasjauhsgizfyasoufhioyuhoshfuv dsiFhIDFhisuofi",
        };
    }

    public string[] GetDialogueInformation()
    {
        System.Random random = new System.Random();
        return new string[2] { Name, sentences[random.Next(0, 10)] };
    }
}
