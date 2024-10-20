using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class PotionBrewing : MonoBehaviour
{
    public TMP_Dropdown effectDropdown;
    public TMP_Dropdown colorDropdown;
    public TMP_Dropdown ingredientDropdown;
    public TextMeshProUGUI resultText;
    public Image potionImage;

    public Sprite[] potionSprites;

    private IPotionFactory potionFactory;

    public void BrewPotion()
    {
        string selectedEffect = effectDropdown.options[effectDropdown.value].text;
        string selectedColor = colorDropdown.options[colorDropdown.value].text;
        string selectedIngredient = ingredientDropdown.options[ingredientDropdown.value].text;

        // assign the correct potion factory based on the selected ingredient
        switch (selectedIngredient)
        {
            case "Herb":
                potionFactory = new HealingPotionFactory();
                break;
            case "Magic Mushroom":
                potionFactory = new ManaPotionFactory();
                break;
            case "Dragon Scale":
                potionFactory = new StrengthPotionFactory();
                break;
            default:
                resultText.text = "Unknown ingredient";
                return;
        }

        // create the potion effect based on the selected dropdown effect
        IPotionEffect effect = CreateEffect(selectedEffect);

        // create potion components for color and ingredient
        IPotionColor color = potionFactory.CreateColor();
        IPotionIngredient potionIngredient = potionFactory.CreateIngredient();

        resultText.text = $"Brewed a {selectedColor} {effect.GetEffect()} potion using a {potionIngredient.GetIngredient()}!";

        // update sprite
        UpdatePotionSprite(selectedEffect, selectedColor, selectedIngredient);
    }

    private IPotionEffect CreateEffect(string effectType)
    {
        switch (effectType)
        {
            case "Healing":
                return new HealingEffect();
            case "Mana Restoration":
                return new ManaEffect();
            case "Strength Boost":
                return new StrengthEffect();
            default:
                return null;
        }
    }

    private void UpdatePotionSprite(string effect, string color, string ingredient)
    {
        if (effect == "Healing" && color == "Red" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[0];
        }
        else if (effect == "Healing" && color == "Red" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[1];
        }
        else if (effect == "Healing" && color == "Red" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[2];
        }
        else if (effect == "Healing" && color == "Blue" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[3];
        }
        else if (effect == "Healing" && color == "Blue" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[4];
        }
        else if (effect == "Healing" && color == "Blue" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[5];
        }
        else if (effect == "Healing" && color == "Green" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[6];
        }
        else if (effect == "Healing" && color == "Green" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[7];
        }
        else if (effect == "Healing" && color == "Green" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[8];
        }
        else if (effect == "Mana Restoration" && color == "Red" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[9];
        }
        else if (effect == "Mana Restoration" && color == "Red" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[10];
        }
        else if (effect == "Mana Restoration" && color == "Red" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[11];
        }
        else if (effect == "Mana Restoration" && color == "Blue" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[12];
        }
        else if (effect == "Mana Restoration" && color == "Blue" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[13];
        }
        else if (effect == "Mana Restoration" && color == "Blue" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[14];
        }
        else if (effect == "Mana Restoration" && color == "Green" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[15];
        }
        else if (effect == "Mana Restoration" && color == "Green" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[16];
        }
        else if (effect == "Mana Restoration" && color == "Green" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[17];
        }
        else if (effect == "Strength Boost" && color == "Red" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[18];
        }
        else if (effect == "Strength Boost" && color == "Red" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[19];
        }
        else if (effect == "Strength Boost" && color == "Red" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[20];
        }
        else if (effect == "Strength Boost" && color == "Blue" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[21];
        }
        else if (effect == "Strength Boost" && color == "Blue" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[22];
        }
        else if (effect == "Strength Boost" && color == "Blue" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[23];
        }
        else if (effect == "Strength Boost" && color == "Green" && ingredient == "Herb")
        {
            potionImage.sprite = potionSprites[24];
        }
        else if (effect == "Strength Boost" && color == "Green" && ingredient == "Magic Mushroom")
        {
            potionImage.sprite = potionSprites[25];
        }
        else if (effect == "Strength Boost" && color == "Green" && ingredient == "Dragon Scale")
        {
            potionImage.sprite = potionSprites[26];
        }
        else
        {
            potionImage.sprite = null;
        }

        if (potionImage.sprite != null)
        {
            potionImage.gameObject.SetActive(true);
        }
    }

    // options for each dropdown
    void Start()
    {
        effectDropdown.AddOptions(new List<string> { "Healing", "Mana Restoration", "Strength Boost" });
        colorDropdown.AddOptions(new List<string> { "Red", "Blue", "Green" });
        ingredientDropdown.AddOptions(new List<string> { "Herb", "Magic Mushroom", "Dragon Scale" });

        potionImage.gameObject.SetActive(false); // sets potion image false at the start
    }
}