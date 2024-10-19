public class ManaPotionFactory : IPotionFactory
{
    public IPotionColor CreateColor() => new BlueColor();
    public IPotionIngredient CreateIngredient() => new MagicMushroomIngredient();
}