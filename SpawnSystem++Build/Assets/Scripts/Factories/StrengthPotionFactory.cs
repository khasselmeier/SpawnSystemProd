public class StrengthPotionFactory : IPotionFactory
{
    public IPotionColor CreateColor() => new GreenColor();
    public IPotionIngredient CreateIngredient() => new DragonScaleIngredient();
}