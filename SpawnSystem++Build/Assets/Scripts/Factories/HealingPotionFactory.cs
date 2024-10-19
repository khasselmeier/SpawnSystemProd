public class HealingPotionFactory : IPotionFactory
{
    public IPotionColor CreateColor() => new RedColor();
    public IPotionIngredient CreateIngredient() => new HerbIngredient();
}